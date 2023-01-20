// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число: ");

int N = int.Parse(Console.ReadLine()!);
int number = 1;

while (number <= N)
{
    Console.WriteLine(number * number * number);
    number ++;
}