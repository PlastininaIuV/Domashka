// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число: ");
double N = Convert.ToInt32(Console.ReadLine());

int i = 1;
Console.Write($"{N} =");
while(i <= N){
    Console.Write($" {Math.Pow(i, 3)} ");
    i++;
}