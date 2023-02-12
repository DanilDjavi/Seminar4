// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int IntInput(string intName)
{
    int number;
    Console.Write("Введите число: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ошибка!!!");
        Console.Write($"Введите число {intName}: ");
    }
    return  number;
}
int sumOfDigits(int i)
{
    int numRes = 0;
    while (i > 0)
    {
        numRes = numRes + (i % 10);
        i = i / 10;
    }
    return numRes;
}
int num = IntInput("");
int sum = sumOfDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {sum}");