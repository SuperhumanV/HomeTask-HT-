int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Input number: ");
    string num = Console.ReadLine();
    array[i] = Int32.Parse(num);
}
Console.WriteLine("["+string.Join(", ", array)+"]");