// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter the number of the day");
int day = Convert.ToInt32(Console.ReadLine());

if ((day < 1) || (day > 7))
{
    Console.WriteLine("Incorrect number");
}

if ((day == 6) || (day == 7))
{
    Console.WriteLine("Yes!");
}    
else
{
    Console.WriteLine("No.");
}


