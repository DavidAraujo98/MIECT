# /*******************************************
# Name: David José Araújo Ferreira
# Nº Mec: 93444
# *******************************************/

from tree_search import *
from cidades import *
from blocksworld import *
import functools


def func_branching(connections, coordinates):
    # IMPLEMENT HERE
    neighbours = []
    for city in coordinates:
        n = 0
        for (c1, c2, c) in connections:
            if city == c1 or city == c2:
                n += 1
        neighbours += [n]
    return (sum(neighbours) / len(neighbours))-1


class MyCities(Cidades):
    def __init__(self, connections, coordinates):
        super().__init__(connections, coordinates)
        self.branching = func_branching(connections, coordinates)
        # ADD CODE HERE IF NEEDED


class MySTRIPS(STRIPS):
    def __init__(self, optimize=False):
        super().__init__(optimize)

    def simulate_plan(self, state, plan):
        for ac in plan:
            state = self.result(state, ac)
        return state
        pass


class MyNode(SearchNode):
    def __init__(self, state, parent, cost=None, heuristic=None, depth=None):
        super().__init__(state, parent)
        self.cost = cost
        self.heuristic = heuristic
        self.depth = depth
        # ADD HERE ANY CODE YOU NEED


class MyTree(SearchTree):

    def __init__(self, problem, strategy='breadth', optimize=0, keep=0.25):
        super().__init__(problem, strategy)
        self.open_nodes = [0]
        if optimize == 1:
            root = (problem.initial, None, 0, 0, 0)
            self.all_nodes = [root]
        elif optimize >= 2:
            root = (problem[1], None, 0, 0, 0)
            self.all_nodes = [root]
            domain = (
                problem[0][0],
                problem[0][1],
                problem[0][2],
                problem[0][3],
                problem[0][4],
                problem[0][5])
            self.problem = (domain, problem[1], problem[2])
        self.optimize = optimize
        self.keep = keep
        self.solution = None
        self.non_terminals = 0

        # ADD HERE ANY CODE YOU NEED

    def astar_add_to_open(self, lnewnodes):
        self.open_nodes = self.open_nodes+lnewnodes
        nodes = self.astr_evaluation()
        self.open_nodes = []
        for n in nodes:
            self.open_nodes.append(n[1])
        pass

    def astr_evaluation(self):
        nodes = []
        for id in self.open_nodes:
            nodes.append((self.all_nodes[id], id))

        def func(n): return n[0].cost + n[0].heuristic
        if self.optimize >= 1:
            def func(node): return node[0][2] + node[0][3]

        return sorted(nodes, key=func)
    # remove a fraction of open (terminal) nodes
    # with lowest evaluation function
    # (used in Incrementally Bounded A*)

    def forget_worst_terminals(self):
        func = None
        if self.optimize == 0:
            def func(
                n1, n2): return self.all_nodes[n1].depth + self.all_nodes[n2].depth
        elif self.optimize >= 1:
            def func(
                n1, n2): return self.all_nodes[n1][4]+self.all_nodes[n2][4]
        d = int(functools.reduce(func, self.open_nodes) / len(self.open_nodes))

        depth_d_nodes = []
        if self.optimize == 0:
            depth_d_nodes = list(
                filter(lambda node: node.parent == None and node.depth == d, self.all_nodes))
            for n in self.all_nodes:
                if n.parent in depth_d_nodes:
                    depth_d_nodes.remove(n)
        elif self.optimize >= 1:
            depth_d_nodes = list(
                filter(lambda node: node[4] == d, self.all_nodes))
            for n in self.all_nodes:
                if n[1] in depth_d_nodes:
                    depth_d_nodes.remove(n[1])

        numKeep = 1 + (self.keep * len(depth_d_nodes))
        nodes = self.astr_evaluation()
        self.open_nodes = []
        for n in nodes:
            self.open_nodes.append(n[1])
            if len(self.open_nodes) == numKeep:
                break

    # procurar a solucao
    def search2(self):
        if self.optimize == 1:
            while self.open_nodes != []:
                nodeID = self.open_nodes.pop(0)
                node = self.all_nodes[nodeID]
                if self.problem.goal_test(node[0]):
                    self.solution = node
                    self.terminals = len(self.open_nodes)+1
                    return self.get_path_tuple(node)
                lnewnodes = []
                self.non_terminals += 1
                for a in self.problem.domain.actions(node[0]):
                    newstate = self.problem.domain.result(node[0], a)
                    if newstate not in self.get_path_tuple(node):
                        depth = 0
                        heuristic = self.problem.domain.heuristic(
                            newstate, self.problem.goal)
                        cost = self.problem.domain.cost(
                            node[0], a)
                        if node != self.all_nodes[0]:
                            cost += node[2]
                            depth = node[4]
                        newnode = (newstate, nodeID, cost,
                                   heuristic, depth + 1)
                        lnewnodes.append(len(self.all_nodes))
                        self.all_nodes.append(newnode)
                self.add_to_open(lnewnodes)
                # self.forget_worst_terminals()
            return None
        elif self.optimize == 2:
            while self.open_nodes != []:
                nodeID = self.open_nodes.pop(0)
                node = self.all_nodes[nodeID]
                if self.problem[0][4](node[0], self.problem[2]):
                    self.solution = node
                    self.terminals = len(self.open_nodes)+1
                    return self.get_path_tuple(node)
                lnewnodes = []
                self.non_terminals += 1
                for a in self.problem[0][0](node[0]):
                    newstate = self.problem[0][1](node[0], a)
                    if newstate not in self.get_path_tuple(node):
                        depth = 0
                        heuristic = self.problem[0][3](
                            newstate, self.problem[2])
                        cost = self.problem[0][2](
                            node[0], a)
                        if node != self.all_nodes[0]:
                            cost += node[2]
                            depth = node[4]
                        newnode = (newstate, nodeID, cost,
                                   heuristic, depth + 1)
                        lnewnodes.append(len(self.all_nodes))
                        self.all_nodes.append(newnode)
                self.add_to_open(lnewnodes)
                # self.forget_worst_terminals()
            return None
        elif self.optimize == 4:
            while self.open_nodes != []:
                nodeID = self.open_nodes.pop(0)
                node = self.all_nodes[nodeID]
                if self.problem[0][4](node[0], self.problem[2]):
                    self.solution = node
                    self.terminals = len(self.open_nodes)+1
                    return self.get_path_tuple(node)
                lnewnodes = []
                self.non_terminals += 1
                for a in self.problem[0][0](node[0]):
                    newstate = self.problem[0][1](node[0], a)
                    depth = 0
                    heuristic = self.problem[0][3](newstate, self.problem[2])
                    cost = self.problem[0][2](node[0], a)
                    if node[1] != None:
                        cost += node[2]
                        depth = node[4]
                    newnode = (newstate, nodeID, cost, heuristic, depth + 1)
                    insert = all(
                        list(map(lambda n: n[0] != newstate, self.all_nodes)))
                    if not insert:
                        for n in self.all_nodes:
                            if n[0] == newstate and n[2] + n[3] > newnode[2] + newnode[3]:
                                self.all_nodes.remove(n)
                                self.non_terminals -= 1
                                insert = True
                    if insert and newstate not in self.get_path_tuple(node):
                        lnewnodes.append(len(self.all_nodes))
                        self.all_nodes.append(newnode)
                self.add_to_open(lnewnodes)
                # self.forget_worst_terminals()
            return None
        else:
            while self.open_nodes != []:
                nodeID = self.open_nodes.pop(0)
                node = self.all_nodes[nodeID]
                if self.problem.goal_test(node.state):
                    self.solution = node
                    self.cost = node.cost
                    self.terminals = len(self.open_nodes)+1
                    return self.get_path(node)
                lnewnodes = []
                self.non_terminals += 1
                for a in self.problem.domain.actions(node.state):
                    newstate = self.problem.domain.result(node.state, a)
                    if newstate not in self.get_path(node):
                        depth = 0
                        heuristic = self.problem.domain.heuristic(
                            newstate, self.problem.goal)
                        cost = self.problem.domain.cost(
                            node.state, a)
                        if isinstance(node, MyNode):
                            cost += node.cost
                            depth = node.depth
                        newnode = MyNode(newstate, nodeID, cost,
                                         heuristic, depth + 1)
                        lnewnodes.append(len(self.all_nodes))
                        self.all_nodes.append(newnode)
                self.add_to_open(lnewnodes)
                # self.forget_worst_terminals()
            return None
        pass

    def get_path_tuple(self, node):
        if node[1] == None:
            return [node[0]]
        path = self.get_path_tuple(self.all_nodes[node[1]])
        path += [node[0]]
        return(path)
# If needed, auxiliary functions can be added
