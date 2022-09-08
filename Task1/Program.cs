//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//5
//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
//а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.

Console.WriteLine("Введите число M для определения количества чисел, которые Вы хотите ввести: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[M];
for(int i = 0; i <  M; i++)
{
    Console.Write("Введите координаты первой точки ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int PositiveNumbers(int[] massiv)
{
    int count = 0;
    for(int i = 0; i < massiv.Length; i++) 
    {
        if(massiv[i] > 0) count = count + 1;
    }
    return count;
}
Console.WriteLine();
int result = PositiveNumbers(numbers);
Console.WriteLine(result);

