Console.WriteLine("Input your number");
string? lineA = Console.ReadLine();

if(lineA != null)
{
   int num1 = Int32.Parse(lineA);
    if(num1%2==0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}