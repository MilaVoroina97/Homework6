//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами
// треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.

double[] triangles = new double[3];
void TriangleSides()
{ double perimetr = 0;
  for (int i = 0; i < triangles.Length - 2; i++)
  {
      Console.Write($"Введите число а: ");
      triangles[0] = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Введите число b: ");
      triangles[1] = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Введите число c: ");
      triangles[2] = Convert.ToInt32(Console.ReadLine());
  }
  CheckSides();
  Area(triangles);
  perimetr = triangles[0] + triangles[1] + triangles[2];
  Console.WriteLine($"Периметр треугольника равен: {perimetr}");
}
void CheckSides()
{
    for (int i = 0; i < 1; i++)
    {
        switch(triangles[i])
        {
           case 1 when triangles[0] + triangles[1] >= triangles[2]:
           {
            Console.WriteLine("Данные числа являются сторонами треугольника.");
            break;
            }
           case 2 when triangles[0] + triangles[2] >= triangles[1]:
            {
            Console.WriteLine("Данные числа являются сторонами треугольника.");
            break;
            }
           case 3 when triangles[1] + triangles[2] >= triangles[0]:
           {
            Console.WriteLine("Данные числа являются сторонами треугольника.");
            break;
           }
           default:
               Console.WriteLine("Эти числа не являются сторонами треугольника.");
               break;
        }
    }
}
TriangleSides();
double[] Area(double[] triangles)
{   double polyperimetr = 0;
    double[] area = new double[4];
    for (int i = 0; i < triangles.Length - 2; i++)
    {
        if ((Math.Pow(triangles[0],2) + Math.Pow(triangles[1],2) == Math.Pow(triangles[2],2)) && (triangles[0] < triangles[2]) && (triangles[2]> triangles[1]))
        {
            Console.WriteLine("Данный треугольник является прямоугольным.");
            area[0]= 0.5 * (triangles[0]+triangles[1]);
            Console.WriteLine($"Площадь прямоугольного треугольника равна: {area[0]}");
            area[1] = triangles[0] / triangles[1];
            Console.WriteLine("tan(a): " + Math.Round(area[1],2));
            area[2] = triangles[0] / triangles[2];
            Console.WriteLine($"sin(a):{0:#.##} {area[2]}");
            area[3] = triangles[1] / triangles[2];
            Console.WriteLine($"cos(a): {0:#.##}{area[3]}");
            break;
        }
        if ((Math.Pow(triangles[0],2) + Math.Pow(triangles[2],2) == Math.Pow(triangles[1],2)) && (triangles[0] < triangles[1]) && (triangles[1]> triangles[2]))
        {
            Console.WriteLine("Данный треугольник является прямоугольным.");
            area[0] = 0.5 * (triangles[0]+triangles[2]);
            Console.WriteLine($"Площадь прямоугольного треугольника равна: {area[0]}");
            area[1] = triangles[0] / triangles[2];
            Console.WriteLine($"tan(a): {0:#.##}{area[1]}");
            area[2] = triangles[0] / triangles[1];
            Console.WriteLine($"sin(a):{0:#.##} {area[2]}");
            area[3] = triangles[2] / triangles[1];
            Console.WriteLine($"cos(a): {0:#.##}{area[3]}");

            break;
        }
        if((Math.Pow(triangles[1],2) + Math.Pow(triangles[2],2) == Math.Pow(triangles[0],2)) && (triangles[1] < triangles[0]) &&  (triangles[0]> triangles[2]))
        {
            Console.WriteLine("Данный треугольник является прямоугольным.");
            area[0] = 0.5 * (triangles[1]+triangles[2]);
            Console.WriteLine($"Площадь прямоугольного треугольника равна: {area[0]}");
            area[1] = triangles[1] /triangles[2];
            Console.WriteLine($"tan(a): {0:#.##} {area[1]}");
            area[1] = triangles[1] /triangles[0];
            Console.WriteLine($"sin(a): {0:#.##}{area[2]}");
            area[3] = triangles[2] /triangles[0];
            Console.WriteLine($"cos(a): {0:#.##}{area[3]}");
            break;
        }
        if (triangles[0] == triangles[1] && triangles[0] != triangles[2])
        {
            Console.WriteLine("Данный треугольник является равнобедернным");
            area[0] = (triangles[2] / 4) * Math.Sqrt(4* Math.Pow(triangles[0],2) - Math.Pow(triangles[2],2));
            Console.WriteLine($"Площадь равнобедренного треугольника равна: {area[0]}");
            area[1] = triangles[2] / (2* triangles[0]);
            Console.WriteLine($"cos(a): {area[1]}");
            area[2] = 180 - area[1] *2;
            Console.WriteLine($"угол(b): {area[2]}");
            area[3] = triangles[2] / (2* triangles[0]);

            break;
        }
        if (triangles[0] == triangles[2] && triangles[0] != triangles[1])
        {
            Console.WriteLine("Данный треугольник является равнобедернным");
            area[0] = (triangles[1] / 4) * Math.Sqrt(4* Math.Pow(triangles[0],2) - Math.Pow(triangles[1],2)) ;
            Console.WriteLine($"Площадь равнобедренного треугольника равна: {area[0]}");
            area[1] = triangles[1] / (triangles[0] *2);
            Console.WriteLine($"cos(a): {area[1]}");
            area[2] = 180 - area[1] *2;
            Console.WriteLine($"угол(b): {area[2]}");
            area[3] = triangles[1] / (triangles[0] *2);
            break;
        }
        if (triangles[1] == triangles[2] && triangles[1] != triangles[0])
        {
            Console.WriteLine("Данный треугольник является равнобедернным");
            area[0] = (triangles[0] / 4) * Math.Sqrt(4* Math.Pow(triangles[1],2) - Math.Pow(triangles[0],2)); 
            Console.WriteLine($"Площадь равнобедренного треугольника равна: {area[0]}");
            area[1] = triangles[0] / (triangles[1] *2);
            Console.WriteLine($"cos(a): {area[1]}");
            area[2] = 180 - area[1] *2;
            Console.WriteLine($"угол(b): {area[2]}");
            area[3] = triangles[0] / (triangles[1] *2);

            break;
        }
        if(triangles[0] == triangles[1] && triangles[0] == triangles[2] && triangles[1] == triangles[2])
        {
            Console.WriteLine("Данный треугольник является равностронним.");
            area[0] = 1.73/4 * Math.Pow(triangles[0],2);
            Console.WriteLine($"Площадь равностороннего треугольника равна: {area[0]}");
            area[1] = 60;
            area[2] = 60;
            area[3] = 60;
            Console.WriteLine("Все углы в равностороннем треугольнике равны 60 градусов.");
            break;
        }
        else
        {
            polyperimetr = (triangles[0]+triangles[1]+triangles[2]) / 2 ;
            area[0] = Math.Sqrt(polyperimetr * (polyperimetr - triangles[0])*(polyperimetr - triangles[1])* (polyperimetr - triangles[2]));
            Console.WriteLine($"Площадь треугольника равна: {area[0]}");
            area[1] = (Math.Pow(triangles[0],2) + Math.Pow(triangles[2],2) - Math.Pow(triangles[1],2))/(2*triangles[0]* triangles[2]);
            Console.WriteLine($"cos(a): {area[1]}");
            area[2] = (Math.Pow(triangles[0],2) + Math.Pow(triangles[1],2) - Math.Pow(triangles[2],2))/(2*triangles[0]* triangles[1]);
            Console.WriteLine($"cos(b): {area[2]}");
            area[3] = (Math.Pow(triangles[1],2) + Math.Pow(triangles[2],2) - Math.Pow(triangles[1],2))/(2*triangles[2]* triangles[1]);
            Console.WriteLine($"cos(y): {area[3]}");
        }
    }
    return area;
}

