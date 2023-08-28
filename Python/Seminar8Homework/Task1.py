def read_file():
    with open('tel_dir.txt', 'r', encoding = 'utf - 8') as file:
        for line in file:
            print(*line.split(';'), end = '')
    print()     


def search_name(name):
    find_data = input('Введите ФИО или номер телефона: ')
    print()
    with open(name, encoding = 'utf-8') as file:
        find_list = [line for line in file if find_data in line]
    return find_list


def search_contact(find_list):
    if len(find_list) == 0:
        print("Контакты не найдены")
        print()
    else:
        print("По Вашему запросу найдены: ")
        for i in range(len(find_list)):
            print(f"{i + 1}. {find_list[i]}".replace(';', ' '), end = '')
        print()


def replace_info(filename, replace_find_list, selection_replace = 0):
    with open(filename, 'r', encoding = 'utf - 8') as file:
        old_data = file.read()
        new_name = input('Введите новое ФИО: ')
        new_tel = input('Введите новый номер телефона: ')
        new_data = old_data.replace(replace_find_list[selection_replace],  new_name + ' | ' + new_tel + '\n')
        
    with open ('tel_dir.txt', 'w', encoding = 'UTF-8') as file:
        file.write(new_data)    


def replace_contact(filename):
    replace_find_list = search_name(filename)
    search_contact(replace_find_list)
    if len(replace_find_list) == 0:
        return 0
    elif len(replace_find_list) > 1:
        selection_change = int(input("Введите порядковый номер контакта, который нужно изменить: "))
        replace_info(filename, replace_find_list, selection_change - 1)
        print()
    else:
        replace_info(filename, replace_find_list)
        print()        


def add_contact(filename):
    add_name = input('Введите ФИО: ')    
    add_tel = input('Введите номер телефона: ') 
    find_data = f"{add_name} {add_tel}\n"
    with open(filename, 'r+', encoding = 'UTF-8') as file:
        find_list = [line for line in file if find_data in line]
        file.write(f"{add_name} {add_tel}\n")
        print(f"Добавлен контакт {add_name} {add_tel}\n") 

def delete_contact(filename):
    with open(filename, 'r', encoding = 'UTF-8') as file:
        list_tel = [line for line in file]
        if len(list_tel) == 0:
            print("Список контактов пуст!")
            print()
            return 0
        else:
            for i in range(len(list_tel)):
                print(f"{i + 1}. {list_tel[i]}", end = '')
            print('')

        delete_data = int(input('Введите номер строки для удаления: ')) - 1
        if len(list_tel) > delete_data >= 0:
            delet_elem = list_tel.pop(delete_data)
            print(f"Удален контакт: {delet_elem}")
            with open(filename, 'w', encoding = 'UTF-8') as data:
                for item in list_tel:
                    data.write("%s" % item)        
        else:
            print("Нет строки с таким номером")
            print()
            return 0

def menu():
    file_tel = "tel_dir.txt"
    with open(file_tel, 'a', encoding = 'UTF-8') as file:
        file.write('')
    
    while True:
        print('Выберите действие: ')
        print('1 - вывести общую информацию')
        print('2 - поиск абонента')
        print('3 - изменение контакта')
        print('4 - добавление контакта')
        print('5 - удаление контакта')
        print('0 - выход из программы')
        n = int(input('Ваш выбор: '))
        print()
        if n == 0:
            print('До свидания!')
            break
        elif n == 1:
            print('Данные справочника:')
            print()
            read_file()
            print()
        elif n == 2:
            find_list = search_name('tel_dir.txt')
            search_contact(find_list)
        elif n == 3:
            replace_contact('tel_dir.txt')
        elif n == 4:
            add_contact('tel_dir.txt')
        elif n == 5:
            delete_contact('tel_dir.txt')        

                      
if __name__ == '__main__':
    menu()
