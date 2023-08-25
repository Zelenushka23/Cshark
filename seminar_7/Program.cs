// задайте двумерный массив размером m*n 
// заполненный случайными целыми числами


// System.Console.WriteLine("Введите первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите вторую размерность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }


// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле Amn = m+n.
// выведите полученный массив на экран


// System.Console.WriteLine("Введите первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите вторую размерность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= i+j;
//         Console.Write(matrix[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }

// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// четные и измените эти элементы на их квадраты

// System.Console.WriteLine("Введите первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите вторую размерность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// System.Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i%2==0 && j%2==0 )
//         {
//             matrix[i,j]=  matrix[i,j]* matrix[i,j];
//         }
//         System.Console.Write(matrix[i,j] + " ");
//     } 
//     System.Console.WriteLine();
// }

// задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали( с индексами (0,0); (1,1))

// System.Console.WriteLine("Введите первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите вторую размерность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int sum = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j] + " ");

//           if(i==j)
//         {
//             // sum = sum + matrix[i,j];
//             sum+=matrix[i,j];
            
//         }
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("Cумма равна " + sum);














