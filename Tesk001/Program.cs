/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetInvertedNumbers(int number)
{
    int ReverseNumber = 0;
    int result = 0;
    int DigitNumber = 10;
    while (number != 0)
    {
        ReverseNumber = number % 10;
        result = result * DigitNumber + ReverseNumber;
        number = number / 10;
    }
    return result;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
else
{
    int ReverseNumber = GetInvertedNumbers(number);
    if (number == ReverseNumber)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

