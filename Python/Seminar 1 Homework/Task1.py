# Задача 2: Найдите сумму цифр трехзначного числа.
# *Пример:*
# 123 -> 6 (1 + 2 + 3)
# 100 -> 1 (1 + 0 + 0) 

number = int(input('Введите трехзначное число: '))
firstNumber = number // 100
secondNumber = number // 10 % 10
thirdNumber = number % 10
sum = firstNumber + secondNumber + thirdNumber
print(number, '->', sum, '(', firstNumber,' + ', secondNumber, ' + ', thirdNumber, ')')