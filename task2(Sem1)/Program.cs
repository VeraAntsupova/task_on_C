Console.WriteLine("Введите 1-ое число: ");
   int n = Convert.ToInt32(Console.ReadLine()); //ввод чисел
Console.WriteLine("Введите 2-ое число: "); 
   int m = Convert.ToInt32(Console.ReadLine()); //ввод чисел
   if (n > m)
   {
       Console.Write(n);
   }
   else if(n == m){
        Console.Write("числа равны");
   }
   else
   {
       Console.Write(m);
   }
    