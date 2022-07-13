// программа принимает 3 числа, выдаёт максимальное

int a, b, c;
Console.WriteLine("Введите 3 числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Большее число: ");
Console.WriteLine(max);
