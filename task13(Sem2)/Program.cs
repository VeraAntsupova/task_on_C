Console.Write("ВВедите число: ");
 int n = Convert.ToInt32(Console.ReadLine());

int count = n.ToString().Length;

 
 if(count >= 3 ){

int c=1;
for (int i=count; i>3; i--){
    c = c *10;
}
 int n3 = (n / c) % 10;
 Console.Write (n3);
 }else
 Console.Write ("третьей цифры нет");