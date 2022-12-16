// See https://aka.ms/new-console-template for more information
Console.Clear();
 Console.Write ("ВВедите число: ");
 string n = Console.ReadLine();

while(n.Length != 5) 
{
    Console.Write("Вы ошиблись, введите пятизначное число: ");
    n = Console.ReadLine();
}


if (n[0] == n[4] && n[1] == n[3])
{
    Console.WriteLine($"{n} - Палиндром");
}
else
{
    Console.WriteLine($"{n} - НЕ палиндром");
}



    