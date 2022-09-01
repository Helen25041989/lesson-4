int[] numbers = new int[8];

for (int i = 0; i < 8; i++)
{
    numbers[i] = new Random().Next(0,100);
}
Console.WriteLine("Массив = [{0}]", string.Join(",",numbers));