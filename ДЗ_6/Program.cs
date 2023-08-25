// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// System.Console.WriteLine("Введите количество чисел: ");
// int numCount = Convert.ToInt32(Console.ReadLine());

// int[] array = new int [numCount];
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.WriteLine($"Введите {i+1} число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("");
// }
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if ( array[i] > 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine($"количество чисел больше 0 = {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// System.Console.WriteLine("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2-b1)/(k1-k2);
// double y = k1*x + b1;
// if ( k1 !=k2 && ((k1*x)+b1)!= ((k2*x)+b2))
// {
//     System.Console.WriteLine($"Прямые пересекаются в точке ({x}, {y})");
// }
// else if ( k1==k2)
// {
//     System.Console.WriteLine("Прямые параллельны");
// }
// else if (((k1*x)+b1)==((k2*x)+b2))
// {
//     System.Console.WriteLine("прямые совпадают");
// }


