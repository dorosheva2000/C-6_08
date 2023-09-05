﻿using System;

public class Answer
{
    static bool IsPalindrome(int number){
    if ((9999 < number || number < 1000000) && ((number % 10 == number / 10000) && ((number % 100)/10 == (number / 1000) % 10))) return true;
    else if (number < 10000 || number > 99999)
    {
      System.Console.WriteLine("Число не пятизначное");
      return false;
    }
    else return false;
}
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}