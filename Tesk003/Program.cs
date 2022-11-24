/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void GitCubeNumbers(int number)
{
    Console.Write($"Кубы чисел от 1 до {number} : ");
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine();
}


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
GitCubeNumbers(N);

