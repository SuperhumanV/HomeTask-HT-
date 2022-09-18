void v1()
// Ввод числа и проверки
{
    Console.WriteLine("Input tree-digit number");
    string? num = Console.ReadLine();
    if (num != null)
    {
        if (num.Length == 3)
        //Преобразование в массив
        {
            char[] massive = num.ToCharArray();
            //Вывод числа
            Console.WriteLine("Second digit" + " " + massive[1]);
        }
    }
}

void SoZv()
{  // Ввод числа
    Console.WriteLine("Input  number");
    string? num = Console.ReadLine();
    // Проверка
    if (num != null)
    { // В массив
        char[] massive = num.ToCharArray();
        // Вывести цифру под номером
        Console.WriteLine("The digit under №");
        string? serial = Console.ReadLine();
        // Проверка
        if (serial != null)
        //вычисления номера в массиве и вывод
        {
            int index = Int32.Parse(serial);
            Console.Write(("is ")+ (massive[(index - 1)]));
        }
    }
}
SoZv();