// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
Console.WriteLine($"{i*i*i}");

