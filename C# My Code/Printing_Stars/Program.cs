// See https://aka.ms/new-console-template for more information

star1();
Console.WriteLine("-------------------------");

star2();
Console.WriteLine("-------------------------");

star3();
Console.WriteLine("-------------------------");

star4();
Console.WriteLine("-------------------------");

star5();
Console.WriteLine("-------------------------");

void star1()
{

    Console.WriteLine("Enter Max Num of Stars");
    int x = Convert.ToInt16(Console.ReadLine());
    string s = "*";
    for (int i =1; i <= x; i++)
    {
        Console.WriteLine(s);
        s = s + "*";

    }
}
void star2()
{

    Console.WriteLine("Enter Max Num of Stars");
    int x = Convert.ToInt32(Console.ReadLine());
    string s = "*";
    for (int i = 0; i < x*2 - 1; i++)
    {
        if (i < x-1)
        {
            Console.WriteLine(s);
            s = s + "*";
        }
        else
        {
            Console.WriteLine(s);
            s = s.Substring(0, s.Length-1);
        }
    }
}               
void star3()
{

    Console.WriteLine("Enter Max Num of Stars");
    int x = Convert.ToInt32(Console.ReadLine());
    string s = "*";
    for (int i =1; i< x; i++)
    {
        s = s + "*";
    }
    if (x % 2 != 0)
    {
        x = x + 1;
    }
    for (int i = 0; i < x/2; i++)
    {
        Console.WriteLine(s);
        s = s.Remove(i, 1).Insert(i, " ");
        s = s.Remove(s.Length - i - 1, 1).Insert(s.Length - i - 1, " ");
    }
}
void star4()
{

    Console.WriteLine("Enter Max Num of Stars");
    int x = Convert.ToInt32(Console.ReadLine());
    string s = " ";
    string c;
    for (int i = 1; i < x; i++)
    {
        s = s + " ";
    }
    if (x % 2 != 0)
    {
        c = "*";
        x = x + 1;
        for(int i = 0; i < x / 2; i++)
        {
            s = s.Remove(x / 2 -i-1, 1+i*2).Insert(x / 2 - i-1, c);
            c = c + "**";
            Console.WriteLine(s);
        }
    }
    else
    {
        c = "**";
        for (int i = 0; i < x / 2; i++)
        {
            s = s.Remove(x / 2 - i - 1, 1 + i * 2).Insert(x / 2 - i - 1, c);
            c = c + "**";
            Console.WriteLine(s);
        }
    }

}
void star5()
{

    Console.WriteLine("Enter Max Num of Stars");
    int x = Convert.ToInt32(Console.ReadLine());
    string s = " ";
    string c;
    if (x % 2 != 0)
    {
        c = "*";
        for (int i = 1; i < x; i++)
        {
            s = s + " ";
        }
        x = (x + 1) / 2;
        for (int i = 0; i < x ; i++)
        {
            s = s.Remove(x  - i - 1, 1 + i * 2).Insert(x  - i - 1, c);
            c = c + "**";
            Console.WriteLine(s);
        }
        for (int i = 0; i < x ; i++)
        {
            s = s.Remove(i, 1).Insert(i, " ");
            s = s.Remove(s.Length - i - 1, 1).Insert(s.Length - i - 1, " ");
            Console.WriteLine(s);
        }
    }
    else
    {
        c = "**";
        x = x / 2;
        for (int i = 1; i < x; i++)
        {
            s = s + " ";
        }
        for (int i = 0; i < x ; i++)
        {
            s = s.Remove(x  - i - 1, 1 + i * 2).Insert(x  - i - 1, c);
            c = c + "**";
            Console.WriteLine(s);
        }
        for (int i = 0; i < x ; i++)
        {
            s = s.Remove(i, 1).Insert(i, " ");
            s = s.Remove(s.Length - i - 1, 1).Insert(s.Length - i - 1, " ");
            Console.WriteLine(s);
        }
    }

}
