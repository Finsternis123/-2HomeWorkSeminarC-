//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
Console.Clear();
Console.WriteLine("Enter number ");
int num = int.Parse(Console.ReadLine()!);

int a = 100000;
int b = 10000;
int c = 1000;
int d = 100;
int e = 10;
int result = 0;

    if (num < d)
{
     Console.WriteLine($"Error");
}
else
    if (num <= c)
{
    result = num;
    Console.WriteLine($"Second number {(result % e)}");
}
else
    if (num <= b)
{
    result = num / e;
    Console.WriteLine($"Second number {(result % e)}");
}
else
    if (num <= a)
{
    result = num / d;
    Console.WriteLine($"Second number {(result % e)}");
}





