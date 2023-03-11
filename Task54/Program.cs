// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int[,] CreateMatrix(int rows, int columns, int min, int max){
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            matrix[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++){
        for (int columns = 0; columns < matrix.GetLength(1); columns++){
            Console.Write($"{matrix[rows, columns]} ");
            }
        Console.WriteLine();
    }
}

void SortRowsInMatrix (int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++){
        for (int columns = 0; columns < matrix.GetLength(1); columns++){
            int maxPosition = columns;

            for(int j = columns + 1; j < matrix.GetLength(1); j++){
                if (matrix[rows, j] > matrix[rows, maxPosition]) maxPosition = j;
            }

            int temp = matrix[rows, columns];
            matrix[rows, columns] = matrix[rows, maxPosition];
            matrix[rows, maxPosition] = temp;
        }
    }
}

int[,] matrix = CreateMatrix(4,4,10,99);
PrintMatrix(matrix);
Console.WriteLine();
SortRowsInMatrix(matrix);
PrintMatrix(matrix);