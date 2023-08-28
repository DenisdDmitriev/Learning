# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N]. Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# *Пример:*
# 5
#     1 2 3 4 5
#     3
#     -> 1

my_list = []
count = 0
number_elem_in_massive = int(input('Сколько чисел будет в массиве? '))
for i in range (number_elem_in_massive):
    number = int(input('Введите число: '))
    my_list.append(number)
search_number_in_massive = int(input('Какое число нужно найти? '))
# for i in range (len(my_list)):
#     if search_number_in_massive == my_list[i]:
#         count += 1
count = my_list.count(search_number_in_massive)
print(f'Число {search_number_in_massive} встречается {count} раз')    
