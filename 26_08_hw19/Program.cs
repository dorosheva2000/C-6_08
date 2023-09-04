/*Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом.*/

Console.WriteLine("Please input five digits number!");
int N = int.Parse(Console.ReadLine()!);

string Polindrom(int N)
{
    if ((N % 10 == N / 10000) && ((N % 100)/10 == (N / 1000) % 10)) return "Polindrom";
    else return "Not polindrom";
}

string res = Polindrom(N);
Console.Write(res);