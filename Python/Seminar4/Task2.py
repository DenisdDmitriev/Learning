# text = (" She sells sea shells on the sea shore The shells "
# " that she sells are sea shells I'm sure.So if she sells sea "
# " shells on the sea shore I'm sure that the shells are sea "
# " shore shells").upper().split()
# # text = input(str('Введите текст: ')).split()
# text = set(text)   
# print(len(text))

# text = " She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure. So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells "
# words = text.split()
# print(len(words))

text = " She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure. So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells "
words = text.split()
my_dict = {}
for word in words:
    if word in my_dict:
        my_dict[word] += 1
    else:
        my_dict[word] = 1 
values = my_dict.values()
max_value = max(values)           
print(my_dict)
print(max_value)
for key, value in my_dict.items():
    if value == max_value:
        print(key, value)