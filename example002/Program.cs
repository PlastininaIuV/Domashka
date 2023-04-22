// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число a:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число b:  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b){
    Console.Write("число a является большим");
}
else{
    Console.Write("число b является большим");
}
