/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int ThreeDigit(int num)
{
    return num / 10 - num / 100 * 10;
}

int number = int.Parse(Console.ReadLine());
Console.Write(ThreeDigit(number));