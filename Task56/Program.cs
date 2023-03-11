// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindSmallestRowSummInMatrix (int[,] matrix){
    int smallestRow = 0;
    int smallestRowSumm = 2147483647; // Максимальное значение, которое может хранить integer
    for (int rows = 0; rows < matrix.GetLength(0); rows++){
        int rowSumm = 0;
        for (int columns = 0; columns < matrix.GetLength(1); columns++){
            rowSumm += matrix[rows, columns];
        }
        if(rowSumm<smallestRowSumm){
            smallestRow = rows;
            smallestRowSumm = rowSumm;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {smallestRow+1} строка");
}

int[,] matrix = CreateMatrix(4,4,10,99);
PrintMatrix(matrix);
Console.WriteLine();
FindSmallestRowSummInMatrix(matrix);