Console.WriteLine("Input your number");
string? line1 = Console.ReadLine();

if(line1 != null)
{
    int num = Int32.Parse(line1);
    int i = 1;
   Console.WriteLine("Even numbers");
    while(i<=num)
    { 
        if(i%2==0)
        {
            Console.WriteLine(i);
        }
        i++;

    }
}
