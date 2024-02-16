/*
Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.)
*/

void Main()
{
    Console.Write("Введите длину массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = GenerateArray(size);
    Console.WriteLine("");
    Console.WriteLine("Перевернутый массив:");    
    int i = 0;
    while (i < array.Length / 2)
    {
       int temp = array[i];
       array [i] = array [size - 1 - i];
       array [size - 1 - i] = temp;
       i++;
    }
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }

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
