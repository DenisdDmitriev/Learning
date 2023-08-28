days = int(input('Введите количество дней: '))
current_days = 0
max_days = 0
for i in range (days):
    temperature = int(input('Укажите температуру: '))
    if temperature > 0:
        current_days += 1
    else:
        if current_days > max_days:
            max_days = current_days
        current_days = 0    
print(max_days)

