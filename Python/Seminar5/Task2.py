number = int(input('Введите число для проверки: '))

def ChekTheNumber (n):
    for i in range (2, n):
        if n % i == 0:
           return False
    return True    

print(ChekTheNumber(number))
