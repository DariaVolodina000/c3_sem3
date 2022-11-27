// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// ++ сначала задает размерность пространство, потом координаты, найти расстояние в N мерном пространстве.

// модуль math




Console.WriteLine("Найдем расстояние координат в 2D пространстве. ");

Console.WriteLine("Напишите первую координату X в точке А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите первую координату y в точке А");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите вторую координату X в точке B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите вторую координату y в точке B");
int y2 = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2));


Console.WriteLine("Расстояние между координарами в 2D пространстве = " + length);








