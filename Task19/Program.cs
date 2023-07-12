// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
// 14212 - нет, 23432 - да, 12821 - да

void CheckNumber(int number)
{
    int theFirstFigure = number;
    int theLastFigure = number;
    if(theFirstFigure / 10000 == theLastFigure % 10)
    {
        if((theFirstFigure / 1000) % 10 == (theLastFigure % 100) / 10)
        {
            Console.WriteLine($"Число {number} - является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} - не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine($"Число {number} - не является палиндромом");
    }
}


Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
CheckNumber(number);