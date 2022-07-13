
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine("Введите трехзначное число.");
string number = Console.ReadLine();
if (number.Length > 2)
{
    Console.WriteLine("{0}->{1}", number, number[2]);
}
else
{
    Console.WriteLine("{0}->{1}", number, "Это не трёхзначное число");
}