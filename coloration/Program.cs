// закраскаЮ используя двумерный массив

void PritnImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 0)
            {
                Console.Write($" ");
            }
            else 
            {
                Console.Write($"+");
            }
        }
        Console.WriteLine();
    }
}
// данным методом мы обводим рисунок, изначально данный в видо матрицы чисел 
// (рисунок представлен единицами, пустое поле - нулями)

void FillImage(int row, int col)
{
    if(res[row, col] == 0)
    {
        res[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

// проверить написанный код в терминале я, к сожалению, не могу, поскольку изначально данного рисунка 
// в виде матрицы чисел у меня (в отличие от лектора) нету



