// напишите программу. которая принимает на вход 
// число А и выдает сумму чисел от 1 до А

// тип переменной + Название +()

// Console.WriteLine("введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int GetSumNum();
// {
//     int sum =0;
//     int count =0;

//     while(count<=num)
//     {
//         sum = sum+count;
//         count++;

//     }
//     return sum;
// }
// int result = GetSumNum();
// Console.WriteLine(result);

// // Console.WriteLine(GetSumNum());

// напишите программу, которая принимает на вход число и 
// выдает количество цифр в числе

 

// int GetNum(int Num)
// {
//     int count;
//     if(num>0 && num<10)
//     {
//         count = 1;
//     }
//     else if ( num >=10 && num < 100)
//     {
//         count =2;
//     }
//      else if ( num >=101 && num < 1000)
//     {
//         count 3;
//     }
//      else if ( num >=1000 && num < 10000)
//     {
//         count =4;
//     }
//      else  ( num >=10000 && num < 100000)
//     {
//         count =5;
//     }
//     return count;
// }
// Console.WriteLine("введите число");
// int num= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetNum(num));

// Console.WriteLine("введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int GetCountNum()
// { int count = 0;
//     while(num>0)
//     {
//         num= num/10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine(GetCountNum());

// напишите программу, которая принимает на вход число 
// и выдает произведение чисел от 1 до N

// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetMultiply()
// { 
//     int multi = 1;

//     for(int i = 1; i <= num; i++)
//     {
//         multi=multi*i;
//     }
//     return multi;
// }
// Console.WriteLine(GetMultiply());

// Напишите программу, которая выводит массив, заполненный 0 и 1 в 
// случайном порядке

// int[] array = new int[8];
// GetArray();

// void GetArray()
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,2);
//         Console.Write(array[i]+" ");
//     }

// }

























// int NumCount(string num)
// {
//     int result = 0;
//     for(int i = 0; i < num.Length; i++)
//     {
//         int numSecond;
//         if(int.TryParse(num[i].ToString(), out numSecond))
//         {
//             result += numSecond;
//         }
//         else
//         {
//             Console.WriteLine("Ошибка! Введите число!");
//             return 0;
//         }
//     }
//      return result;
// }
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// Console.WriteLine(NumCount(num));