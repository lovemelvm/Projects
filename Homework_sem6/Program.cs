// Семинар 6. Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string GoodPrint(string input, int positiveNumberCount)
{
    return $"{input} >> {positiveNumberCount}";
}

string ReadUserInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();

}

string[] FormatInput(string input)
{
    return input.Replace(" ", "").Split(",");
}

int GetPositiveNumbersCount(string[] array)
{
    int positiveNumberCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = int.Parse(array[i]);
        if (currentNumber > 0)
        {
            positiveNumberCount++;
        }
    }
    return positiveNumberCount;
}

string input = ReadUserInput("Введите числа через запятую: ");
string[] formattedInput = FormatInput(input);
int positiveNumberCount = GetPositiveNumbersCount(formattedInput);
Console.WriteLine(GoodPrint(input, positiveNumberCount));




// Семинар 6. Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string GoodPrint(double k1, double k2, double b1, double b2, double x, double y)
{
    return $"k1 = {k1},b1 = {b1},k2 = {k2},b2 = {b2} >> [{x};{y}]";
}

double ReadUserInput(string text)
{
    Console.Write(text);
    return double.Parse(Console.ReadLine());
}

double k1 = ReadUserInput("Введите K1: ");
double b1 = ReadUserInput("Введите B1: ");
double k2 = ReadUserInput("Введите K2: ");
double b2 = ReadUserInput("Введите B2: ");


double differenceK = k1 - k2;
if (differenceK == 0)
{
    Console.WriteLine("Точка пересечения отсутствует");
}
else
{
    double x = (b2 - b1) / differenceK;
    double y = k1 * x + b1;
    Console.WriteLine(GoodPrint(k1,k2,b1,b2,x,y));
}