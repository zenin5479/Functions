using System;

// Функции
// Задача: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B
// Задача: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Задача: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив
// Задача: На вход подаётся натуральное десятичное число
// Проверьте, является ли оно палиндромом в двоичной записи
// Задача: Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц
// Размер массива должен совпадать с квадратом количества единиц в нём
// Задача: Массив на 100 элементов задаётся случайными числами от 1 до 99
// Определите самый часто встречающийся элемент в массиве
// Если таких элементов несколько, вывести их все

// Объяснение
// Определение k: С помощью Random.Next(1, 101) генерируем случайное число от 1 до 100, которое определяет количество единиц.
// Размер массива: Вычисляем размер массива n как квадрат k, что гарантирует выполнение условия задачи.
// Заполнение массива: Сначала массив заполняется k единицами в начале, а остальные элементы остаются нулями.
// Затем массив перемешивается алгоритмом Фишера-Йейтса для достижения случайного порядка элементов.
// Это обеспечивает равномерное распределение единиц и нулей в массиве.

namespace Functions
{
   internal class Program
   {
      static void Main()
      {
         // Задача: Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц
         // Размер массива должен совпадать с квадратом количества единиц в нём
         // Количество единиц (от 1 до 100)
         Random random = new Random();
         int k = random.Next(1, 101);
         // Размер массива
         int n = k * k;
         int[] arr = new int[n];

         // Заполняем массив k единицами и остальными нулями
         for (int rx = 0; rx < k; rx++)
         {
            arr[rx] = 1;
         }

         // Перемешиваем массив для случайного порядка
         for (int rz = arr.Length - 1; rz >= 1; rz--)
         {
            int j = random.Next(rz + 1);
            // Обмен элементов
            int temp = arr[rz];
            arr[rz] = arr[j];
            arr[j] = temp;
         }

         Console.WriteLine("-------------------------------------------");
         Console.WriteLine("Возведение натурального числа А в степень B");
         Console.WriteLine("-------------------------------------------");
         Console.Write("Введите натуральное число А: ");
         int A = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите натуральное число B: ");
         int B = Convert.ToInt32(Console.ReadLine());
         int i = 1;
         int St = 1;
         while (i <= B)
         {
            St = St * A;
            i++;
         }
         Console.WriteLine(A + " в степени " + B + " = " + St);

         Console.WriteLine("-------------------------------------------------------------------------------");
         Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");
         Console.WriteLine("-------------------------------------------------------------------------------");

         Console.WriteLine("Введите число N ");
         int N = Convert.ToInt32(Console.ReadLine());
         int Sum = Math.Abs(N);
         int count = 0;

         while (Sum > 0)
         {
            int num = Sum - Sum / 10 * 10;
            Sum = Sum / 10;
            count += num;
         }

         Console.WriteLine("сумма цифр в числе  " + N + " = " + count);

         Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
         Console.WriteLine(" Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
         Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
         Console.WriteLine("введите диапозон случайных чисел ");
         int value1 = Convert.ToInt32(Console.ReadLine());
         int value2 = Convert.ToInt32(Console.ReadLine());

         int[] array = new int[8];
         MethodFillArray(array, value1, value2);

         void MethodFillArray(int[] arrays, int value_1, int value_2)                         // метод заполнения массива случайными числами
         {
            int index = 0;
            while (index < arrays.Length)
            {
               arrays[index] = new Random().Next(value_1, value_2);
               index++;
            }
         }

         void PrintArray(int[] arra)                                // метод распечатки элементов массива
         {
            int length = arra.Length;
            for (int rv = 0; rv < length; rv++)
            {
               Console.Write($"{arra[rv]}  ");
            }
            Console.WriteLine();
         }

         Console.WriteLine("исходный массив");
         PrintArray(array);

         void SelectionSort(int[] ar)                         // метод сортировки элементов массива от мин значения к максимальному по модулю
         {
            for (int px = 0; px < ar.Length - 1; px++)
            {
               int minPosition = px;

               for (int j = px + 1; j < ar.Length; j++)
               {
                  if (Math.Abs(ar[j]) < Math.Abs(ar[minPosition])) minPosition = j;
               }

               int temporary = ar[px];
               ar[px] = ar[minPosition];
               ar[minPosition] = temporary;
            }
         }

         SelectionSort(array);
         Console.WriteLine("------------------------------------------------------");
         Console.WriteLine("отсортированный по модулю от минимального к максимальному");
         PrintArray(array);

         // Дополнительные задания
         Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
         Console.WriteLine(" Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.");
         Console.WriteLine(" --------------------------------------------------------------------------------------------- ");

         Console.WriteLine("Введите десятичное число ");
         int number = Convert.ToInt32(Console.ReadLine());
         void Dvcod(int figure)                                       // метод перевода десятичного числа в двоичный
         {
            int num = figure;
            string DvFigura1 = "";
            while (figure >= 1)
            {
               DvFigura1 = DvFigura1 + Convert.ToString(figure % 2);
               figure = figure / 2;
            }
            int L = DvFigura1.Length;
            char[] sDvFigura = DvFigura1.ToCharArray();                     // преобразовать строку в символьный массив, затем выполнить реверсирование массива и этот массив преобразовать в строку.
            char[] sDvFigura1 = new char[L];                     // символьный массив для перевернутого числа
            int j = L;
            for (int lx = 0; lx < L; lx++)                         // цикл для переворота числа 
            {
               j = j - 1;
               sDvFigura1[j] = sDvFigura[lx];
            }
            string DvFigura2 = new string(sDvFigura1);

            if (DvFigura1 == DvFigura2)
            {
               Console.WriteLine("десятичное число " + num + " = двоичному числу " + DvFigura2 + " - полиндром");
            }
            else
            {
               Console.WriteLine("десятичное число " + num + " = двоичному числу " + DvFigura2 + " - не полиндром");
            }
         }

         Dvcod(number);

         Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
         Console.WriteLine(" Задача 3. Массив на 100 элементов задается случайными числамит от 1 до 99. Определите самый часто встречающиййся элемент в массиве. Если их несколько - вывести все.");
         Console.WriteLine(" --------------------------------------------------------------------------------------------- ");
         value1 = 1;
         value2 = 99;
         int[] array1 = new int[100];
         MethodFillArray(array1, value1, value2);          // метод заполнение массива (выше прописан)
         PrintArray(array1);                                // метод распечатки массивыа выше прописан
         Selectionnum(array1);
         void Selectionnum(int[] arrayN)                         // метод сортировки элементов массива от мин значения к максимальному по модулю
         {
            int L = arrayN.Length;
            int kolMax = 1;
            int numArray = arrayN[0];
            for (int rd = 0; rd < L - 1; rd++)
            {
               int max = 1;
               for (int j = rd + 1; j < L; j++)
               {
                  if (arrayN[rd] == (arrayN[j])) max++;
               }

               if (max > kolMax)
               {
                  kolMax = max;
                  numArray = arrayN[rd];
               }
            }

            for (int sr = 0; sr < L - 1; sr++)
            {
               int counter = 1;
               for (int j = sr + 1; j < L; j++)
               {
                  if (arrayN[sr] == (arrayN[j])) counter++;
               }
               if (counter == kolMax)
               {
                  Console.WriteLine("макс кол элементов массива c знвчением " + arrayN[sr] + " =  " + kolMax);
               }
            }
         }

         Console.ReadKey();
      }
   }
}