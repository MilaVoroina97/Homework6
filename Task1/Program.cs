//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//5
//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int PositiveNumbers(int[] massiv)
{
    int count = 0;
    for(int i = 0; i < massiv.Length; i++) 
    {
        if(massiv[i] > 0) count = count + 1;
    }
    return count;
}
try
{
    Console.WriteLine("Введите число M для определения количества чисел, которые Вы хотите ввести: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[M];
for(int i = 0; i <  M; i++)
{
    Console.Write("Введите число:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int result = PositiveNumbers(numbers);
Console.WriteLine($"Количество положительных чисел: {result}");
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целые числа.");
}

