double[,] FillMatrix(int rows, int cols)
{
    double[,] matr = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(),1);
        }
    }
    return matr;
}

void PrintMatrix(double [,] matr)
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

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

