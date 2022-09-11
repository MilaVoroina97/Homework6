//пользователь не задает сколько чисел он введет (то есть число M), 
//а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.

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
Console.WriteLine("Введите целые числа через точку с запятой или пробел: ");
string x = Console.ReadLine();
int[] numbers = x.Split(';',' ').Select(int.Parse).ToArray();
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
Console.ReadKey();
Console.WriteLine();
int result = PositiveNumbers(numbers);
Console.WriteLine($"Количество положительных чисел: {result}");
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целые числа.");
}
    