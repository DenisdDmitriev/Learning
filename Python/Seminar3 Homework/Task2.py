# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# *Пример:*
# 5
#     1 2 3 4 5
#     6
#     -> 5

my_list = []
difference_of_numbers = None
min_difference_of_numbers = 10**10
number_elem_in_massive = int(input('Сколько чисел будет в массиве? '))
for i in range (number_elem_in_massive):
    number = int(input('Введите число: '))
    my_list.append(number)
search_number_in_massive = int(input('Задайте число, к которому нужно найти самый близкий элемент: '))
for i in range (len(my_list)):
    difference_of_numbers = abs(search_number_in_massive - my_list[i])
    if difference_of_numbers < min_difference_of_numbers:
        min_difference_of_numbers = difference_of_numbers
        nearest_number = my_list[i]
print('К числу', search_number_in_massive, 'ближе всего число', nearest_number)