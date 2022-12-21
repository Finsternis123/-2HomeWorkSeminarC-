//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
Console.Clear();
Console.WriteLine("Enter a number for the week ");
int num = int.Parse(Console.ReadLine()!);

    if (num < 1)
{
    Console.WriteLine($"Error");
}
else
    if (num > 7)
{
    Console.WriteLine($"Error");
}

if (num == 1)
    Console.WriteLine ($"It's not a holiday (Monday) ");
if (num == 2) 
    Console.WriteLine ($"It's not a holiday (Tuesday) ");
if (num == 3) 
    Console.WriteLine ($"It's not a holiday (Wednesday) ");
if (num == 4) 
    Console.WriteLine ($"It's not a holiday (Thursday) ");
if (num == 5) 
    Console.WriteLine ($"It's not a holiday (Friday) ");
if (num == 6) 
    Console.WriteLine ($"It's a holiday (Saturday) ");
if (num == 7) 
    Console.WriteLine ($"It's a holiday (Sunday) ");


