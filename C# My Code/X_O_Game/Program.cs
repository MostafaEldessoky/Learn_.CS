string[] xo = new string[9];
int k = 0;  

for (int i = 0; i < 9; i++)
{
    k++;
    xo[i] = $"{k}";
}

void game(int player,int x)
{
    if (player == 0)
    {
        xo.SetValue("X",x-1);
    }
    else
    {
        xo.SetValue("O", x-1);
    }
}

Boolean winner(string c)
{
    int s = 0;
    for (int i = 0; i < 8; i = i+3)
    {
        for (int j = 0; j < 3; j++)
        {
            if (xo[j+i] == c )
            {
                s++;
                if ( s == 3 )
                {
                    return true;
                }
            }
        }
        s = 0;
    }
    s = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 8; j = j+3)
        {
            if (xo[j + i] == c)
            {
                s++;
                if (s == 3)
                {
                    return true;
                }
            }
        }
        s = 0;
    }
    s = 0;
    for (int i = 0; i < 9; i = i+4)
    {
        if (xo[i] == c)
        {
            s++;
            if (s == 3)
            {
                return true;
            }
        }
    }
    s = 0;
    for (int i = 6; i > 0; i = i - 2)
    {
        if (xo[i] == c)
        {
            s++;
            if (s == 3)
            {
                return true;
            }
        }
    }
    return false;
}

Boolean screen(string[] xo,int p)
{
    Console.Clear();
    Console.WriteLine("   X_O Game");
    Console.WriteLine( " --- --- ---");
    Console.WriteLine( "|   |   |   |");
    Console.WriteLine($"| {xo[0]} | {xo[1]} | {xo[2]} |");
    Console.WriteLine( "|   |   |   |");
    Console.WriteLine( " --- --- ---");
    Console.WriteLine( "|   |   |   |");
    Console.WriteLine($"| {xo[3]} | {xo[4]} | {xo[5]} |");
    Console.WriteLine( "|   |   |   |");
    Console.WriteLine( " --- --- ---");
    Console.WriteLine( "|   |   |   |");
    Console.WriteLine($"| {xo[6]} | {xo[7]} | {xo[8]} |");
    Console.WriteLine( "|   |   |   |");
    Console.WriteLine( " --- --- ---");

    if (winner("O"))
    {
        Console.WriteLine($"Player O is the winner");
        return false;
    }
    else if (winner("X"))
    {
        Console.WriteLine($"Player X is the winner");
        return false;
    }
    else
    {
        if (p == 0)
        {
            Console.WriteLine($"player O Turn");
        }
        else
        {
            Console.WriteLine($"player X Turn");
        }
        return true;
    }
}

void start()
{
    int p = 0;
    while (screen(xo, p))
    {
        Console.WriteLine("Please enter your move ");
        try
        {
            int x = Convert.ToInt16(Console.ReadLine());
            if (xo.GetValue(x-1) == "X" || xo.GetValue(x-1) == "O")
            {
                Console.WriteLine("invalid move ");
            }
            else
            {
                p = (p + 1) % 2;
                game(p, x);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid input ");
        }
    }
}
start();

