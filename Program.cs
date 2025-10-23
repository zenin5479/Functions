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

namespace Functions
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("-------------------------------------------");
         Console.WriteLine("Возведение натурального числа А в степень B");
         Console.WriteLine("-------------------------------------------");
         Console.Write("Введите натуральное число А: ");
         int a = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите натуральное число B: ");
         int b = Convert.ToInt32(Console.ReadLine());
         int i = 1;
         int degree = 1;
         while (i <= b)
         {
            degree *= a;
            i++;
         }
         Console.WriteLine("Число " + a + " в степени " + b + " = " + degree);

         Console.WriteLine("-----------------------");
         Console.WriteLine("Сумма цифр целого числа");
         Console.WriteLine("-----------------------");
         Console.WriteLine("Введите число N: ");
         int c = Convert.ToInt32(Console.ReadLine());
         int amount = Math.Abs(c);
         int count = 0;
         while (amount > 0)
         {
            int digit = amount - amount / 10 * 10;
            amount /= 10;
            count += digit;
         }

         Console.WriteLine("Сумма цифр в числе " + c + " = " + count);

         Console.WriteLine("------------------------------------------------");
         Console.WriteLine("Массив случайных чисел отсортированный по модулю");
         Console.WriteLine("------------------------------------------------");
         Console.Write("Введите нижнюю границу диапазона случайных чисел: ");
         int lowerlimit = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите верхнюю границу диапазона случайных чисел: ");
         int upperlimit = Convert.ToInt32(Console.ReadLine());
         int[] sortedarray = new int[8];
         // Метод заполнения массива случайными числами
         void FillArray(int[] sorted, int lower, int upper)
         {
            int j = 0;
            while (j < sorted.Length)
            {
               sorted[j] = new Random().Next(lower, upper);
               j++;
            }
         }

         FillArray(sortedarray, lowerlimit, upperlimit);

         // Метод распечатки элементов массива
         void PrintArray(int[] solid)
         {
            int length = solid.Length;
            int k = 0;
            while (k < length)
            {
               Console.Write("{0} ", solid[k]);
               k++;
            }

            Console.WriteLine();
         }

         Console.WriteLine("Исходный массив");
         PrintArray(sortedarray);
         // Метод сортировки элементов массива от минимального значения к максимальному по модулю
         void SelectionSort(int[] mass)
         {
            int l = 0;
            while (l < mass.Length - 1)
            {
               int minPosition = l;
               int p = l + 1;
               while (p < mass.Length)
               {
                  if (Math.Abs(mass[p]) < Math.Abs(mass[minPosition])) minPosition = p;
                  p++;
               }

               int temporary = mass[l];
               mass[l] = mass[minPosition];
               mass[minPosition] = temporary;

               l++;
            }
         }

         SelectionSort(sortedarray);
         Console.WriteLine("Отсортированный по модулю от минимального к максимальному");
         PrintArray(sortedarray);

         Console.WriteLine("---------------------------------------------------------------------------");
         Console.WriteLine("Проверка натурального десятичного числа на палиндромность в двоичной записи");
         Console.WriteLine("---------------------------------------------------------------------------");
         Console.Write("Введите десятичное число: ");
         int decimalnumber = Convert.ToInt32(Console.ReadLine());
         // Метод перевода десятичного числа в двоичный
         void DecimalToBinary(int figure)
         {
            int num = figure;
            string decimalfigura = "";
            while (figure >= 1)
            {
               decimalfigura += Convert.ToString(figure % 2);
               figure /= 2;
            }

            int l = decimalfigura.Length;
            // Преобразовать строку в символьный массив, затем выполнить реверсирование массива и этот массив преобразовать в строку
            char[] binaryfigura = decimalfigura.ToCharArray();
            // Символьный массив для перевернутого числа
            char[] charfigura = new char[l];
            int j = l;
            // Цикл для переворота числа 
            int y = 0;
            while (y < l)
            {
               j -= 1;
               charfigura[j] = binaryfigura[y];
               y++;
            }

            string stringfigura = new string(charfigura);
            if (decimalfigura == stringfigura)
            {
               Console.WriteLine("Десятичное число " + num + " = двоичному числу" + stringfigura + " - полиндром");
            }
            else
            {
               Console.WriteLine("Десятичное число " + num + " = двоичному числу" + stringfigura + " - не полиндром");
            }
         }

         DecimalToBinary(decimalnumber);

         Console.WriteLine("-------------------------------------------");
         Console.WriteLine("Массив случайного количества нулей и единиц");
         Console.WriteLine("-------------------------------------------");
         Random сhance = new Random();
         int zero = сhance.Next(1, 100);
         // Размер массива
         int size = zero * zero;
         int[] massif = new int[size];
         // Заполняем массив единицами и нулями
         int r = 0;
         while (r < size)
         {
            bool divisionzero = r % zero == 0;
            if (divisionzero)
            {
               massif[r] = 1;
            }
            else
            {
               massif[r] = 0;
            }

            r++;
         }

         Console.WriteLine("Размер массива: {0}", size);
         Console.WriteLine("Количество единиц: {0}", zero);
         Console.WriteLine("Массив:");
         int t = 0;
         while (t < size)
         {
            Console.Write("{0} ", massif[t]);
            t++;
         }

         Console.WriteLine();

         Console.WriteLine("---------------------------------------------------");
         Console.WriteLine("Определение часто встречающихся элементов в массиве");
         Console.WriteLine("---------------------------------------------------");
         int low = 1;
         int high = 99;
         int[] tract = new int[100];
         // Метод заполнение массива
         FillArray(tract, low, high);
         // Метод распечатки массивыа выше прописан
         PrintArray(tract);
         // Метод сортировки элементов массива от минимального значения к максимальному по модулю
         void Selection(int[] massive)
         {
            int f = massive.Length;
            int limit = 1;
            int g = 0;
            while (g < f - 1)
            {
               int upper = 1;
               int s = g + 1;
               while (s < f)
               {
                  if (massive[g] == massive[s]) upper++;
                  s++;
               }

               if (upper > limit)
               {
                  limit = upper;
               }

               g++;
            }

            int q = 0;
            while (q < f - 1)
            {
               int register = 1;
               int w = q + 1;
               while (w < f)
               {
                  if (massive[q] == (massive[w])) register++;
                  w++;
               }

               if (register == limit)
               {
                  Console.WriteLine("Максимальное количество элементов массива c значением " + massive[q] + " =  " + limit);
               }

               q++;
            }
         }

         Selection(tract);

         Console.ReadKey();
      }
   }
}