Console.WriteLine ("Input number 1");
string? lineA = Console.ReadLine ();

Console.WriteLine ("Input number 2");
string? lineB = Console.ReadLine ();

Console.WriteLine ("Input number 3");
string? lineC = Console.ReadLine();
if(lineA !=null&& lineB !=null&& lineC !=null)
{
    int numA = Int32.Parse(lineA);
    int numB = Int32.Parse(lineB);
    int numC = Int32.Parse(lineC);
    int max = numA;
    int max2 = 0;
    if(numB>numC)
    {
        max2=numB;
    }
    else
    {
        max2=numC;
    }
   
    if(max>max2)
    {
        Console.WriteLine("max =");
        Console.WriteLine(max);
    }
    
    else
    {
        Console.WriteLine("max =");
        Console.WriteLine(max2);
    }
}
// or int max = Math.Max(a,Math.Max(b,c));
// тернарный оператор
// or int max = ((a>b)? a:b);
// int MAX = ((max>c)? max:c);