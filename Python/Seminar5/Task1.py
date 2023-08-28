score = input('Укажите оценки через пробел: ') 
my_list = [int(i) for i in score.split()]
for i in range (len(my_list)):
    if my_list[i] > 3:
        my_list[i] = 1
print(my_list)