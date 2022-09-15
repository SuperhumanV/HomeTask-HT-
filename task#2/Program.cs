Console.WriteLine ("Input number 1");
int numA =Int32.Parse(Console.ReadLine ());
Console.WriteLine ("Input number 2");
int numB = Int32.Parse(Console.ReadLine ());
if(numA>numB)
{
    Console.WriteLine("max=");
    Console.WriteLine(numA);
    Console.WriteLine("min =");
    Console.WriteLine(numB);
}
else 
{
    Console.WriteLine("max =");
    Console.WriteLine(numB);
    Console.WriteLine("min =");
    Console.WriteLine(numA);
}
