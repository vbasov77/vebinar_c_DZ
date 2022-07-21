Random random = new Random();
int points = 10;
String[] value = new String[3];
value[0] = "Камень";
value[1] = "Ножницы";
value[2] = "Бумага";

Console.WriteLine("1. Камень");
Console.WriteLine("2. Ножницы");
Console.WriteLine("3. Бумага");
while (points > 0)
{
    int random_num = random.Next(value.Length);
    string random_str = value[random_num];
    Console.Write("Введите цифру — ");
    int Decision = int.Parse(Console.ReadLine());
    switch (Decision)
    {
        case 1:
            Console.WriteLine("Камень - {0}", random_str);
            if (random_str != value[0] && random_str != value[2])
            {
                points++;
                Console.WriteLine("Выигрыш!");
                Console.WriteLine(points);
            }
            else if (random_str != value[0] && random_str != value[1])
            {
                points--;
                Console.WriteLine("Проигрыш!");
                Console.WriteLine(points);
            }
            else
            {
                Console.WriteLine("Ничья!");
                Console.WriteLine(points);
            }
            break;
        case 2:
            Console.WriteLine("Ножницы - {0}", random_str);

            if (random_str != value[1] && random_str != value[0])
            {
                points++;
                Console.WriteLine("Выигрыш!");
                Console.WriteLine(points);
            }
            else if (random_str != value[1] && random_str != value[2])
            {
                points--;
                Console.WriteLine("Проигрыш!");
                Console.WriteLine(points);
            }
            else
            {
                Console.WriteLine("Ничья!");
                Console.WriteLine(points);
            }
            break;
        case 3:
            Console.WriteLine("Бумага - {0}", random_str);
            if (random_str != value[2] && random_str != value[1])
            {
                points++;
                Console.WriteLine("Выигрыш!");
                Console.WriteLine(points);
            }
            else if (random_str != value[2] && random_str != value[0])
            {
                points--;
                Console.WriteLine("Проигрыш!");
                Console.WriteLine(points);
            }
            else
            {
                Console.WriteLine("Ничья!");
                Console.WriteLine(points);
            }
            break;
    }

}