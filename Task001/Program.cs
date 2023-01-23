// 1. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится 
// эта точка.

//Ввод целого значения
int Promt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int xCoord, int yCoord)
{
    if (!(xCoord == 0 || yCoord == 0))
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Точка лежит хотя бы на одной из осей");
        return false;
    }
}
int GetQuorter(int xCoord, int yCoord)
{
    if (xCoord > 0 && yCoord > 0)
    {
        return 1;
    }
    if (xCoord > 0 && yCoord < 0)
    {
        return 4;
    }
    if (xCoord < 0 && yCoord > 0)
    {
        return 2;
    }
    return 3;

}

int x = Promt("Введите X");
int y = Promt("Введите Y");
if (ValidateCoords(x, y))
{
    int quorter = GetQuorter(x, y);
    System.Console.WriteLine($"Номер четверти {quorter} ");
}