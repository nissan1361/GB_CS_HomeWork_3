// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

static int InputNumber()
{
    int x;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out x))
        {
            return x;
            break;
        }
        else
        {
            Console.WriteLine("Введите верное число!");
        }
    }
}

static void TabQuad(int y)
{
    int quad;
    for (int i = 1; i <= y; i++)
    {
        quad = i * i * i;
        Console.Write($"{quad}, ");
    }
    Console.WriteLine("");
}

Console.Write("Введите число: ");
int num = InputNumber();
Console.Write($"{num} -> ");
TabQuad(num);
