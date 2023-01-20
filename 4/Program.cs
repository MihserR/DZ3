// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Ведите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= n)
{
    int res = i * i * i;
    if (res % 2 == 0) System.Console.Write(res + " ");
    i++;
}