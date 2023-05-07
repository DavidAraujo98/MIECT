#encoding: utf8

# YOUR NAME:    David José Araújo Ferreira
# YOUR NUMBER:  93444

# COLLEAGUES WITH WHOM YOU DISCUSSED THIS ASSIGNMENT:
# - ...
# - ...

from semantic_network import *
from bayes_net import *
from constraintsearch import *


class MySN(SemanticNetwork):
    def __init__(self):
        SemanticNetwork.__init__(self)
        self.objects = {}
        self.types = {}

    def is_object(self, user, obj):
        query_result = self.query_local(user, e2=obj)
        
        res = self.query_local(user, e1=obj) or (not isinstance(
            query_result[0].relation, Member) if len(query_result) > 0 else False)

        return bool(res)

    def is_type(self, user, type):
        query_result = self.query_local(user, e2=type)
        return bool(query_result)

    def add_object(self, obj, type):
        self.objects[obj] = type
        if type not in self.types:
            self.types[type] = set()
        self.types[type].add(obj)

    def remove_object(self, obj):
        type = self.objects.pop(obj, None)
        if type:
            self.types[type].remove(obj)

    def infer_type(self, user, obj):
        val = "__unknown__"

        query_result = self.query_local(user=user, e1=obj)
        if len(query_result) == 0:
            query_result = self.query_local(user=user, e2=obj)
            if len(query_result) == 0:
                return None

        prio = False
        for declaration in query_result:
            if isinstance(declaration.relation, Member):
                prio = True
                val = declaration.relation.entity2
            if isinstance(declaration.relation, Subtype):
                supertype = declaration.relation.entity2
                query_result = self.query_local(
                    user=user, e1=supertype, rel="subtype", e2=obj)
                if len(query_result) > 0:
                    val = supertype
                else:
                    val = obj
            if isinstance(declaration.relation, Association) and not prio:
                supertype = declaration.relation.entity2
                if isinstance(supertype, int) or isinstance(supertype, float):
                    val = "number"

        return val

    def infer_signature(self, user, assoc):
        query_result = self.query_local(user, rel=assoc)
        if not query_result:
            return None
        first_decl = query_result[0]
        return (self.infer_type(user, first_decl.relation.entity1), self.infer_type(user, first_decl.relation.entity2))


class MyBN(BayesNet):

    def __init__(self):
        BayesNet.__init__(self)

    def markov_blanket(self, var):
        blanket = set()

        for parent, child, _ in self.dependencies[var]:
            blanket.update(parent)
            blanket.update(child)

        for key in self.dependencies.keys():
            if key != var:
                for _, child, _ in self.dependencies[key]:
                    if var in child:
                        blanket.add(key)
                        break
                for parent, _, _ in self.dependencies[key]:
                    if var in parent:
                        blanket.update(parent)
                        break

        blanket.discard(var)
        return blanket


class MyCS(ConstraintSearch):

    def __init__(self, domains, constraints):
        ConstraintSearch.__init__(self, domains, constraints)
        pass

    def propagate(self, domains, var):
        eg = [(a, b) for (a, b) in self.constraints if b == var]
        while True:
            up = False
            for i, j in eg:
                vals = len(domains[i])
                c = self.constraints[i, j]

                domains[i] = [x for x in domains[i] if any(
                    c(i, x, j, y) for y in domains[j])]

                if len(domains[i]) < vals:
                    eg += [(x, z) for (x, z) in self.constraints if z == i]
                    up = True

            if not up:
                break

        return domains


    def higherorder2binary(self, ho_c_vars, unary_c):
        aux_var = f"aux_{ho_c_vars[0]}"
        self.domains[aux_var] = [i for i in range(
            max(self.domains[ho_c_vars[0]]))]

        def binary_c(v1, val1, v2, val2):
            values = tuple([val1 if v == aux_var else val2 if v ==
                           var else self.domains[v][0] for v in ho_c_vars])
            if v1 == aux_var:
                return unary_c(values)
            elif v2 == aux_var:
                return unary_c(values)
            else:
                return True

        for var in ho_c_vars:
            self.constraints[var, aux_var] = binary_c
            self.constraints[aux_var, var] = binary_c
