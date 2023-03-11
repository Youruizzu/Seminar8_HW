// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProduceMatrixC (int[,] matrixA, int[,] matrixB){
    // Для умножения матриц нужно, 
    // чтобы кол-во столбцов матрицы A совпадало с кол-вом строк матрицы B
    if (matrixA.GetLength(1) != matrixB.GetLength(0)){
        return CreateMatrix(1,1,-1,-1);
    }
    // Кол-во строк матрицы C = кол-ву строк матрицы A,
    // а кол-во столбцов матрицы C = кол-ву столбцов матрицы B.
    int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];

    for (int rowC = 0; rowC < matrixC.GetLength(0); rowC++){
        for (int columnC = 0; columnC < matrixC.GetLength(1); columnC++){
            for (int i = 0; i < matrixA.GetLength(1); i++){
                matrixC[rowC,columnC] += matrixA[rowC, i] * matrixB[i, columnC];
            }
        }
    }
    return matrixC;
}

int[,] matrixA = CreateMatrix(4,3,1,9);
int[,] matrixB = CreateMatrix(3,4,1,9);
Console.WriteLine("Матрица A:");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("A x B = Матрица C:");
PrintMatrix(ProduceMatrixC(matrixA, matrixB));