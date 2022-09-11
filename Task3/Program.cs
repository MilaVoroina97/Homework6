//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами
// треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.

double [,] triangle = new double[3,3];
void TriangleSides()
{
  double polyperimetr = 0;
  for (int i = 0; i < triangle.GetLength(0)-2; i++)
  {
      Console.Write($"Введите число а: ");
      triangle[0,0] = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Введите число b: ");
      triangle[0,1] = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Введите число c: ");
      triangle[0,2] = Convert.ToInt32(Console.ReadLine());
  }
  CheckSides();
  polyperimetr = (triangle[0,0]+triangle[0,1]+triangle[0,2]) / 2 ;
  Console.WriteLine(polyperimetr);
  triangle[1,0] = Math.Sqrt(polyperimetr * (polyperimetr - triangle[0,0])*(polyperimetr - triangle[0,1])* (polyperimetr - triangle[0,2]));
  Console.WriteLine($"Площадь треугольника равна : {triangle[1,0]}");
  triangle[1,1] = triangle[0,0]+triangle[0,1]+triangle[0,2];
  Console.WriteLine($"Периметр треугольника равен : {triangle[1,1]}");
}
void CheckSides()
{
  for (int i = 0; i < triangle.GetLength(0); i++)
  {
      if ((triangle[0,0]+triangle[0,1]<=triangle[0,2]||triangle[0,0]+triangle[0,2]<=triangle[0,1]||triangle[0,1]+triangle[0,2]<=triangle[0,0]))
      {
        Console.WriteLine("Данные числа являются сторонами треугольника.");
        
      }
      else Console.WriteLine("Эти числа не являются сторонами треугольника");
      break;
    }
}
TriangleSides();
double PerimetrandArea(double[,] array)
{
    double area = 0;
    double perimetr = 0;
    for (int i = 0; i < array.GetLength(0) - 2; i++)
    {
        if 
    }
}
