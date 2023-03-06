//ОДНОМЕРНЫЕ МАССИВЫ.
//
/* ЗАДАЧА 1. Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
преобразующий метод*/

 /* метод создающий радномный массив*/

// int[] CreateRandomArray(int size, int minValue, int maxValue)

// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i ++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// /* метод показывающий массив пользователю*/

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array [i] + " ");
//     Console.WriteLine();
// }

// /* метод который отвечает за разворот массива и его перезапись*/

// void ReversArray(int [] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// /* штуки которые запрашивают инфу по массиву у пользователя 
// и отправляют ее в метод*/

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Минимально возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Максисально возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size,min,max);
// ShowArray(newArray);
// ReversArray(newArray);
// ShowArray(newArray);

/* Задача 1 Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/
 
 /* Есди сумма двух других сторон тругольника равна одной из сторон то он не может существовать
 пишем код который проверяет это условие и выводит на экран информацию*/

// bool TriangeCheck(int a, int b, int c)
// {
//     return a<b+c && b< a+c && c<a+b;
// }

// Console.Write("Введите сторону а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввесдите сторону b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (TriangeCheck(a,b,c))
//     Console.WriteLine("Треугольник существует!");
// else
//     Console.WriteLine("Треугольник не существует");


/* ЗАДАЧА 2 Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b.

Фибоначчи это - числовые последовательности. Суть закона кахжый новый элемент формируется из
суммы двух предыдущих элементов ряда
0.1.1.2.3.5.8.13 - ряд Фибоначчи, бесконечный

обязательно в начале иметь два исходных числа. только ДВА.
Сформировать массив и вывести его обычным способом
*/

/* метод  создания массива и подсчета чисел в ряду */

// int[] Fibonacci(int n, int a, int b)
// {
//     int[] array = new int[n];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < n; i ++)
//         array[i] = array[i-1] + array[i-2];
//     return array;
// }

// /* метод показывающий массив пользователю*/

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array [i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите длину массива:");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввесдите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// ShowArray(Fibonacci(n,a,b));



/* ЗАДАЧА 3 Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
задаем массив  и копируем
массив будет возвращать и брать*/

// int [] CopyArray(int [] array)
// {
//     int[] newArray = new int[array.Length];
//     for(int i = 0; i< array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array [i] + " ");
//     Console.WriteLine();
// }

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i ++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }


// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Минимально возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Максисально возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] newArray = (CreateRandomArray(size,min,max));
// ShowArray(newArray);

// ShowArray(CopyArray(newArray));


/*ЗАДАЧА 4 (сложная)

Напишите программу, которая будет преобразовывать десятичное число в двоичное.
описать метод который берет обычный инт и возвращает двоичную форму этого числа 
использовать строку
вариант 1
*/

// string ConvertToBin(int number)
// {
//     string res="";
//     int remainder;
//     while (number > 0)
//         {
//             remainder = number % 2;
//             number = number / 2;

//             if (remainde > 0) res = "1" + res;
//             else res= "0" + res;
//         }
//     return res;
// }

// Console.Write("Введите десятичное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ConvertToBin(number));

// вариант 2

// string ConvertToBin(int number)
// {
//     string result = String.Empty;
//     while(number > 0)
//     {
//         result = number % 2 + result;
//         number = number / 2;
//     }
//     return result;
// }

// Console.Write("Введите десятичное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ConvertToBin(number));