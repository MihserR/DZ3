// Написать программу вычисления произведения чисел от 1 до N
// Console.WriteLine("Ведите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int a = n;
// int p = 1;
// for(int i = 1; i <= n; i++)
// {
//     p *= i;
// }

// Console.WriteLine("Произведение чисел от 1 до "+ a +" = " + p);

Console.WriteLine("Ведите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
int itog = 1;
while (count <= n)
{
    itog = itog * count;
    count++;
}
Console.WriteLine(itog);