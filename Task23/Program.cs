// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
//3 -> 1, 8, 27
//5 ->1,8,27,64,125

void DoubleNumbers(int number)
{
    Console.WriteLine($"Кубы чисел от 1 до {number}");
    for(int i = 1; i <= number; i++)
    {
        Console.Write(i * i * i + " ");
    }
}

Console.Write("Введите число: ");
int number  = int.Parse(Console.ReadLine());
 DoubleNumbers(number);