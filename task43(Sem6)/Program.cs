// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Точка пересечения прямых X: {x}, Y: {y}");