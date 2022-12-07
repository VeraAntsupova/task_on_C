Console.WriteLine("Веведите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веведите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веведите 3-ье число: ");
int p = Convert.ToInt32(Console.ReadLine());
if (n>m)
{
    if (n>p)
    {
        Console.WriteLine(n);
    }
    else
    {
        Console.WriteLine(p);
    }
}
else if (m>p)
{
    Console.WriteLine(m);
}
else 
{
    Console.WriteLine(p);
}
    