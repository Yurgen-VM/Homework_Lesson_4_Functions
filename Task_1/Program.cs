/*
Задача:
Написать программу, которая бесконечно запрашивает целые числа с консоли.
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/

using System.Globalization;

int RequestDigit(int msg)
{
Console.WriteLine (msg);
int numbers = Convert.ToInt32(Console.ReadLine());
while (numbers % 1 == 0)
    {
        int result = numbers;
    }
return result;
}
Console.WriteLine("Число не является целым, повторите ввод");




