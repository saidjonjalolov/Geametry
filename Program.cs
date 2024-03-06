    // ---------------------------------------------------------------
    // Copyright (c) Coalition of the Good-Hearted Engineers
    // FREE TO USE TO CONNECT THE WORLD
    // ---------------------------------------------------------------

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

int tanlash2 = Convert.ToInt32(Console.ReadLine());

if(tanlash2 == 1)
{
    System.Console.Write("a = ");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(a * 4);
}

if(tanlash2 == 2)
{
    System.Console.Write("a = ");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("c = ");
    int c = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("d = ");
    int d = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(a + c + d);
}

if(tanlash2 == 3)
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

int tanlash2 = Convert.ToInt32(Console.ReadLine());

if(tanlash2 == 1)
{
    System.Console.WriteLine("********\n*      *\n*      *\n*      *\n********");
}

if(tanlash2 == 2)
{
    Console.WriteLine("       *\n     *  *\n    *    *\n   *      *\n  *        *\n *          *\n**************");
}

if(tanlash2 == 3)
{
    System.Console.WriteLine("*****************\n*      \t\t*\n*      \t\t*\n*      \t\t*\n*****************");
}
}

System.Console.WriteLine("Davom etasizmi. ha yoki yoq");
string davometish = Console.ReadLine();

if(davometish == "ha")   
{
    goto Salom;
}
    else if(davometish == "yoq")
{
    System.Console.WriteLine("ok");
}