watermelones = int(input('Введите количество арбузов: '))
max_watermelone_weight = 0
min_watermelone_weight = 10**100
for i in range(watermelones):
    watermelone_weight = int(input('Укажите вес арбуза: '))
    if watermelone_weight > max_watermelone_weight:
        max_watermelone_weight = watermelone_weight
    if watermelone_weight < min_watermelone_weight:
        min_watermelone_weight = watermelone_weight   
print(min_watermelone_weight, max_watermelone_weight)