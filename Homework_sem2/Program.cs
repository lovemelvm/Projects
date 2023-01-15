// Семинар 2. Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");

int threeDigitNumber=Convert.ToInt32(Console.ReadLine());
string stringNumber=Convert.ToString(threeDigitNumber);

//Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);



//Семинар 2. Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
//}



//Семинар 2. Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет



Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);

bool isDayOff(int day)  
{  
    return day >= 1 && day <= 5; 
}

Console.WriteLine(isDayOff(day) ? "да" : "нет"));


int res = dayoff(number);
Console.WriteLine(res);
