// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число a:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число b:  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число c:  ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c){
    Console. WriteLine("a наибольшее число");
}
else if (b > a && b > c){
    Console. WriteLine("b наибольшее число");
}
else{
    Console. WriteLine("c наибольшее число");
}
