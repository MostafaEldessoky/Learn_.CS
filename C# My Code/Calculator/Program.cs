// See https://aka.ms/new-console-template for more information



screen();


void screen()
{
    while (true)
    {
        Console.WriteLine(calculation(num1(), num2(), operation()));
        Console.WriteLine("pres y to contuine");
        string t = Console.ReadLine();
        if (t != "y")
        {
            break;
        }
    }
}



Double num1()
{
    while (true)
    {
        Console.WriteLine("Hello, Please enter Num 1");

        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Hello, Please enter valid input");
        }
    }
}



Double num2()
{

    while (true)
    {
        Console.WriteLine("Hello, Please enter Num 2");
        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Hello, Please enter valid input");
        }
    }

}


char operation()
{


    while (true)
    {

        Console.WriteLine("Hello, Please enter the operation");
        string z = Console.ReadLine();

        if (z == "+" || z == "/" || z == "-" || z == "*")
        {
            return Convert.ToChar(z);
        }
        else
        {
            Console.WriteLine("Hello, Please enter valid input");
        }

    }

}


Double calculation(Double x, Double y, Char z)
{
    if (z == '+')
    {
        return x + y;
    }
    else if (z == '-')
    {
        return x - y;
    }
    else if (z == '*')
    {
        return x * y;
    }
    else if (y != 0)
    {
        return x / y;
    }
    else
    {
        Console.WriteLine("cannot devive by 0");
        return 0;
    }
}

