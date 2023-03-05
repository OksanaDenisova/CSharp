/*методы,массивы
Задача 1. Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.*/
// int GetSum (int a)
// {
//     int sum = 0; // переменная куда записываем нащи данные//

//     for(int current = 1; current <= a; current++) //вместо  while записываем цикл таким образом и задаем несколько условий его существования//
//         sum += current;
//     return sum;
//     //пример с while:
//     // int current = 1;
//     // while (current<=a);         // их можно использовать в любом случае. то что удобнее то и бери
//     // {                              //
//     //     sum += current;
//     //     current++;
//     //}
// }
// Console.Write("Ввеите число: ");
// int number  = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(number);
// Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");

// ЗАДАЧА2.
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


// int Digits(int num)
// {
//     int digits = 0;
//     if(num == 0) digits = 1;
//     while (num != 0)
//     {
//         num /= 10;
//         digits++;
//     }
//     return digits;
// }
// Console.Write("Enter your number: ");
// int number  = Convert.ToInt32(Console.ReadLine());

// int dig = Digits(number);
// Console.WriteLine($"There are {dig} digits {number}");

// ЗАДАЧА 3
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Factorial (int num)
// {
//     int result = 1;
//     for(int current = 1; current <= num; current++)
//     {
//         result *= current;
//     }
//     return result;
// }
// Console.Write("Enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result =Factorial(number);

// Console.WriteLine($"Factorial of number {number} is {result}");

/* Массивы не выводятся через writeline.
метод который будет генерировать массив и заполнять его случайными числами*/

// назвать массив, в () указать переменную размера, органичить числа какие берет рандом от мин до мах
//[указать его ]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i ++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array [i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Минимально возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Максисально возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size,min,max);
// ShowArray(newArray);

