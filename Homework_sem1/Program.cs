//Семинар 1. Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// 1.
//   int a = 5;
//   int b = 7;

//   int max = a;

//   if (a > max ) max = a;
//   if (b > max ) max = b;

//   Console.Write("max = ");
//   Console.WriteLine(max);

//   int min = b;

//   if (a < max ) max = a;
//   if (b < max ) max = b;

//   Console.Write("min = ");
//   Console.WriteLine(max);

//2.
//   int a = 2;
//   int b = 10;

//   int max = a;

//   if (a > max ) max = a;
//   if (b > max ) max = b;

//   Console.Write("max = ");
//   Console.WriteLine(max);

//   int min = b;

//   if (a < max ) max = a;
//   if (b < max ) max = b;

//   Console.Write("min = ");
//   Console.WriteLine(max);

//3.
//   int a = -9;
//   int b = -3;

//   int max = a;

//   if (a > max ) max = a;
//   if (b > max ) max = b;

//   Console.Write("max = ");
//   Console.WriteLine(max);

//   int min = b;

//   if (a < max ) max = a;
//   if (b < max ) max = b;

//   Console.Write("min = ");
//   Console.WriteLine(max);


//Семинар 1. Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//1.
//    int a = 2;
//    int b = 3;
//    int c = 7;

//    int max = a;

//    if (a > max ) max = a;
//    if (b > max ) max = b;
//    if (c > max ) max = c;

//    Console.Write("max = ");
//    Console.WriteLine(max);

//2.
//    int a = 44;
//    int b = 5;
//    int c = 78;

//    int max = a;

//    if (a > max ) max = a;
//    if (b > max ) max = b;
//    if (c > max ) max = c;

//    Console.Write("max = ");
//    Console.WriteLine(max);

//3.
//    int a = 22;
//    int b = 3;
//    int c = 99;

//    int max = a;

//    if (a > max ) max = a;
//    if (b > max ) max = b;
//    if (c > max ) max = c;

//    Console.Write("max = ");
//    Console.WriteLine(max);


//Семинар 1. Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//1.
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int remDiv = number % 2;

// if(remDiv == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


//Семинар 1. Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//1.
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(number > 1)
// {
//     while(evenNumber <= number)
//     {
//         Console.Write(evenNumber + " ");
//         evenNumber = evenNumber + 2;
//     }
// }