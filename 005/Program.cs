/*ФУНКЦИИ И ОНОМЕРНЫЕ МАССИВЫ:

Методы которые работают с массива ми могут делиться на три категории:
1 генерирующие - формируют массив которого до этого не существовало
пример: new Random().Next( , );
2 аналитические - берут уже существующий массив и не меняют его, но на его онове
выполняют рассчеты
3 преобразующие - берет существующий массив и вносит в него изменения.

Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных элементов массива.
тут будет применен аналитический метод 
*/

/* метод создания массива*/

// int[] CreateRandomArray(int size, int minValue, int maxValue)

// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i ++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

/* метод показывающий массив пользователю*/

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array [i] + " ");
//     Console.WriteLine();
// }

/* метод ищет сумму негативных чисел в массиве*/

// int GetNegativSum(int [] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//         if(array [i] < 0)
//             sum += array[i];

//     return  sum;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Минимально возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Максисально возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size,min,max);
// ShowArray(newArray);
// int result = GetNegativSum (newArray);
// Console.WriteLine("Сумма максимальных значений равна" +  result);

// Задача 1
// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
//метод преобразующий на вход берет массив и изменяет его

// int [] ChangePosAndNeg (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//             array [i] *= -1;
//     return array;
// }

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

// int [] newArray = CreateRandomArray(12, -9, 9);
// ShowArray(newArray);

// ShowArray(ChangePosAndNeg(newArray));

// Задача 2
// Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
// аналитический метод булевый. на вход берем число которое потом проверяем в массиве

// bool FindNum(int[] array, int number)
// {
//     for( int i = 0; i < array.Length; i++)
//         if (array[i] == number)
//             return true;
//     return false;
// }

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

// Console.WriteLine(" Введите искомое число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateRandomArray(12, -9, 9);
// ShowArray(newArray);
// FindNum(newArray,number);


// Задача 3 Задайте одномерный массив из m случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// метод на вход берет массив и числа а и в и возвращает отрезок чисел 

// int HowManyNumbers( int [] array, int a, int b)
// {   int counter = 0;
//     for (int i = 0; i < array.Length; i ++)
//         if (array[i] >= a && array [i] <= b) counter ++;
//     return counter;
// }

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

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Минимально возможное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Максимально возможное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите первое число отрезка");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число отрезка");
// int b = Convert.ToInt32(Console.ReadLine());



// int [] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);
// int number = HowManyNumbers(newArray, a, b);
// Console.WriteLine($" Количество чисел отрезке от {a} до {b} равно  {number} ");

