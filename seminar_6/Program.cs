
// напишите программу, которая будет преобразовывать 
// десятичное число в двоичное

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while(num>0)
// {
//     result= num%2 +result;
//     num= num/2;
// }

// System.Console.WriteLine(result);

// 40. Напишите программу, которая принимает на вход 3 числа 
// и проверяет, может ли существовать треугольник такой длины

// System.Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1<num2+num3 && num2<num1+num3 && num3<num1+num2)
// {
//     System.Console.WriteLine("Yes");
// }
// else{
//     System.Console.WriteLine("нет");
// }



// Не используя рекурсию, выведите первые n чисел Фибоначчи.
// Первые 2 числа Фиббоначи: 0 и 1


// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;
// System.Console.WriteLine(firstNum);
// System.Console.WriteLine(secondNum);

// for (int i = 2; i < num; i++)
// {
//     int nextNum= firstNum +secondNum;
//     System.Console.WriteLine(nextNum);
//     firstNum= secondNum;
//     secondNum= nextNum;  
// }


// напишите программу, которая перевернет одномерные массив 
// (последний эдемент будет на первлм месте, а первый - на последнем)

// int[] array = new int[] {1,2,3,4,5,};

// void ReverseArray()
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i]= array[array.Length-1-i];
//         array[array.Length-1-i] = temp;
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }
// ReverseArray();
// PrintArray();




// напишите программу, которая будет создавать копию
//  заданного массива с помощью поэлементного копирования

// using System.Reflection.Metadata;

// int[] array = new int[] {1,2,3,4,52};
// int[] copyArray= new int [array.Length];

// void CopyArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         copyArray[i]= array[i];

//     }
// }

// void PrintCopyArray()
// {
//     for (int i = 0; i < copyArray.Length; i++)
//     {
//         System.Console.Write(copyArray[i]+ " ");
//     }
// }

// CopyArray();
// PrintCopyArray();

