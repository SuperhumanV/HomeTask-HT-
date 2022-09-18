Console.WriteLine("Input number: ");
string line = Console.ReadLine();
char[] massive = line.ToCharArray();
int result = 0;
for (int i = 0; i < massive.Length; i++)
{
    result += (Int32.Parse(massive[i].ToString()));
}
Console.WriteLine(result);