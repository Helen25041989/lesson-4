Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();

char[] numberChars = numberStr.ToArray();

int result = 0;
for(int i=0; i<numberChars.Length; i++)
{
    result = result + int.Parse(numberChars[i].ToString());
}
Console.WriteLine("Сумма чисел = {0}",result);

