// Задача 29: Напишите программу, которая задаёт массив из 8 целочисленных элементов и выводит их на экран.

int[] createRandArr(int size, int min, int max)
{
    int[] num = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        num[i] = random.Next(min, max+1);
    }
    return num;
}
int[] createArr(int size)
{
    int[] num = new int[size];
    for (int i=0; i < size; i++)
    {
        num[i] = IntInput( "(" + i + ")" );
    }
    return num;
}

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
void printArr(int[] array)
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + ".";
    }
    Console.WriteLine(str);
}
Console.WriteLine("Выберите тип ввода: ");
Console.WriteLine("1 - Автоматический ");
Console.WriteLine("2 - Ручной ");
if(int.TryParse(Console.ReadLine(), out int а))
{
    switch (а)
{
    case 1:
        int[] myArr = createRandArr(8, 0, 100);
        printArr(myArr);
        break;
    
    case 2:
        int[] myArrManual = createArr(8);
        printArr(myArrManual);
        break;
    default:
        Console.WriteLine("Ошибка!!!");
        break;
}
}

