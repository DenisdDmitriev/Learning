# Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя –
# школьница. Петя помогает Кате по математике. Он задумывает два
# натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для
# этого Петя делает две подсказки. Он называет сумму этих чисел S и их
# произведение P. Помогите Кате отгадать задуманные Петей числа.


X = int(input('Введите первое число: '))
Y = int(input('Введите второе число: '))

for i in range(X):
    for j in range(Y):
        if X == i + j and Y == i * j:
            print (i, j)


