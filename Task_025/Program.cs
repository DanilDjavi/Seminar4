// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int IntInput(string intName) 
{
    int number;
    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ошибка!!!");
        Console.Write($"Введите число {intName}: ");
    }
    return  number;
}
int numberA;
int numberB;
double res = 1;
numberA = IntInput("A");
numberB = IntInput("B");
for(int i = 1; i <= numberB; i++)
{
    res = res * numberA;
}
Console.WriteLine($"{numberA}^{numberB} = {res}");