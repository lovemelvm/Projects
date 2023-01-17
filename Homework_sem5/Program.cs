//Семинар 5. Задача 37. 
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

string ArrayToString(int[] array)
{
    return $"[{String.Join(",", array)}]";
}

int ReadArrayLength(string text)
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
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }

}

int[] CalculateResult(int[] array)
{
    int[] result;
    bool isEven = array.Length % 2 == 0;
    int endIndex;
    if (isEven)
    {
        result = new int[array.Length / 2];
        endIndex = array.Length / 2 - 1;
    }
    else
    {
        result = new int[array.Length / 2 + 1];
        endIndex = array.Length / 2;
    }

    for (int i = 0; i <= endIndex; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (!isEven)
    {
        result[result.Length - 1] = array[array.Length / 2];
    }
    return result;
}

int length = ReadArrayLength("Введите длину массива (N): ");
int[] array = CreateArray(length);
FillArray(array);
int[] result=CalculateResult(array);
Console.WriteLine(ArrayToString(array) + " -> " + ArrayToString(result));