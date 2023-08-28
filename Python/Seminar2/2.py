number = int(input('Введите число: '))
first_num_fibonacchi = 0
second_num_fibonacchi = 1
count = 1
while number != first_num_fibonacchi:
    second_num_fibonacchi = first_num_fibonacchi + second_num_fibonacchi
    first_num_fibonacchi = second_num_fibonacchi - first_num_fibonacchi
    count = count + 1
print(count)    