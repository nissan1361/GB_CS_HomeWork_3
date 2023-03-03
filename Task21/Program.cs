// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int aX;
int aY;
int aZ;
int bX;
int bY;
int bZ;

static int InputPositions()
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
            Console.WriteLine("Введите верную координату!!!");
        }
    }
}

Console.Write("Введите a(X): ");
aX = InputPositions();
Console.Write("Введите a(Y): ");
aY = InputPositions();
Console.Write("Введите a(Z): ");
aZ = InputPositions();
Console.Write("Введите b(X): ");
bX = InputPositions();
Console.Write("Введите b(Y): ");
bY = InputPositions();
Console.Write("Введите b(Z): ");
bZ = InputPositions();

double result;

result = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
result = Math.Sqrt(result);
result = Math.Round(result, 2);

Console.WriteLine($"Расстояние между точками -> {result}");