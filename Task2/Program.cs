// Задача №2
// Напишите программу, которая на вход принимает два числа и проверяет
// является ли одно число квадратом другого
// Примеры:
// a = 25, b = 5 -> да;
// a = 2, b = 10 -> нет;

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB * numberB)
{
    Console.WriteLine("A - это квадрат B");
}
else Console.WriteLine("A - не является квадратом B");