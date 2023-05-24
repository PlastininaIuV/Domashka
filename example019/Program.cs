// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Введите число для проверки полиндрома: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0, result = 0;

if(num < 100000 && num > 10000){
result = num % 100;
while(num > 100){
    num/=10;
}
temp = num/10;
num %= 10;
temp = num * 10 + temp;
if(temp == result){
    Console.WriteLine("Полиндром");
}
else Console.WriteLine("Не полиндром");
}
else Console.WriteLine("Введите пятизначное число!");
