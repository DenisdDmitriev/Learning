# Напишите функцию same_by(characteristic, objects), которая
# проверяет, все ли объекты имеют одинаковое значение
# некоторой характеристики, и возвращают True, если это так.
# Если значение характеристики для разных объектов
# отличается - то False. Для пустого набора объектов, функция
# должна возвращать True. Аргумент characteristic - это
# функция, которая принимает объект и вычисляет его
# характеристику.


def same_by(func, lst):
    new_list = list(filter(func, lst))
    if new_list == lst:
        return True
    else:
        return False
    

values = [0, 2, 10, 6]
if same_by(lambda x: x % 2 == 0, values):
    print('same')
else:
    print('different')