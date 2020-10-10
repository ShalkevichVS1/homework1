using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Начальный вклад в банке равен 1000 руб.
            Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы. 
            По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., 
            и вывести найденное количество месяцев K и итоговый размер вклада S.*/


            double sum = 1000;
            Console.WriteLine("Какой % прироста?");
            double P = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            do
            {
                sum *= (P / 100 + 1);
                count++;
            }
            while (sum < 1100);

            int result = (int)sum;

            Console.WriteLine("Через " + count + " месяцев вклад составит " + sum + " рублей.\nЕсли округлить, то " + result);
        }
        static void Main2(string[] args)
        {
            /*
             2. Даны целые положительные числа A и B (A<B). Вывести все целые числа от А до В
             включительно; каждое число должно выводиться на новой строке; при этом
             каждое число должно выводиться количество раз, равное его значению.
             Например: А = 3; B = 7
             333
             4444
             55555
             666666
             7777777
             */
            Console.WriteLine("Ввелите 2 числа, 1<2");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = (b - a);
            for (int i = 0; i <= c; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (a > j)
                    {
                        Console.Write(a);
                    }
                }
                a++;
                Console.WriteLine();
            }
        }

        static void Main3(string[] args)
        {
            /*
             3. Число в обратном порядке
             Напр: 345 -> 543
             */
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
            Console.WriteLine();
        }

        static void Main4(string[] args)
        {
            /*
             * 4. Дано целое число в диапазоне 100–999. 
             * Вывести строку-описание данного числа, 
             * например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать»
             */
            Console.WriteLine("Input a value:");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n / 100)
            {
                case 1: Console.Write("сто "); break;
                case 2: Console.Write("двести "); break;
                case 3: Console.Write("триста "); break;
                case 4: Console.Write("четыреста "); break;
                case 5: Console.Write("пятьсот "); break;
                case 6: Console.Write("шестьсот "); break;
                case 7: Console.Write("семьсот "); break;
                case 8: Console.Write("восемьсот "); break;
                case 9: Console.Write("девятьсот "); break;
            }
            if ((((n / 10) % 10) != 1) && ((n % 10) != 0))
            {
                switch ((n / 10) % 10)
                {

                    case 2: Console.Write("двадцать "); break;
                    case 3: Console.Write("тридцать "); break;
                    case 4: Console.Write("сорок "); break;
                    case 5: Console.Write("пятьдесят "); break;
                    case 6: Console.Write("шестьдесят "); break;
                    case 7: Console.Write("семьдесят "); break;
                    case 8: Console.Write("восемьдесят "); break;
                    case 9: Console.Write("девяносто "); break;
                }
                switch (n % 10)
                {
                    case 1: Console.Write("один "); break;
                    case 2: Console.Write("два "); break;
                    case 3: Console.Write("три "); break;
                    case 4: Console.Write("четыре "); break;
                    case 5: Console.Write("пять "); break;
                    case 6: Console.Write("шесть "); break;
                    case 7: Console.Write("семь "); break;
                    case 8: Console.Write("восемь "); break;
                    case 9: Console.Write("девятьт "); break;
                }
            }

            else if ((n % 10) == 0)
            {
                switch ((n / 10) % 10)
                {
                    case 1: Console.Write("десять "); break;
                    case 2: Console.Write("двадцать "); break;
                    case 3: Console.Write("тридцать "); break;
                    case 4: Console.Write("сорок "); break;
                    case 5: Console.Write("пятьдесят "); break;
                    case 6: Console.Write("шестьдесят "); break;
                    case 7: Console.Write("семьдесят "); break;
                    case 8: Console.Write("восемьдесят "); break;
                    case 9: Console.Write("девяносто "); break;
                }
            }

            else
            {
                switch (n % 10)
                {
                    case 1: Console.Write("одиннадцать "); break;
                    case 2: Console.Write("двенадцать "); break;
                    case 3: Console.Write("тринадцать "); break;
                    case 4: Console.Write("четырнадцать "); break;
                    case 5: Console.Write("пятнадцать "); break;
                    case 6: Console.Write("шестьнадцать "); break;
                    case 7: Console.Write("семьнадцать "); break;
                    case 8: Console.Write("восемьнадцать "); break;
                    case 9: Console.Write("девятнадцать "); break;
                }
            }

            Console.WriteLine();
        }

        static void Main5(string[] args)
        {
            //1.Определить, есть ли среди первых четырех цифр 
            //дробной части заданного положительного вещественного числа, цифра 5.

            double n = 34.4457839;
            int count = 0;
            int k = 0;
            do
            {
                n *= 10;
                int b = (int)n % 10;
                if (b == 5)
                {
                    Console.WriteLine("Yes!");
                    break;
                }
                else
                {
                    k++;
                }
                count++;
            }
            while (count != 4);
            if (k == 4)
            {
                Console.WriteLine("No!");
            }
        }

        static void Main6(string[] args)
        {
            //2.Определить число, полученное выписыванием в обратном порядке цифр
            // четырехзначного натурального числа n.

            Random rnd = new Random();
            int value = rnd.Next(1000, 9999);
            Console.WriteLine(value);
            while (value > 0)
            {
                Console.Write(value % 10);
                value /= 10;
            }
            Console.WriteLine();

        }
        static void Main7(string[] args)
        {
            //3. Дано четырехзначное натуральное n. 
            // Верно ли, что это число содержит ровно две цифры 7?

            int n = 1477;
            int count = 0;
            while (n > 0)
            {
                int a = n % 10;
                if (a == 7)
                {
                    count++;
                }
                n /= 10;
            }
            if (count == 2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void Main8(string[] args)
        {
            //4. Найдите сумму первых n натуральных чисел, 
            //которые делятся на 3 без остатка.

            Console.WriteLine("Сколько чисел, которые делятся на 3 без остатка, \nхотите сложить?");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int i = 1;
            while (count != n)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    count++;
                }
                i++;
            }
            Console.WriteLine("Sum " + n + " = " + sum);
        }
        static void Main9(string[] args)
        {
            //5. Дано натуральное число n. Получить все его натуральные делители.
            Random rnd = new Random();
            int value = rnd.Next(1, 100);
            Console.WriteLine(value);
            Console.WriteLine("Число " + value + " имеет делители: ");
            for (int i = 1; i <= value; i++)
            {
                if ((value % i) == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main10(string[] args)
        {
            //6. Даны натуральные числа n, m. Получить их общие делители.

            Random rnd = new Random();
            int m = rnd.Next(1, 100);
            int n = rnd.Next(1, 100);
            int max = 0; int min = 0;
            if (n > m)
            { max = n; min = m; }
            else
            { max = m; min = n; }
            Console.WriteLine(m + " и " + n + " имеют общие делители: ");
            for (int i = 1; i <= min; i++)
            {
                if (((min % i) == 0) && ((max % i) == 0))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main11(string[] args)
        {
            //7. Даны натуральные числа m, n. Получить все натуральные числа меньшие
            //n, квадрат суммы цифр которых равен m.

            int m = 36; int n = 11;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                int a = i;
                do
                {
                    sum += a % 10;
                    a /= 10;
                } while (a > 0);

                if (m == sum * sum)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main12(string[] args)
        {
            //1. Даны вещественные x1, x2, x3, x4. Поменять значения 
            //переменных так, чтобы x1 < x2 > x3 > x4 .
            Random rnd = new Random();
            int x1 = rnd.Next(1, 100);
            int x2 = rnd.Next(1, 100);
            int x3 = rnd.Next(1, 100);
            int x4 = rnd.Next(1, 100);
            int temp;
            Console.WriteLine(x1 + " " + x2 + " " + x3 + " " + x4);
            do
            {
                if (x1 > x2)
                {
                    temp = x1;
                    x1 = x2;
                    x2 = temp;
                }
                if (x2 < x3)
                {
                    temp = x2;
                    x2 = x3;
                    x3 = temp;
                }
                if (x3 < x4)
                {
                    temp = x3;
                    x3 = x4;
                    x4 = temp;
                }
            } while ((x1 > x2) || (x2 < x3) || (x3 < x4));
            Console.WriteLine(x1 + " < " + x2 + " > " + x3 + " > " + x4);
        }

        static void Main13(string[] args)
        {
            //2. Дано натуральное n. Определить, является ли это число палиндромом.

            Console.WriteLine(dream(212));
            Console.WriteLine(dream(2121));
            Console.WriteLine(dream(21212));
        }
        static string dream(int num1)
        {
            int num2 = 0;
            int temp = num1;
            while (temp > 0)
            {
                num2 = num2 * 10 + (temp % 10);
                temp /= 10;
            }
            if (num1 == num2)
            { return "Yes"; }
            else
            { return "No"; }
        }

        static void Main14(string[] args)
        {
            //3. Определить, равна ли сумма первых k цифр дробной части 
            //заданного положительного вещественного числа сумме n следующих цифр.
            int k = 2; int n = 5;
            double a = 2.2511113453;
            int sum1 = 0; int sum2 = 0;
            int c = k + n;
            for (int i = 0; i < c; i++)
            {
                a *= 10;
                int e = (int)a % 10;
                if (i < k)
                { sum1 += e; }
                else
                { sum2 += e; }
            }
            if (sum1 == sum2)
            { Console.WriteLine("Yes"); }
            else
            { Console.WriteLine("No"); }
        }
        static void Main15(string[] args)
        {
            //4. Среди всех четырехзначных чисел получить все простые числа, 
            //у каждого из которых сумма первых двух цифр равна сумме двух последних цифр.
            int sum1 = 0; int sum2 = 0;
            int i = 1000;
            while (i <= 9999)
            {
                int a = (i % 10);
                int b = ((i / 10) % 10);
                int c = ((i / 100) % 10);
                int d = ((i / 1000) % 10);
                sum1 = a + b;
                sum2 = c + d;
                if (sum1 == sum2)
                { Console.WriteLine(i); }
                i++;
            }
        }
        static void Main16(string[] args)
        {
            //5. Выполнить задание без хранения последовательности значений. 
            //Вводится последовательность целых чисел. Определить количество 
            //элементов в наиболее длинной подпоследовательности подряд идущих чисел, порядоченных по убыванию.

            Console.WriteLine("Сколько хотите чисел в последовательности? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(20);
                Console.Write(array[i] + " ");
            }

            int count = 1;
            int e = 1;
            for (int i = 0; i < (n - 1); i++)
            {
                if (array[i] > array[i + 1])
                {
                    count++;

                    if (e < count)
                    {
                        e = count;
                    }
                }
                else
                    count = 1;
            }
            Console.WriteLine();
            Console.WriteLine(e);
            Console.ReadKey();
        }

        static void Main17(string[] args)
        {
            //6. Поле шахматной доски определяется парой натуральных чисел, каждое из которых не превосходит 8: 
            //первое – номер вертикали, второе – номер горизонтали. 

            //Заданы натуральные числа k, l, m, n.

            //Можно ли с поля(k, l) одним ходом слона попасть на поле(m, n)? 
            //Если нет, выяснить, как это можно сделать за два хода.
            int k = 3; int l = 1; //начальная точка
            int m = 5; int n = 7; //проверочная точка

            if (Math.Abs(k - m) == Math.Abs(l - n))
            {
                Console.WriteLine("Yes. You need 1 step!");
            }
            else
            {
                for (int i = 1; i <= 8; i++)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        if (Math.Abs(k - i) == Math.Abs(l - j))
                        {
                            k = i;
                            l = j;
                            if (Math.Abs(k - m) == Math.Abs(l - n))
                            {
                                Console.WriteLine("Yes. You need 2 step!");
                                Console.WriteLine("You need stay " + k + " " + l + " and than " + m + " " + n);
                            }
                            k = 3; l = 1; //возвращаем начальной точке начальные данные
                        }
                    }
                }
            }
            
        }
    }
}
