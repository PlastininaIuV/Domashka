// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("включить значение b1");
двойной b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
двойной k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("включить значение b2");
двойной b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
двойной k2 = Convert.ToInt32(Console.ReadLine());

двойной х = (-b2 + b1)/(-k1 + k2);
двойной у = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся с координатами X: {x}, Y: {y}");