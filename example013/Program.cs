// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 13

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
   