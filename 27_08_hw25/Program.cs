/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Please input the first number! ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Please input the second number! ");
int B = int.Parse(Console.ReadLine()!);

int A_BPow(int x1, int x2)
{
    int power = x1;
    for (int i = 1; i < x2; i++)
    {
        power += power;
    }
    return power;
}

int res = A_BPow(A, B);
Console.Write($"A to  the power of B equals {res}");