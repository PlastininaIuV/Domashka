// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int InputNumber()
{
    Console.Write("Введите размер массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");//для наглядности
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
add
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}
int size = InputNumber();
int[] array = new int[size];
CreateArray(array);
PrintArray(array);