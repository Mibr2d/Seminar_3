// Задача 3: Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Promt("Введите кординату х1 первой точки");
int y1 = Promt("Введите кординату y1 первой точки");
int x2 = Promt("Введите кординату x2 первой точки");
int y2 = Promt("Введите кординату у2 первой точки");

double Distance(double x1, double x2, double y1, double y2)
{
    double a;
    double b;
    a = x2 - x1;
    b = y2 - y1;
    return Math.Sqrt(a * a + b * b);// Math.Sqrt вычесление корня
}
System.Console.WriteLine(Distance(x1, x2, y1, y2));