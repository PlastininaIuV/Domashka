// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Введите координаты для точки А: ");
double ax = Convert.ToDouble(Console.ReadLine());
double ay = Convert.ToDouble(Console.ReadLine());
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты для точки В: ");
double bx = Convert.ToDouble(Console.ReadLine());
double by = Convert.ToDouble(Console.ReadLine());
double bz = Convert.ToDouble(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((ax-bx), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));

Console.WriteLine($"Расстояние между А и В = {Math.Round(distans, 3)}");
