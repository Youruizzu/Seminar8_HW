// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] Create3DMatrix(int x, int y, int z, int min, int max){
    int[,,] matrix = new int[x, y, z];
    for(int i = 0; i < x; i++){
        for(int j = 0; j < y; j++){
            for(int k = 0; k < z; k++){
                matrix[i,j,k] = new Random().Next(min, max+1);
            }
        }
    }
    return matrix;
}

void Print3DMatrixWithIndexes(int[,,] matrix){
    for (int z = 0; z < matrix.GetLength(2); z++){
        for (int x = 0; x < matrix.GetLength(0); x++){
            for (int y = 0; y < matrix.GetLength(1); y++){
                Console.Write($"{matrix[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = Create3DMatrix(2,2,2,10,99);
Print3DMatrixWithIndexes(matrix);