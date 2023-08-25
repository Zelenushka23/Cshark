// Задача 25: Напишите цикл, который принимает на вход два числа
//  (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


//  System.Console.WriteLine("Введите число А: ");
// int num1= Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine("Введите число B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int GetPowNum()
// {
//     int pow = 1;
//      for(int i = 0; i < num2; i++)
//      {
//       pow = pow * num1;
//      }

//      return pow;
// }

// System.Console.WriteLine(GetPowNum());



// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int numN = Convert.ToString(num);

// int GetSumNum()
// {
//     int result = 0;
//     int size = numN.Length;

//     for (int i = 0; i < size; i++)
//     {
//         result += num % 10;
//         num /= 10;
//     }


//     return result;
// }
// System.Console.WriteLine();
// System.Console.WriteLine(GetSumNum());



// Задача 29: Напишите программу, которая задаёт массив из 8
//  элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] array= new int[8];
// GetArray();

// void GetArray()
// {
//     for(int i = 0; i< array.Length; i++)
//     {
// array[i]= new Random().Next(0, 1000);
// System.Console.WriteLine(array[i] + " ");

//     }
// }



