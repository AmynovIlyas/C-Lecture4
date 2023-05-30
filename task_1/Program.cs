// 

//string[,] table = new string[2, 5];

// по умолчанию строки в данном массиве инициализируются пустой строкой - String.Empty
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

// table[1,2] = "слово/переменная";

// используем циклы, чтобы распечатать данный массив (в даннос лучае цикл в цикле)
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// теперь сделаем тоже самое, но с числами:

// int[,] matrix = new int[3, 4];
// по умолчанию заполнен нулями
// при инициализации массива надо писать числа в скобочках (в данном случае - 3 и 4), но при составлении 
// циклов (или методов) вместо чисел указываем nameCycle.GetLength(0) - ноль выдаст число строк; nameCycle.GetLength(1)
// - единица выдаст число столбцов 

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// теперь опишем метод, заполняющий данный массив числами

void PritnArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PritnArray(matrix);
Console.WriteLine();
FillArray(matrix);
PritnArray(matrix);
