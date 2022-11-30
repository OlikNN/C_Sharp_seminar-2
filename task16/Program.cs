// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите первое числ");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе числ");
int digit2 = Convert.ToInt32(Console.ReadLine());

if (digit2 == digit1 * digit1 || digit1 == digit2 * digit2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}