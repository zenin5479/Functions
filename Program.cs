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
         int st = 1;
         while (i <= b)
         {
            st *= a;
            i++;
         }
         Console.WriteLine("Число " + a + " в степени " + b + " = " + st);

         Console.WriteLine("-----------------------");
         Console.WriteLine("Сумма цифр целого числа");
         Console.WriteLine("-----------------------");

         Console.WriteLine("Введите число N: ");
         int n = Convert.ToInt32(Console.ReadLine());
         int sum = Math.Abs(n);
         int count = 0;

         while (sum > 0)
         {
            int num = sum - sum / 10 * 10;
            sum = sum / 10;
            count += num;
         }

         Console.WriteLine("Сумма цифр в числе " + n + " = " + count);

         Console.WriteLine("------------------------------------------------");
         Console.WriteLine("Массив случайных чисел отсортированный по модулю");
         Console.WriteLine("------------------------------------------------");
         Console.WriteLine("Введите нижнюю границу диапазона случайных чисел: ");
         int value1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите верхнюю границу диапазона случайных чисел: ");
         int value2 = Convert.ToInt32(Console.ReadLine());
         int[] array = new int[8];
         MethodFillArray(array, value1, value2);
         // Метод заполнения массива случайными числами
         void MethodFillArray(int[] arrays, int value_1, int value_2)
         {
            int index = 0;
            while (index < arrays.Length)
            {
               arrays[index] = new Random().Next(value_1, value_2);
               index++;
            }
         }

         // Метод распечатки элементов массива
         void PrintArray(int[] arra)
         {
            int length = arra.Length;
            for (int rv = 0; rv < length; rv++)
            {
               Console.Write($"{arra[rv]}  ");
            }
            Console.WriteLine();
         }

         Console.WriteLine("Исходный массив");
         PrintArray(array);
         // Метод сортировки элементов массива от минимального значения к максимальному по модулю
         void SelectionSort(int[] ar)
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
         Console.WriteLine("Отсортированный по модулю от минимального к максимальному");
         PrintArray(array);

         Console.WriteLine("---------------------------------------------------------------------------");
         Console.WriteLine("Проверка натурального десятичного числа на палиндромность в двоичной записи");
         Console.WriteLine("---------------------------------------------------------------------------");

         Console.Write("Введите десятичное число: ");
         int number = Convert.ToInt32(Console.ReadLine());
         // Метод перевода десятичного числа в двоичный
         void Dvcod(int figure)
         {
            int num = figure;
            string dvFigura1 = "";
            while (figure >= 1)
            {
               dvFigura1 = dvFigura1 + Convert.ToString(figure % 2);
               figure = figure / 2;
            }
            int l = dvFigura1.Length;
            // Преобразовать строку в символьный массив, затем выполнить реверсирование массива и этот массив преобразовать в строку
            char[] sDvFigura = dvFigura1.ToCharArray();
            // Символьный массив для перевернутого числа
            char[] sDvFigura1 = new char[l];
            int j = l;
            // Цикл для переворота числа 
            for (int lx = 0; lx < l; lx++)
            {
               j = j - 1;
               sDvFigura1[j] = sDvFigura[lx];
            }
            string dvFigura2 = new string(sDvFigura1);

            if (dvFigura1 == dvFigura2)
            {
               Console.WriteLine("Десятичное число " + num + " = двоичному числу " + dvFigura2 + " - полиндром");
            }
            else
            {
               Console.WriteLine("Десятичное число " + num + " = двоичному числу " + dvFigura2 + " - не полиндром");
            }
         }

         Dvcod(number);


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
         value1 = 1;
         value2 = 99;
         int[] array1 = new int[100];
         // Метод заполнение массива
         MethodFillArray(array1, value1, value2);
         // Метод распечатки массивыа выше прописан
         PrintArray(array1);
         Selectionnum(array1);
         // Метод сортировки элементов массива от минимального значения к максимальному по модулю
         void Selectionnum(int[] arrayN)
         {
            int l = arrayN.Length;
            int kolMax = 1;
            int numArray = arrayN[0];
            for (int rd = 0; rd < l - 1; rd++)
            {
               int max = 1;
               for (int j = rd + 1; j < l; j++)
               {
                  if (arrayN[rd] == (arrayN[j])) max++;
               }

               if (max > kolMax)
               {
                  kolMax = max;
                  numArray = arrayN[rd];
               }
            }

            for (int sr = 0; sr < l - 1; sr++)
            {
               int counter = 1;
               for (int j = sr + 1; j < l; j++)
               {
                  if (arrayN[sr] == (arrayN[j])) counter++;
               }
               if (counter == kolMax)
               {
                  Console.WriteLine("Максимальное количество элементов массива c значением " + arrayN[sr] + " =  " + kolMax);
               }
            }
         }

         Console.ReadKey();
      }
   }
}