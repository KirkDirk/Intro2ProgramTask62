// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintArray2Dim(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4:N0}", array[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] FillSpiralArray(int[,] arr, int step, int numR, int numC, int rowArr, int colArr)
{
    int i = numR; int j = numR;
    for (j = numC; j < rowArr - 1; j++)
    {
        arr[i, j] = step;
        step++;
    }
    for (i = numR; i < colArr - 1; i++)
    {
        arr[i, j] = step;
        step++;
    }
    for (j = rowArr - 1; j > numC; j--)
    {
        arr[i, j] = step;
        step++;
    }
    for (i = colArr - 1; i > numR; i--)
    {
        arr[i, j] = step;
        step++;
    }
    return arr;
}

Console.Clear();
int rowArray = 4;
int columnArray = 4;
int[,] arrayRxC = new int[rowArray, columnArray];

FillSpiralArray(arrayRxC, step: 1, numR: 0, numC: 0, rowArray, columnArray); // наружнее кольцо с элемента 0,0
FillSpiralArray(arrayRxC, step: 1+4*(rowArray-1), numR: 1, numC: 1, rowArray-1, columnArray-1); // внутреннее кольцо с элемента 1,1

Console.WriteLine($"Квадратный массив {rowArray}x{columnArray}, заполненный спирально (по ч.с.)");
PrintArray2Dim(arrayRxC);
