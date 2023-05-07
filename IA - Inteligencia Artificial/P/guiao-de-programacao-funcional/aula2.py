import math
from functools import reduce

# Exercicio 4.1
impar = (lambda x: x % 2 == 1)

# Exercicio 4.2
positivo = (lambda x: x > 0)

# Exercicio 4.3
comparar_modulo = (lambda x, y: abs(x) < abs(y))

# Exercicio 4.4
cart2pol = (lambda x, y: (math.sqrt(x**2+y**2), math.atan(y/x) + (math.pi if x < 0 else 0)))

# Exercicio 4.5
ex5 = (lambda f, g, h: (lambda x, y, z: h(f(x, y), g(y, z))))
menor_que = (lambda x, y: x if x < y else y)
f = ex5(menor_que, menor_que, menor_que)

# Exercicio 4.6
def quantificador_universal(lista, f):
    for x in lista:
        if not f(x):
            return False
    return True

# Exercicio 4.9
def ordem(lista, f):
    return reduce(lambda m, x: m if f(m, x) else x, lista)

# Exercicio 4.10
def filtrar_ordem(lista, f):
    return ordem(lista, f), [l for l in lista if l != ordem(lista, f)]

# Exercicio 5.2
def ordenar_seleccao(lista, ordem):
    pass


