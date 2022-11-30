// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

Console.WriteLine("Введите числ A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числ B");
int numberB = Convert.ToInt32(Console.ReadLine());
int ostatoc = numberA % numberB;

if (ostatoc > 0)
{
    Console.WriteLine($"{numberA}, {numberB} -> не кратно, остаток {ostatoc}");
}
else
{
    Console.WriteLine($"{numberA}, {numberB} -> кратно");
}