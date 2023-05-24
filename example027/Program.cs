// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int InputNumber()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int SumNumber(int num){
    int result = 0, temp = 0;
    while(num > 0){
        temp = num % 10;
        result += temp;
        num /= 10;
    }
    return result;
}
int numder = InputNumber();
int result = SumNumber(numder);
Console.WriteLine(result);