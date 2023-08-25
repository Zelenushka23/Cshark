// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] array = new int[4];

// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + " ");

//     if (array[i]%2 == 0)
//     {
//         sum++;
//     }


// }
// Console.WriteLine();
// Console.WriteLine($"количество четных чисел = {sum}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];

// int sum=0;


// for (int i = 1; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
//     Console.Write(array[i] + " ");
//     if(i % 2==0)
//     {

//         sum = sum + 0;

//     }   
//     else
//     {
//         sum = sum + array[i];
//     }

// }
// Console.WriteLine();
// Console.WriteLine($"сумма элемонтов на нечетных позициях = {sum}");




// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = new double[5];

// double maxNum = double.MaxValue;
// double minNum = double.MinValue;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = (new Random().NextDouble()+ new Random().Next(10,90));
//     System.Console.Write(array[i] + " ");

  
//     if(array[i] > maxNum)
//     {
//         maxNum= array[i];
//     }
//     else if (array[i]<minNum)
//     {
//         minNum= array[i];

//     }
// }
// double result = maxNum - minNum;
// System.Console.WriteLine("Cумма = " + result);









