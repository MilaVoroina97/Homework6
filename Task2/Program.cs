//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] coordinats = new double[2,2];
void PrintNumbers()
{
  for (int i = 0; i < coordinats.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k{i+1} * x + b{i+1}):\n");
    for (int j = 0; j < coordinats.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coordinats[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
void PrintArray(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
PrintNumbers();
PrintArray(coordinats);
double[] Action(double[,] matrix)
{   
    double[] result = new double[2];
    result[0] = (matrix[1,1] - matrix[0,1])/(matrix[0,0] - matrix[1,0]); //x
    result[1] = matrix[0,0] * result[0] + matrix[0,1];
    Console.WriteLine($"Точка пересечения прямых: ({result[0]}),({result[1]})");
    return result;
}
Action(coordinats);


