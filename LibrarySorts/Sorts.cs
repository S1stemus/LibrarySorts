using System;

namespace LibrarySorts
{
    public class Sorts
    {
        public static int[] BubbleSort(int[] M, bool sortPlus)
        {
            if (sortPlus)   //Возрастание     
            {
                int N = M.GetLength(0);
                for (int i = N - 1; i >= 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (M[j] > M[j + 1])
                        {
                            int t = M[j];
                            M[j] = M[j + 1];
                            M[j + 1] = t;

                        }
                    }
                }

            }
            else   //убывание         
            {
                int N = M.GetLength(0);
                for (int i = N - 1; i >= 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (M[j] < M[j + 1])
                        {
                            int t = M[j];
                            M[j] = M[j + 1];
                            M[j + 1] = t;

                        }
                    }
                }


            }
            return M;

        }
        //сортировка вставками по возрастанию. Среднее время O(n^2)
        public static int[] InsertionSort(int[] M, bool SortPlus)
        {
            if (SortPlus)  //для возрастания
            {
                int N = M.GetLength(0);
                for (int i = 1; i < N; i++)
                {
                    int j = i;
                    while (M[j] < M[j - 1])
                    {
                        int T = M[j];
                        M[j] = M[j - 1];
                        M[j - 1] = T;
                        j--;
                        if (j == 0)
                        {
                            break;
                        }
                    }

                }

            }
            else                //для убывания
            {
                int N = M.GetLength(0);
                for (int i = 1; i < N; i++)
                {
                    int j = i;
                    while (M[j] > M[j - 1])
                    {
                        int T = M[j];
                        M[j] = M[j - 1];
                        M[j - 1] = T;
                        j--;
                        if (j == 0)
                        {
                            break;
                        }
                    }

                }

            }
            return M;
        }


        //Быстрая сортировка по
        public static int[] quicksort(int[] M, bool SortPlus)
        {
            int N = M.GetLength(0);
            if (SortPlus)
            {
                QuickSortRange(M, 0, N - 1);

            }
            else
            {
                QuickSortRangeRevers(M, 0, N - 1);

            }
            return M;
        }
        public static void QuickSortRangeRevers(int[] M, int Left, int Right)   //для убывания
        {
            QuickSortRange(M, Left, Right);
            int N = M.GetLength(0);
            for (int i = 0; i < N - 1; i++)
            {
                int t = M[i];
                M[i] = M[N - 1];
                M[N - 1] = t;
                N--;
            }
        }
        public static void QuickSortRange(int[] M, int Left, int Right)   //для возрастания
        {

            int a = Left, b = Right, p = M[(Left + Right) / 2];
            while (a < b)
            {
                while (M[a] < p)
                    a++;
                while (M[b] > p)
                    b--;
                if (a <= b)
                {
                    int t = M[a];
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
        public static int[] MergeSort(int[] M, bool SortPlus)
        {
            int N = M.GetLength(0);
            if (SortPlus)
            {
                MergeSortRange(M, 0, N - 1);

            }
            else
            {
                MergeSortRangeRevers(M, 0, N - 1);

            }
            return M;
        }
        public static void MergeSortRangeRevers(int[] M, int Left, int Right)   //для убывания
        {
            MergeSortRange(M, Left, Right);
            int N = M.GetLength(0);
            for (int i = 0; i < N - 1; i++)
            {
                int t = M[i];
                M[i] = M[N - 1];
                M[N - 1] = t;
                N--;
            }
        }
        public static void MergeSortRange(int[] M, int Left, int Right)         //для возрастания
        {

            if (Right - Left > 1)
            {
                int a1 = Left;
                int b1 = (Left + Right) / 2;
                int a2 = (Left + Right) / 2 + 1;
                int b2 = Right;
                MergeSortRange(M, a1, b1);
                MergeSortRange(M, a2, b2);
                int[] T = new int[Right - Left + 1];
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
                    int t = M[Left];
                    M[Left] = M[Right];
                    M[Right] = t;
                }
            }

        }
        


    }
}
