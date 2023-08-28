import pandas

def read_file():
    with open('california_housing_train.csv', 'r', encoding = 'utf - 8') as file:
        for line in file:
            print(*line)