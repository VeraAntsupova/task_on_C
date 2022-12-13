Console.Clear();
 Console.Write ("ВВедите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 while ( n<1 || n>7)
 {
       Console.Write("Вы ошиблись, введите число от 1 до 7: ");
       n = Convert.ToInt32(Console.ReadLine());
 }
if (n == 1)
Console.WriteLine("Понедельник - не выходной");
else if (n == 2)
Console.WriteLine("Вторник - не выходной");
else if (n == 3)
Console.WriteLine("Среда - не выходной");
else if (n == 4)
Console.WriteLine("Четверг - не выходной");
else if (n == 5)
Console.WriteLine("Пятница - не выходной");
else if (n == 6)
Console.WriteLine("Суббота - Ура, выходной");
else if (n == 7)
Console.WriteLine("Воскресенье - Ура, выходной");
