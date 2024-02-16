/*
Задача:
Задайте массив заполненный случайными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

void Main()
{
    Console.Write("Введите длину массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = GenerateArray(size);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"\nКоличество четных чисел = {count}");

    int[] GenerateArray(int arraySize)
    {
        int[] myArray = new int[arraySize];
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            int randomNumber = random.Next(100, 1000);
            myArray[i] = randomNumber;
        }
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"{myArray[i]} ");
        }
        return myArray;
    }
}

Main();
