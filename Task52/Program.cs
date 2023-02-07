int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int [,] matr)
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

int SummMatrix(int[,] mart)
{
    int result = 0;
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            if((j == 0))
            {
                result += mart[i,j];
            }
        }
    }
    return result;
}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine(SummMatrix(matrix));
