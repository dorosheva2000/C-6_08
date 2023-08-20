/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
string TheThirdDigit(int num)
{
    if (num / 100 == 0) return "третьей цифры нет";
    else if (num / 100 != 0 && num / 1000 == 0 ) return $"{num % 10}";
    else
    {
        int bignum = num;
        while (bignum > 999)
        {
            bignum = bignum / 10;
        }
        int res = bignum % 10;
        return $"{res}";
    }
}

int number = int.Parse(Console.ReadLine()!);
Console.Write(TheThirdDigit(number));