Salom:

Console.WriteLine("punkti tanlang");
System.Console.WriteLine("1.Asosiy");
System.Console.WriteLine("2.Chizish");

int tanlash = Convert.ToInt32(Console.ReadLine());

if(tanlash == 1)
{
Console.WriteLine("punkti tanlang");
System.Console.WriteLine("1.Kvadrat peremtri");
System.Console.WriteLine("2.Uchburchakni peremetri");
System.Console.WriteLine("3.Tog'ri tortburchak peremetri");

int b = Convert.ToInt32(Console.ReadLine());

if(b == 1)
{
System.Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a * 4);
}

if(b == 2)
{
System.Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.Write("d = ");
int d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a + c + d);
}

if(b == 3)
{
System.Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("c = ");
int c = Convert.ToInt32(Console.ReadLine());
int f = 2*(a + c);
System.Console.WriteLine(f);
}
}

if(tanlash == 2){
    Console.WriteLine("punkti tanlang");
System.Console.WriteLine("1.Kvadrat");
System.Console.WriteLine("2.Uchburchak");
System.Console.WriteLine("3.Tog'ri tortburchak");

int b = Convert.ToInt32(Console.ReadLine());

if(b == 1)
{
System.Console.WriteLine("*");
}

if(b == 2)
{
System.Console.WriteLine("*");
}

if(b == 3)
{
System.Console.WriteLine("*");
}
}

System.Console.WriteLine("Davom etasizmi. ha yoki yoq");
string k = Console.ReadLine();

if(k == "ha")
{
goto Salom;
}
else if(k == "yoq")
{
System.Console.WriteLine("ok");
}