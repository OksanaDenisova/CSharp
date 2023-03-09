/* ДВУМЕРНЫЕ МАССИВЫ*/
/* 
Задача 1. Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
*/
 //цикл ведет по строкам и заполняет ее, переходит на новую когда внутренний цикл с j заполнил столбец
 // внешний за строку внутенний за столбец

 // Создали массив и зполнили рандомно

// int [,] CreateRandomArray2D()
// {   
//     Console.Write(" Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите максимальноу число запоения массива: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите минимальное число запоения массива: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows,columns];

//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<columns; j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }

// // Вывели  массив пользователю
// void Show2dArray(int [,]array )
// {
//      for(int i = 0; i< array.GetLength(0); i++)
//      {
//         for(int j = 0; j< array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//      }
//      Console.WriteLine();
// }


// int[,] newArray = CreateRandomArray2D();
// Show2dArray(newArray);

//ЗАДАЧА 2
// Задайте двумерный массив размера m х n, 
// каждый элемент в массиве находится по формуле: Aij = i + j. 
// Выведите полученный массив на экран.
// метод генерирующий 

// int [,] CreateArray(int rows, int columns)
// {
//     int [,] array = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//         for(int j =0; j< columns;j++)
//         {
//             array[i,j] = i+j;
//         }
//     return array;
// }

// void Show2dArray(int [,]array)
// {
//      for(int i = 0; i< array.GetLength(0); i++)
//      {
//         for(int j = 0; j< array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//      }
//      Console.WriteLine();
// }

// Console.Write(" Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateArray(rows,columns);
// Show2dArray(newArray);


// ЗАДАЧА 3
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// преобразующий метод 

// int [,] CreateRandomArray2D()
// {   

//      Console.Write(" Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите максимальноу число запоения массива: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите минимальное число запоения массива: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());


//     int[,] array = new int[rows,columns];

//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<columns; j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }

// void Show2dArray(int [,]array)
// {
//      for(int i = 0; i< array.GetLength(0); i++)
//      {
//         for(int j = 0; j< array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//      }
//      Console.WriteLine();
// }


// int [,] ChangeArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i+=2)
//         for(int j =0; j< array.GetLength(1);j+=2)
//         {
//             array[i,j] *=array[i,j];
//         }
//     return array;
// }

// int [,] newArray = CreateRandomArray2D();
// Show2dArray(newArray);
// ChangeArray(newArray);
// Show2dArray(newArray);

// ЗАДАЧА 4
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// аналитический метод


// int [,] CreateRandomArray2D()
// {   

//      Console.Write(" Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите максимальноу число запоения массива: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите минимальное число запоения массива: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());


//     int[,] array = new int[rows,columns];

//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<columns; j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }

// void Show2dArray(int [,]array)
// {
//      for(int i = 0; i< array.GetLength(0); i++)
//      {
//         for(int j = 0; j< array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//      }
//      Console.WriteLine();
// }


// int GetSumDiagonal(int[,] array)
// {
//     int result = 0;
//     for(int i = 0; i < array.GetLength(0)&& i < array.GetLength(1); i++)
//     {
//         result += array[i,i];
//     }
//     return result;
// }


// int[,] newArray = CreateRandomArray2D();
// Show2dArray(newArray);
// Console.WriteLine(GetSumDiagonal(newArray));
