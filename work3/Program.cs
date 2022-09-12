// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Массив");
int[] CreateArray()
{
    Random randomNum = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNum.Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}
int[] array = CreateArray();
PrintArray(array);


//Ниже пример с ручным вводом массива



/* void CreateArray(string[] args)
{
    Console.WriteLine("Введите размер массива ");
    int countElements = int.Parse(Console.ReadLine());
    int[] array = new int[countElements];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i}:\t");
        array[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Вывод массива ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
CreateArray(args); */

