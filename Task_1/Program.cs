//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter 3-digit number");
int num = Convert.ToInt32(Console.ReadLine());

int digit1 = num / 10;
int digit2 = digit1%10;

Console.WriteLine($"The second digit is {digit2}");