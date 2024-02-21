/*
Задача:
Написать программу, которая бесконечно запрашивает целые числа с консоли.
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/

void Main()
{

    while (true)
    {
        Console.Write("Введите целое число: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int parsResult))
        {
            Console.WriteLine($"Вы ввели целое число: {parsResult}");
            if (SumOfDigit(parsResult) % 2 == 0)
            {
                Console.WriteLine($"Сумма цифр данного числа - четная. Программа будет завершена!");
                break;
            }

        }
        else
        {
            if (input.Length > 1)
            {
                Console.WriteLine("Ввод некорректных данных! Повторите попытку.");
            }
            else
            {
                if (Char.TryParse(input, out char charResult))
                {
                    if (charResult == 'q')
                    {
                        Console.WriteLine($"Вы ввели: {charResult}, программа будет завершена!");
                    }
                    break;
                }
            }
        }
    }
}


int SumOfDigit(int numbers)
{
    int sum = 0;
    while (numbers > 0)
    {
        sum += numbers % 10;
        numbers /= 10;
    }
    return sum;
}

Main();