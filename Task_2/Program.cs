//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// 1 СПОСОБ
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("There's no 3-rd digit");
} 
else
{
    Console.WriteLine($"The 3rd digit is {num.ToString()[2]}");
}



//2 СПОСОБ
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("There's no 3rd digit");
}

if ((num >= 100)&&(num < 1000))
{
    num = num % 10;
    Console.WriteLine($"The 3rd digit is {num}");
}

if (num >= 1000)
{
    do
    { 
    num = (num / 10);
    } while (num >= 1000);
    Console.WriteLine($"The third number is {num % 10}");
}