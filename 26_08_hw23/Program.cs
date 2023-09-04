/*Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.*/

int Output(string mes)
{
    Console.WriteLine(mes);
    return int.Parse(Console.ReadLine()!);
}

void MultTable(int N)
{
    int i = 1;
    while (i < N)
    {
        double square = Math.Pow(i, 3);
        Console.Write($"{square}, ");
        i ++;
    }
    Console.WriteLine($"{N*N*N}.");
}

MultTable(Output("Please input number!"));