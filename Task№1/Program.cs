// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
Console.Clear();
Console.WriteLine("Enter number ");
int num = int.Parse(Console.ReadLine()!);

int a = 1000;
int b = 100;
int c = 10;
int result = 0;

if (num < b)
{
     Console.WriteLine($"Error");
}
else
{
    if (num < a)
{
    result = num / c;
    Console.WriteLine($"Second number {(result % c)}");
}
else
{
    Console.WriteLine($"Error");
}
}



   
