using System;
/*Написать программу, которая принимает нв вход координаты 2-х точек и рассчитывает расстояние между ними в 3Д пространстве.*/

Console.WriteLine("Please input coordinates of points");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);

double DistCoord(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double dist = Math.Pow(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2),0.5);
    return dist;
}

double distanse = DistCoord(x1, x2, y1, y2, z1, z2);
Console.WriteLine(distanse);