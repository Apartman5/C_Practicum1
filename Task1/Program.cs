// Напишите программу, которая на вход принимает число
// и выдает его квадрат (умножение числа на себя)
// Примеры:
// 4 -> 16
// -3 -> 9
// -7 - 49

int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("Your result is: " + result);// Метод вывода сложением строк
// Console.WriteLine("Your result is: {0}", result); - метод вывода результата подстановкой аргумнтов. В данном случае всего 1 аргумент (result) с позицией {0}, который и подставляется в вывод
// Console.WriteLine($"Your result is: {result}"); - метод вывода интерполяцией строк, где $ дает возможность писать внутри строки кд ({result} - это по сути код), например
// Console.WriteLine($"Your result is: {number * number}");
