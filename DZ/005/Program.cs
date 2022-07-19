//Напишите программу, которая принимает на вход трёхзначное число и  
//на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число.");
string number = Console.ReadLine();
Console.WriteLine("{0}->{1}", number, number[1]);
