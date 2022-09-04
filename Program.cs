// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        matr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{matr[i]}, ");
    }
}

int[] matrix = new int[8];
FillArray(matrix);
PrintArray(matrix);