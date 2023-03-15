// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> max 7
// 44, 5, 78 -> max 78
// 22, 3, 9 -> max 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;

System.Console.WriteLine("Максимальное из этих чисел = " + max);