// ПРинимает на вход случайное трёхзначное число и показывает вторую цифру
Console.Clear();
Console.Write("ВВедите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = n % 100 / 10;
Console.Write (n2);
