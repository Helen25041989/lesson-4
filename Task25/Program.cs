Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int result = a;
for (int i = 1; i < b; i++)
{
    result = result * a;
}

Console.WriteLine("Первое число в степени второго числа = {0}", result);