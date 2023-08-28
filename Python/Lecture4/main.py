# def calk2(a, b): 
#     return a * b

# def math(op, x, y):
#     print(op(x, y))

# math(lambda a,b: a + b, 5, 45)    

# my_list = [1, 2, 3, 5, 8, 15, 23, 38]
# res = list()

# for elem in my_list:
#     if elem % 2 == 0:
#         res.append((elem, elem ** 2))
# print(res)    

# 


# my_list = [1, 2, 3, 5, 8, 15, 23, 38]
# res = select(int, my_list)
# print(res)
# res = where(lambda x: x % 2 == 0, res)
# print(res)
# res = list(select(lambda x: (x, x ** 2), res))
# print(res)

list_1 = [x for x in range (1, 20)]
print(list_1)
list_1 = list(map(lambda x: x + 10, list_1))
print(list_1)
