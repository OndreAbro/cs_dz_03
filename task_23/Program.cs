// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubedNumbers(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToInt32(Math.Pow((index + 1), 3));
        index++;
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

CubedNumbers(array);

Console.WriteLine(string.Join(", ", array));
