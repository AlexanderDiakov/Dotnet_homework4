// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int tempNumber = 0;
    int digitNumber = 0;
    for (int i = 0; number > 0; i++)
    {
        digitNumber = number % 10;
        tempNumber = tempNumber + digitNumber;
        number = number / 10;
    }
    return tempNumber;
}
Console.WriteLine($"сумма цифр в числе --> " + SumNumber(number));

