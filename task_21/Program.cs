// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int InputNumber(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

int xA = InputNumber("Введите координату X точки A: ");
int yA = InputNumber("Введите координату Y точки A: ");
int zA = InputNumber("Введите координату Z точки A: ");

int xB = InputNumber("Введите координату X точки B: ");
int yB = InputNumber("Введите координату Y точки B: ");
int zB = InputNumber("Введите координату Z точки B: ");

Console.WriteLine($"Расстояние между точками A и B: {Math.Round(Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2)), 2)}");
