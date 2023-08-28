# Задача 6: Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером. Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех. Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать программу, которая проверяет счастливость билета.
# *Пример:*
# 385916 -> yes
# 123456 -> no

numberTicket = int(input('Введите шестизначный номер билета '))
sumFirstThreeNumber = numberTicket // 1000 % 10 + numberTicket // 10000 % 10 + numberTicket // 100000
sumSecondThreeNumber = numberTicket % 10 + numberTicket // 10 % 10 + numberTicket //100 % 10

if (sumFirstThreeNumber == sumSecondThreeNumber):
    print(numberTicket, '-> Yes')
else:
    print(numberTicket, '-> No')     
