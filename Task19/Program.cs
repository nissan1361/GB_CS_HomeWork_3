// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

static int InputNumber()
{
    int x;
    while (true)
    {
        Console.Write("Введите 5-ти значное число: ");
        if (int.TryParse(Console.ReadLine(), out x))
        {
            if (x > 9999 && x < 100000)
            {
                return x;
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода, введите 5-ти значное число!!!");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода, введите корректное число!");
        }
    }
    
}

int num = InputNumber();
Console.WriteLine($"Введено число: {num}");

static void Palindrom(int x)
{
    int fitstNum = x / 10000;
    int secondNum = x % 10;
    if (fitstNum == secondNum)
    {
        Console.WriteLine("Да, Палиндром!");
    }
    else
    {
        Console.WriteLine("Нет, не палиндром.");
    }
}

Palindrom(num);
