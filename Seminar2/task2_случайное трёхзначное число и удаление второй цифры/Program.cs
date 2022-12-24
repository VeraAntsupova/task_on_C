// ПРинимает на вход случайное трёхзначное число и показывает вторую цифру
Console.Clear();

int n = new Random().Next(100, 1000);
int n2 = n % 100;
int n3 = n % 10;
Console.Write (n2 - n3);

 
