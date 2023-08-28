# N = int(input('Факториал какого числа нужно вычисить? '))
# mult = 1
# count = 1
# while count <= N:
#     mult = mult * count
#     count = count + 1 
# print(mult)

N = int(input('Факториал какого числа нужно вычисить? '))
factorial = N
for i in range (2, N):
    factorial *= i
print(factorial)
