int number = new Random().Next(10,1000);
Console.WriteLine(number);
string? lon = number.ToString();
if(lon.Length<3)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    char[] massive = number.ToString().ToCharArray();
    Console.WriteLine(massive[2]);
}