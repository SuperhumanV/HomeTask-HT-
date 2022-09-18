Console.WriteLine("Input number, power: ");
string line = Console.ReadLine();
string line2 = Console.ReadLine();
if(line!=null&&line2!=null)
// ввод сразу двух переменных через , и пробел
//string[] spearator = { ", " };
//string[] strNum = line.Split(spearator, System.StringSplitOptions.RemoveEmptyEntries);
//int A = Int32.Parse(strNum[0]);
//int B = Int32.Parse(strNum[3]);
{int A = Int32.Parse(line);
int B = Int32.Parse(line2);
int result = A;
for (int i = 1; i < B; i++)
{
    result = result * A;
}
Console.WriteLine(result);
}