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
// void WriteElArray(int[,] array)
// {
//     arrayRxC[row, column] = arrayElForArray[step + 1];
//     step++;
// }

Console.Clear();
int rowArray = 4;
int columnArray = 4;
int[,] arrayRxC = new int[rowArray, columnArray];

//Закручиваем спираль - заполняем значениями квадратный массив
int step = 0;
int row = 0; int column = 0;
for (column = 0; column < rowArray - 1; column++)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
for (row = 0; row < columnArray-1; row++)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
for (column = rowArray-1; column > 0; column--)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
for (row = columnArray-1; row > 0; row--)
{
    arrayRxC[row, column] = step + 1;
    step++;
}

//Заполнена первая линия, заполняем вторую
row = 1; column = 1;
for (column = 1; column < rowArray - 2; column++)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
for (row = 1; row < columnArray-2; row++)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
for (column = rowArray-2; column > 1; column--)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
for (row = columnArray-2; row > 1; row--)
{
    arrayRxC[row, column] = step + 1;
    step++;
}
Console.WriteLine($"Квадратный массив {rowArray}x{columnArray}, заполненный спирально (по ч.с.)");
PrintArray2Dim(arrayRxC);
