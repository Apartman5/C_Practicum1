// Задача №3
// Напишите программу, которая выдает название дня недели по номеру
// Примеры:
// 3 -> среда
// 5 -> пятница

Console.Write("Введите номер дня недели: ");
int weekDay = Convert.ToInt32(Console.ReadLine());
switch(weekDay)
{
    case 1:
    Console.WriteLine("Это понедельник");
    break;

    case 2:
    Console.WriteLine("Это вторник");
    break;

    case 3:
    Console.WriteLine("Это среда");
    break;

    case 4:
    Console.WriteLine("Это четверг");
    break;

    case 5:
    Console.WriteLine("Это пятница");
    break;

    case 6:
    Console.WriteLine("Это суббота");
    break;

    case 7:
    Console.WriteLine("Это воскресенье");
    break;

    default:
    Console.WriteLine("Не существует такого дня недели!");
    break;
}