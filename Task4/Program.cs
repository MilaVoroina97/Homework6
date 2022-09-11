// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
//Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый 
//гарантированно переместился на другое место (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
//То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine("Введите число m для определения кол-ва строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n для определения кол-ва столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] peremesh = new int[m,n];


void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,100);
        }
    }
}
void PrintArray(int[,] matrix)
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
FillArray(peremesh);
PrintArray(peremesh);
Console.WriteLine();

void Mix()
{
    int temp = 0;
    int new_i = 0;
    int new_j = 0;
    for (int i = 0; i <= m-1; i++)
    {
        for(int j = 0; j <= n-1; j++)
        {
            new_i = new Random().Next(1,m-1);
            new_j = new Random().Next(1,n-1);
            temp = peremesh[i,j];
            peremesh[i,j] = peremesh[new_i,new_j];
            peremesh[new_i,new_j] = temp;
        }


    }
}

Mix();
PrintArray(peremesh);


