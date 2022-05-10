using System;
using LibrarySorts;
using System.Diagnostics;
namespace ConsoleAppSorts

{
    internal class Program
    {
        const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите команду:");
                Console.WriteLine("1.Сортировка пузырьком");
                Console.WriteLine("2.Сортировка вставками");
                Console.WriteLine("3.Сортировка слиянием");
                Console.WriteLine("4.Сортировка бысрая");
                Console.WriteLine("5.выход");
                string choose = Console.ReadLine();
                if(choose == "1")Bubbletest();
                else if(choose == "2")InsertTest();
                else if(choose == "3")MergeTest();
                else if (choose == "4") Quicktest();
                else if(choose == "5")return;
                else Console.WriteLine("Нет такой команды!");




            }



        }
        static void Bubbletest()
        {
            Stopwatch st = new Stopwatch();
            
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = Console.ReadLine(); ;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.BubbleSort(Numbers);                
                else
                {
                    Sorts.BubbleSort(Numbers);
                    Array.Reverse(Numbers);
                }
                st.Stop();
                for (int i = 0; i < Numbers.Length; i++)
                {
                    wor += Numbers[i] + " ";
                }
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            Console.WriteLine("Вы ввели неправильный символ.Мы сортируем либо числа либо строки.");
                            return;
                        }

                    }
                }
                long[] num = Sorts.arrayer(values);
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.BubbleSort(num);
                else
                {
                    Sorts.BubbleSort(num);
                    Array.Reverse(num);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                wor = String.Join(" ", res);
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }

        }
        static void Quicktest()
        {
            Stopwatch st = new Stopwatch();            
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = Console.ReadLine(); ;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            { 
                if (!int.TryParse(value, out int M)) sort = false;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.Quicksort(Numbers);
                else
                {
                    Sorts.Quicksort(Numbers);
                    Array.Reverse(Numbers);
                }
                st.Stop();
                for (int i = 0; i < Numbers.Length; i++)
                {
                    wor += Numbers[i] + " ";
                }
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            Console.WriteLine("Вы ввели неправильный символ.Мы сортируем либо числа либо строки.");
                            return;
                        }

                    }
                }
                long[] num = Sorts.arrayer(values);
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.Quicksort(Numbers);
                else
                {
                    Sorts.Quicksort(Numbers);
                    Array.Reverse(Numbers);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                wor = String.Join(" ", res);
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
        }
        static void InsertTest()
        {
            Stopwatch st = new Stopwatch();
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = Console.ReadLine(); ;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.InsertionSort(Numbers);
                else
                {
                    Sorts.InsertionSort(Numbers);
                    Array.Reverse(Numbers);
                }
                st.Stop();
                for (int i = 0; i < Numbers.Length; i++)
                {
                    wor += Numbers[i] + " ";
                }
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            Console.WriteLine("Вы ввели неправильный символ.Мы сортируем либо числа либо строки.");
                            return;
                        }

                    }
                }
                long[] num = Sorts.arrayer(values);
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.InsertionSort(Numbers);
                else
                {
                    Sorts.InsertionSort(Numbers);
                    Array.Reverse(Numbers);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                wor = String.Join(" ", res);
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
        }
        static void MergeTest()
        {
            Stopwatch st = new Stopwatch();
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = Console.ReadLine(); ;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.MergeSort(Numbers);
                else
                {
                    Sorts.MergeSort(Numbers);
                    Array.Reverse(Numbers);
                }
                st.Stop();
                for (int i = 0; i < Numbers.Length; i++)
                {
                    wor += Numbers[i] + " ";
                }
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            Console.WriteLine("Вы ввели неправильный символ.Мы сортируем либо числа либо строки.");
                            return;
                        }

                    }
                }
                long[] num = Sorts.arrayer(values);
                Console.WriteLine("По возрастанию или убыванию(+ и - соответственно)");
                string r = Console.ReadLine();
                st.Start();
                if (r == "+") Sorts.MergeSort(Numbers);
                else
                {
                    Sorts.MergeSort(Numbers);
                    Array.Reverse(Numbers);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                wor = String.Join(" ", res);
                Console.WriteLine("Время выполнения:" + st.Elapsed.TotalSeconds);
                Console.WriteLine(wor);
            }
        }
        
    }
}
