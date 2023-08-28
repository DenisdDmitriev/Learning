# Задача 14: Требуется вывести все целые степени двойки (т.е. числа
# вида 2k), не превосходящие числа N.

number = int(input('Введите число: '))
base = 2
degree = 0
while base**degree < number:
    print (base**degree)
    degree += 1