// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("вводим число:  ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num} последняя цифра: ");

if (num < 0) {
    num *=-1;
}
if (num <= 99 && num >= -99) {
    Console.Write ("третьей цифры нет");
}
else{
  
    while (num >= 999){
        num /= 10;
    }
    num = num % 10;
    Console.WriteLine (num);
}
   
