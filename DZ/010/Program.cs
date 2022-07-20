//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int[] num){
  int i = 0;
  int length = num.Length;
  while (i <  length){
    num[i] = Convert.ToInt32(Math.Pow(i, 3));
    i++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int i = 0;
  while(i < count){
    Console.Write(coll[i] + " ");
    i++;
  }
} 

int[] arry = new int[num + 1];
Cube(arry);
PrintArry(arry);
