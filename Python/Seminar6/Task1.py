# Задача №39. Решение в группах
# Даны два массива чисел. Требуется вывести те элементы
# первого массива (в том порядке, в каком они идут в первом
# массиве), которых нет во втором массиве. Пользователь вводит
# число N - количество элементов в первом массиве, затем N
# чисел - элементы массива. Затем число M - количество
# элементов во втором массиве. Затем элементы второго массива
# Ввод:                   Вывод:
# 7                       3 3 2 12
# 3 1 3 4 2 4 12
# 6
# 4 15 43 1 15 1          (каждое число вводится с новой строки)

my_list_1 = []
my_list_2 = []
final_list = []
quantity_number_my_list_1 = int(input('Сколько чисел будет в первом наборе? '))
for i in range (quantity_number_my_list_1):
    number = int(input('Введите число: '))
    my_list_1.append(number)
quantity_number_my_list_2 = int(input('Сколько чисел будет во втором наборе? '))
for i in range (quantity_number_my_list_2):
    number = int(input('Введите число: '))
    my_list_2.append(number)
for i in range (len(my_list_1)):
    if my_list_1[i] not in my_list_2:
        final_list.append(my_list_1[i])     
print(*final_list)        