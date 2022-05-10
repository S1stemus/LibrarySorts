using System;

namespace LibrarySorts
{
    public class Sorts
    {
        const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
        /// <summary>
        /// Пузырьковая сортировка. Алгоритм:
        /// последовательно сравниваются значения соседних элементов и меняют числа местами, 
        /// если предыдущее оказывается больше последующего. 
        /// Таким образом элементы с большими значениями оказываются в конце списка, 
        /// а с меньшими остаются в начале.
        /// Сложность по времени:O(n^2).
        /// </summary>
        /// <param name="M">Входной массив, который необходимо отсортировать</param>
        public static void BubbleSort(long[] M)
        {
            long t;
            int N = M.GetLength(0);
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (M[j] > M[j + 1])
                    {
                        t = M[j];
                        M[j] = M[j + 1];
                        M[j + 1] = t;

                    }
                }
            }
        }
        //сортировка вставками по возрастанию. Среднее время O(n^2)
        /// <summary>
        /// Сортировка вставками
        /// При сортировке вставками массив постепенно перебирается слева направо.
        /// При этом каждый последующий элемент размещается так, 
        /// чтобы он оказался между ближайшими элементами с минимальным и максимальным значением.
        /// Сложность по времени: O(n^2).
        /// </summary>
        /// <param name="M">массив, заданный для сортировки</param>
        public static void InsertionSort(long[] M)
        {
            long T;
            int N = M.GetLength(0);
            for (int i = 1; i < N; i++)
            {
                int j = i;
                while (M[j] < M[j - 1])
                {
                    T = M[j];
                    M[j] = M[j - 1];
                    M[j - 1] = T;
                    j--;
                    if (j == 0) break;
                }

            }



        }

        /// <summary>
        /// Быстрая сортировка
        /// разделении массива на два под-массива, средней линией считается элемент, 
        /// который находится в самом центре массива. В ходе работы алгоритма элементы, 
        /// меньшие чем средний будут перемещены в лево, а большие в право. 
        /// Такое же действие будет происходить рекурсивно и с под-массива, 
        /// они будут разделяться на еще два под-массива до тех пор, 
        /// пока не будет чего разделать (останется один элемент). 
        /// На выходе получим отсортированный массив. 
        /// Сложность по времени: O(n×logn)
        /// </summary>
        /// <param name="M"></param>
        public static void Quicksort(long[] M)
        {
            int N = M.GetLength(0);
            QuickSortRange(M, 0, N - 1);

        }
        /// <summary>
        /// Быстрая сортировка
        /// Рекурсивная функция, которая разбивает массив на под-массивы и сортирует их
        /// </summary>
        /// <param name="M">заданный массив</param>
        /// <param name="Left">Начальный индекс для сортировки</param>
        /// <param name="Right">Конечный индекс для сортировки</param>
        public static void QuickSortRange(long[] M, int Left, int Right)   //для возрастания
        {
            long t;
            int a = Left, b = Right;
            long p = M[(Left + Right) / 2];
            while (a < b)
            {
                while (M[a] < p)
                    a++;
                while (M[b] > p)
                    b--;
                if (a <= b)
                {
                    t = M[a];
                    M[a] = M[b];
                    M[b] = t;
                    a++;
                    b--;
                }
            }
            if (Left < b)
                QuickSortRange(M, Left, b);
            if (a < Right)
                QuickSortRange(M, a, Right);

        }
        public static void MergeSort(long[] M)
        {
            int N = M.GetLength(0);
            MergeSortRange(M, 0, N - 1);


        }
        /// <summary>
        /// Сортирока слиянием
        /// Здесь массив разбивается на две примерно равные части и каждая из них 
        /// сортируется по отдельности. Затем отсортированные подмассивы 
        /// сливаются в один.
        /// Сложность по времени:O(n×logn)
        /// </summary>
        /// <param name="M">Массив для сортировки</param>
        /// <param name="Left">Начальная граница</param>
        /// <param name="Right">Конечная граница</param>
        public static void MergeSortRange(long[] M, int Left, int Right)         //для возрастания
        {
            long t;
            if (Right - Left > 1)
            {

                int a1 = Left;
                int b1 = (Left + Right) / 2;
                int a2 = (Left + Right) / 2 + 1;
                int b2 = Right;
                MergeSortRange(M, a1, b1); //рекурсивный вызов функции. 
                MergeSortRange(M, a2, b2);
                long[] T = new long[Right - Left + 1];
                for (int k = Left; k <= Right; k++)
                    T[k - Left] = M[k];
                int i = a1;
                int j = a2;
                for (int k = Left; k <= Right; k++)
                    if (i <= b1 && j <= b2)
                        if (T[i - Left] < T[j - Left])
                        {
                            M[k] = T[i - Left];
                            i++;
                        }
                        else
                        {
                            M[k] = T[j - Left];
                            j++;
                        }
                    else
                        if (i > b1)
                    {
                        M[k] = T[j - Left];
                        j++;
                    }
                    else
                    {
                        M[k] = T[i - Left];
                        i++;
                    }
            }
            else if (Right - Left == 1)
            {
                if (M[Left] > M[Right])
                {
                    t = M[Left];
                    M[Left] = M[Right];
                    M[Right] = t;
                }
            }

        }
        /// <summary>
        /// Преобразование строки в число,
        /// </summary>
        /// <param name="word">заданное слово</param>
        /// <returns>слово в числовом виде</returns>
        public static long StrFromInt(string word)
        {
            long sum = 0;
            if (word.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum += (long)((AlphaBet.IndexOf(word[i]) * Math.Pow(33, 5 - word.IndexOf(word[i]))));
                }
                return sum;

            }
            else
            {
                foreach (char c in word)
                {
                    sum += (long)(AlphaBet.IndexOf(c) * Math.Pow(33, 5 - word.IndexOf(c)));
                }
                return sum;
            }

        }
        /// <summary>
        /// преобразование массива слов в массив чисел
        /// </summary>
        /// <param name="words">заданный текст для сортировки</param>
        /// <returns>массив чисел(преобразованных слов)</returns>
        public static long[] arrayer(string[] words)
        {
            long[] numwords = new long[words.Length];
            for (int i = 0; i < numwords.Length; i++)
            {
                numwords[i] = StrFromInt(words[i]);
            }
            return numwords;
        }
        /// <summary>
        /// Сортировка слов.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string[] Wordsort(string[] words, long[] nums)
        {
            int id = 0;
            string[] res = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (StrFromInt(words[j]) == nums[i])
                    {
                        res[id] = words[j];
                        id++;
                        break;
                    }
                }
            }
            return res;

        }




    }
}
