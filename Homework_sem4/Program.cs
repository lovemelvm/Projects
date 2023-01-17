//Семинар 4. Задача 777. //using static Library;
// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

int ReadNumberLength(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length)
{
    return new int[length];
}

void FillArray(int[] array)
{
    array[0] = 1;
    Random rnd = new Random();
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

string ArrayToString(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }
    return result;
}

int ConvertToDecimal(int[] array)
{
    int result = 0;
    for (int i = 0, p = array.Length - 1; i < array.Length && p >= 0; i++, p--)
    {
        result += array[i] * IntPow(2, p);
    }
    return result;
}

int IntPow(int number, int pow)
{
    if (pow == 0)
    {
        return 1;
    }
    if (pow == 1)
    {
        return number;
    }
    int result = number;
    for (int i = 1; i < pow; i++)
    {
        result = result * number;
    }
    return result;
}

string GoodPrint(int[] bin, int dec)
{
    return $"{String.Join("", bin)} >> {dec}";
}

int length = ReadNumberLength("Введите N - Длина двоичного числа: ");
int[] binaryNumber = CreateArray(length);
FillArray(binaryNumber);
Console.WriteLine("Двоичное число: " + ArrayToString(binaryNumber));
int dec = ConvertToDecimal(binaryNumber);
Console.WriteLine(GoodPrint(binaryNumber, dec));





//Cеминар 4. Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
  {
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);