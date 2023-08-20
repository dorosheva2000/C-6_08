/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

string Weekend(int day)
{
    if(day == 6 || day == 7) return "да";
    else return "нет";
}

int dow = int.Parse(Console.ReadLine()!);
Console.Write(Weekend(dow));