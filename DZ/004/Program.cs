﻿// Принимает n, выводит чётные

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++){
    if (i % 2 == 0){
        Console.WriteLine(i);
    }
}


