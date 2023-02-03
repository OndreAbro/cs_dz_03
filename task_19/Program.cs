// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((9999 < number && number < 100000) || (-9999 > number && number > -100000))
{
    if (number < 0)
    {
        number = number - 2 * number;
    }

    string str_number = Convert.ToString(number);
    
    if (str_number[0] == str_number[4] && str_number[1] == str_number[3])
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Неверный ввод!");
}
