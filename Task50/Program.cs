//Задача 50. Напишите программу, которая на вход принимает число, возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
int[,] Fillmatr(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void Printmatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write((matr[i, j] + "\t"));
        }
        System.Console.WriteLine();
    }

}

void CheckMatr(int[,] matr, int num)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (num == matr[i, j])
            {
                System.Console.WriteLine("yes");
            }
            else if (num != matr[i, j])
            {
                System.Console.WriteLine("No");
            }
        }
    }
}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Fillmatr(m, n);
Printmatr(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Введите g: ");
int g = Convert.ToInt32(Console.ReadLine());
CheckMatr(matrix, g);

