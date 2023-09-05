
/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int InputNumber(string mes)
{
    Console.Write(mes);
    return int.Parse(Console.ReadLine()!);
}

int SumOfDigits(int number)
{
    int sum = 0;
    int num2 = number;
    for (int i = 0; i < (int)Math.Log10(number) + 1; i ++)
    {
        sum += num2 % 10;
        num2 = num2 / 10; 
    }
    return sum;
}

int N = InputNumber("Please input number: ");
Console.Write(SumOfDigits(N));