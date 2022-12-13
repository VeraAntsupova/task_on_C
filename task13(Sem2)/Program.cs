// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n3 = n % 10;
if(n>=100)
Console.Write (n3);
else
Console.Write ("третьей цифры нет");
