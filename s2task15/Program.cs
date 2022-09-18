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
