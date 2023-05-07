from functools import reduce
import math

# Exercicio 1.1
def comprimento(lista):
    if lista == []:
      return 0
    return 1+comprimento(lista[1:])

# Exercicio 1.2
def soma(lista):
    if lista == []:
        return 0
    return lista[0]+soma(lista[1:])

# Exercicio 1.3
def existe(lista, elem):
    if lista == []:
        return False
    if lista[0] == elem:
        return True
    return existe(lista[1:], elem)

# Exercicio 1.4
def concat(l1, l2):
    if l1 == []:
        return l2
    if l2 == []:
        return l1
    l1.append(l2[0])
    return concat(l1, l2[1:])

# Exercicio 1.5
def inverte(lista):
    if lista == []:
        return []
    inv = inverte(lista[1:])
    inv[len(lista):] = [lista[0]]
    return inv

# Exercicio 1.6
def capicua(lista):
    if len(lista) < 2:
        return True
    elif lista[0] != lista[-1]:
        return False
    else:
        return capicua(lista[1:-1])

# Exercicio 1.7
def concat_listas(lista):
    if lista == []:
        return []
    l1 = lista[0]
    l2 = concat_listas(lista[1:])
    return concat(l1, l2)

# Exercicio 1.8
def substitui(lista, original, novo):
    if lista == []:
        return []
    novaLista = substitui(lista[1:], original, novo)
    if lista[0] == original:
        return [novo] + novaLista
    return [lista[0]] + novaLista

# Exercicio 1.9
def junta_ordenado(lista1, lista2):
    if lista1 == []:
        return lista2
    if lista2 == []:
        return lista1
    if lista1[0] <= lista2[0]:
        return [lista1[0]]+junta_ordenado(lista1[1:], lista2)
    return [lista2[0]]+junta_ordenado(lista2[1:], lista1)

# Exercicio 1.10
def sub_conjuntos(lista):
    if lista == []:
        return [[]]
    t = sub_conjuntos(lista[1:])
    return t+[[lista[0]]+e for e in t]

# Exercicio 2.1
def separar(lista):
    if lista == []:
        return ([], [])  # Devolve um tuplo de 2 listas
    a, b = lista[0]
    lista_a, lista_b = separar(lista[1:])
    return ([a]+lista_a), ([b]+lista_b)

# Exercicio 2.2
def remove_e_conta(lista, elem):
    if lista == []:
        return [], 0
    else:
        list_c, x_c = remove_e_conta(lista[1:], elem)
        if lista[0] == elem:
            return list_c, x_c+1
        else:
            return [lista[0]]+list_c, x_c

# Exercicio 3.1
def cabeca(lista):
    if lista == []:
        return None
    else:
        return lista[0]

# Exercicio 3.2
def cauda(lista):
    if len(lista) > 1:
        lista[0] = cauda(lista[1:])
    return lista[0]

# Exercicio 3.3
def juntar(l1, l2):
    if l1 == [] and l2 == []:
        return []
    elif len(l1) != len(l2):  # Pq tem q ser tuplos
        return None
    (a, b) = l1[0], l2[0]
    return [(a, b)] + juntar(l1[1:], l2[1:])

# Exercicio 3.4
def menor(lista):
    if len(lista) == 1:
        return lista[0]
    v = menor(lista[1:])
    return lista[0] if lista[0] < v else v

# Exercicio 3.6
def max_min(lista):
    if lista == []:
        return None
    elif len(lista)==1:
        return(lista[0], lista[0])
    else:
        maxim, minim = max_min(lista[1:])
        if lista[0]>maxim:
            maxim = lista[0]
        if lista[0]<minim:
            minim = lista[0]
        return (maxim, minim)
