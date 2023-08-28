# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества. Затем пользователь вводит сами элементы множеств.

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
    if number in my_list_1:
        final_list.append(number)
if len(final_list) == 0:
    print('Нет совпадений')
else:    
    final_list.sort()
    final_list = set(final_list) 
    print(*final_list)