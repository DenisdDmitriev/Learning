my_list = [-1, 2, 2, 0, -1, 3, 4, 9]
my_list_2 = []
for i in range (len(my_list)):
    if my_list[i] not in my_list_2:
        my_list_2.append(my_list[i])
print(len(my_list_2))
    