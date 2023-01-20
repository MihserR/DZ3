// Подсчитать сумму цифр в числе
Console.WriteLine("Ведите число");
int n = int.Parse(Console.ReadLine()!);
int a = n;
int sum = 0;

while (n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
Console.Write("Сумма цифр числа " + a + " = " + sum);