// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] CreateSpiralMatrix(int size = 4){
    int[,] matrix = new int[size, size];
    int counter = 1;

    // Количество витков в спирали
    int swirls = 0;
    for (int s = 0; s<size; s++){
        swirls +=2;
    }

    int right = 1;
    int down = 2;
    int left = 3;
    int up = 4;

    for (int i = 1; i <= swirls; i++){
        if (i == right){
            for (int j = right/4; j < size-right/4; j++){
                matrix[right/4, j] = counter;
                counter++;
            }
            right+=4;
        }
        if (i == down){
            for (int j = 1+down/4; j < size-down/4; j++){
                matrix[j, size-1-down/4] = counter;
                counter++;
            }
            down+=4;
        }
        if (i == left){
            for (int j = size-2-left/4; j >= left/4; j--){
                matrix[size-1-left/4, j] = counter;
                counter++;
            }
            left+=4;
        }
        if (i == up){
            for (int j = size-1-up/4; j >= up/4; j--){
                matrix[j, up/4-1] = counter;
                counter++;
            }
            up+=4;
        }
    }

    return matrix;
}

void PrintSpiralMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++){
        for (int columns = 0; columns < matrix.GetLength(1); columns++){
                if (matrix[rows, columns] < 10){
                    Console.Write($"0{matrix[rows, columns]} ");
                }
                else {
                    Console.Write($"{matrix[rows, columns]} ");
                }
            }
        Console.WriteLine();
    }
}

PrintSpiralMatrix(CreateSpiralMatrix(8));