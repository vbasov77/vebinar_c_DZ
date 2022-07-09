// Программа принимает два числа, выводит большее


int a; 
int b;
Console.WriteLine("Введите два числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if(a > b){
Console.WriteLine("{0} большее число", a);
} else {
    Console.WriteLine("{0} большее число", b);
}
 Console.ReadLine();


