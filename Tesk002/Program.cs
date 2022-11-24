/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetCoordinateFromUser(string l, string c)
{
    Console.Write($"Введите координату {l} точки {c}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double GetDistanceIn3D(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    return Math.Abs(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)));
}

int Ax = GetCoordinateFromUser("х", "А");
int Ay = GetCoordinateFromUser("y", "А");
int Az = GetCoordinateFromUser("z", "А");
int Bx = GetCoordinateFromUser("х", "B");
int By = GetCoordinateFromUser("y", "B");
int Bz = GetCoordinateFromUser("z", "B");
double distance = GetDistanceIn3D (Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine($"Растояние между точками: {distance}");

