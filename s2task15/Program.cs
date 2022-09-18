void v1()
{
    Console.WriteLine("Цифра дня недели ");
    string? day = Console.ReadLine();
    if (day != null)
    {

        int ned = Int32.Parse(day);
        while (ned < 8)
        {

            if (ned < 6)
            {
                Console.WriteLine("Рабочий день");
                break;
            }
            else
            {
                Console.WriteLine("Выходной");
                break;
            }
        }

    }
}

void v2()
{
    Console.WriteLine("Цифра дня недели ");
    string? day = Console.ReadLine();

    if (day != null)
    {
        int ned = Int32.Parse(day);




        if ((ned < 6) && (ned > 0))
        {
            Console.WriteLine("Рабочий день");

        }
        else if ((ned > 5) && (ned < 8))
        {
            Console.WriteLine("Выходной");

        }
        else
        {
            Console.WriteLine("Ъуъ");
        }


    }
}
v2();