// Семинар 9. Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int N)
{
    if(N==1)
    {
        Console.Write(N);
        return;
    }
    {
        Console.Write($"{N}, ");
        PrintNumbers(N-1);
    }
}

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(N);





// Семинар 9. Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CalculateSum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else if (M < N)
    {
        return M + N + CalculateSum(M + 1, N - 1);
    }
    else
    {
        return 0;
    }
}

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int result = CalculateSum(M, N);
Console.WriteLine($"M = {M}; N = {N} -> {result}");





// Семинар 9. Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int result = Akkerman(m, n);
Console.WriteLine($"m = {m}, n = {n} -> Akk(m,n) = {result}");
