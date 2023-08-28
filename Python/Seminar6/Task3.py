# Задача №43. Решение в группах
# Дан список чисел. Посчитайте, сколько в нем пар
# элементов, равных друг другу. Считается, что любые
# два элемента, равные друг другу образуют одну пару,
# которую необходимо посчитать. Вводится список
# чисел. Все числа списка находятся на разных
# строках.
# Ввод:                   Вывод:
# 1 2 3 2 3               2

my_list_1 = []
quantity_number_my_list_1 = int(input('Сколько чисел будет в массиве? '))
for i in range (quantity_number_my_list_1):
    number = int(input('Введите число: '))
    my_list_1.append(number)
pair = 0
for i in range (len(my_list_1) - 1):
    for j in range (i + 1, len(my_list_1)):
        if my_list_1[j] == my_list_1[i]:
            pair += 1
print(pair)    

# a = [1, 5, 3, 1, 5]
# count = 0
# for i in range(len(a) - 1):
#     for j in range(i + 1, len(a)):
#         if a[i] == a[j]:
#             count += 1
# print(count)            