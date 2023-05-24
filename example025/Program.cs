// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int InputNumber()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Exponentiate(int baseNum, int degree)
{
    int result = baseNum;
    for (int i = 1; i < degree; i++)
    {
        result *= baseNum;
    }
    return result;
}
int A = InputNumber();
int B = InputNumber();
int result = Exponentiate(A, B);
Console.WriteLine($"Результат {A} в степени {B} = {result}");