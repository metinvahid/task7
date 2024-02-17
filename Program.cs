using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var ci = new CultureInfo("az");
            Thread.CurrentThread.CurrentCulture = ci;
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task7();
            Task8();
            Task9();
            Task10();
            Task11();
            Task12();



        }

        static void Task1()
        {
            Console.WriteLine("Neçə elementli massiv yaratmaq istəyirsiniz");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];


            Console.WriteLine("Massivin elementlərini daxil edin");
            Console.WriteLine(" ");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Massivin{i + 1}-ni daxil edin ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Massivin limitini daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Cavab");
            foreach (int i in array)
            {
                if (i < c)
                {
                    Console.WriteLine(i);
                }

            }


        }
        static void Task2()
        {
            Console.WriteLine("Neçə elementli massiv yaratmaq istəyirsiniz");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];


            Console.WriteLine("Massivin elementlərini daxil edin");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Massivin{i + 1}-ni daxil edin ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Massivin limitini daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int count = 0;
            foreach (int i in array)
            {
                if (i < c)
                {
                    sum = sum + i;
                    count++;
                }

            }

            double result = (double)sum / count;

            Console.WriteLine(result);
        }
        static void Task3()
        {
            Console.WriteLine("Neçə elementli massiv yaratmaq istəyirsiniz?");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Massivin elementlərini daxil edin");

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Massivin{i + 1}-ni daxil edin");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Massivin limitini daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            int count = 0;
            foreach (int i in array)
            {
                sum = sum * i;
                // sum*= i;
                count++;
            }
            double result = (double)sum / count;
            Console.WriteLine(result);

        }

        static void Task4()
        {
            Console.WriteLine("Neçə elementli massiv yaratmaq istəyirsiniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Massivin elementlerini daxil edin");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Massivin{i + 1}-ni daxil edin ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Massivin limitini daxil edin");
            
            int c = Convert.ToInt32(Console.ReadLine());
            foreach (int i in array)
            {
                if(i>c)
                {
                    Console.WriteLine(i);

                }

                
            }
            Array.Sort(array);

        }
        static void Task5()
        {
            Console.WriteLine("5Neçə elementli massiv yaratmaq istəyirsiniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Massivin elementlerini daxil edin");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Massivin{i + 1}-ni daxil edin ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Massivin limitini daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Asaqida butun daxil olunmus massivler qeyd olunub \n");
            foreach (int i in array)
            {
                if (i < c)
                {
                    Console.WriteLine(i);

                }


            }
            Array.Sort(array);

            int maxNumber = array.Max();

          
            Console.WriteLine($"Daxil edilen massivlerden en boyuyu:{maxNumber}");
        }

        static void Task6()
        {

        }

        static void Task7()
        {
            Console.WriteLine("Neçe elementli massiv yaratmaq isteyirsiniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Console.WriteLine("Massivin elementlerini daxil edin");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Massivin{i + 1}-ni daxil edin ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Array.Sort(array);

            double maxNumber = array.Max();
            double minNumber = array.Min();

            double numavarage = (array.Max() + array.Min()) / 2;
            Console.WriteLine($" Ededi orta:{numavarage}");

            double len1 = 1.0 / 2;
            double result = Math.Pow(minNumber * maxNumber, len1);
            Console.WriteLine($"Hendesi orta{result}");

        }

            static void Task8()
            {

                int[] array1 = new int[14] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                int[] array2 = new int[14] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                int[] resultArray = new int[14];

                for (int i = 0; i < 14; i++)
                {
                    resultArray[i] = array1[i] * array2[i];
                }

                Console.WriteLine("New array:");
                foreach (int item in resultArray)
                {
                    Console.Write(item + " ");
                }



            }

        static void Task9()
        {
            int[] array1 = new int[25];
            int[] array2 = new int[8];
            int[] array3 = new int[17];

            for (int i = 0; i < 8; i++)
            {
                array2[i] = array1[i] * array1[i];
            }

            for (int i = 8; i < array1.Length; i++)
            {
                array3[i - 8] = array1[i] / 4;
            }

            Console.WriteLine("Kvadrat Massiv:");
            PrintArray(array2);

            Console.WriteLine("\nBolunmus Massiv:");
            PrintArray(array3);


        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

        }

        static void Task10()
        {
            int[] X = { 10, -7, 5, -13, 8, -6 };

            int maxNegativ = FindMaxNegative(X);
        }
        static int FindMaxNegative(int[] arr)
        {
            int maxNegativ = Int32.MinValue;

            foreach (int num in arr)
            {
                if (num < 0 && num > maxNegativ)
                {
                    maxNegativ = num;
                }
            }

            return maxNegativ;

        }

        static void Task11()
        {

            Random rnd = new Random();
            Console.Write("len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[len];
            for (int i = 0; i < 10; i++)
            {
                x[i] = Convert.ToInt32(rnd.Next(0, 100));

                Array.Sort(x);
                Array.Reverse(x);
                Console.WriteLine(x[i]);

            }
        } 
        static void Task12() 
        {
            int[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int half = X.Length / 2;
            double count = 0;
            double count2 = 1;
            for (int i = 0; i < half; i++)
            {
                count += X[i];
            }
            count /= half;
            Console.WriteLine(count);
            for (int i = 11; i < 20; i++)
            {
                count2 *= X[i];
            }
            Console.WriteLine(count2);


            double geometricMean = Math.Pow(count2, 0.1);


            Console.WriteLine(geometricMean);
        }


}






}
    
