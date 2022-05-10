using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySorts;
using System.Diagnostics;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSort_TextChanged(object sender, EventArgs e)
        {
            textBoxTime.Text = "";
            textBoxRes.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSort.Text))
            {
                textBoxRes.Text = "Введите хоть что-нибудь!";
                return;
            }
            textBoxRes.Text = "";
            Stopwatch st= new Stopwatch();
            st.Start();
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;   
            string text = textBoxSort.Text;
            string[] values = text.Split(' ',',','.',';');
            long[] Numbers = new long[values.Length];
            string wor="";            
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false;break;
                
            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                } 
                
                if (Plus.Checked) Sorts.BubbleSort(Numbers);
                else
                {
                    Sorts.BubbleSort(Numbers);
                    Array.Reverse(Numbers);
                }
                st.Stop();
                for (int i = 0; i < Numbers.Length; i++)
                {
                     wor+= Numbers[i]+" ";
                }                
                textBoxTime.Text =  st.Elapsed.TotalSeconds.ToString();
                textBoxRes.Text = wor;  
            }
            else
            {
                foreach(string value in values)
                {
                    foreach(char  sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            textBoxRes.Text = "Вы ввели неправильный символ.Мы сортируем либо числа либо строки.";
                            return;
                        }
                    }
                }
                long[] num = Sorts.arrayer(values);
                if (Plus.Checked) Sorts.BubbleSort(num);
                else
                {
                    Sorts.BubbleSort(num);
                    Array.Reverse(num);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                textBoxRes.Text= String.Join(' ',res);               
                textBoxTime.Text= st.Elapsed.TotalSeconds.ToString();
            }
        }

        private void quick_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSort.Text))
            {
                textBoxRes.Text = "Введите хоть что-нибудь!";
                return;
            }
            textBoxRes.Text = "";
            Stopwatch st = new Stopwatch();
            st.Start();
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = textBoxSort.Text;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false; break;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }

                if (Plus.Checked) Sorts.Quicksort(Numbers);
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
                textBoxTime.Text = st.Elapsed.TotalSeconds.ToString();
                textBoxRes.Text = wor;
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            textBoxRes.Text = "Вы ввели неправильный символ.Мы сортируем либо числа либо строки.";
                            return;
                        }                           
                    }
                }
                long[] num = Sorts.arrayer(values);
                if (Plus.Checked) Sorts.Quicksort(num);
                else
                {
                    Sorts.Quicksort(num);
                    Array.Reverse(num);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                textBoxRes.Text = String.Join(' ', res);
                textBoxTime.Text = st.Elapsed.TotalSeconds.ToString();
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSort.Text))
            {
                textBoxRes.Text = "Введите хоть что-нибудь!";
                return;
            }
            textBoxRes.Text = "";
            Stopwatch st = new Stopwatch();
            st.Start();
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = textBoxSort.Text;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false; break;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }

                if (Plus.Checked) Sorts.InsertionSort(Numbers);
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
                textBoxTime.Text = st.Elapsed.TotalSeconds.ToString();
                textBoxRes.Text = wor;
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            textBoxRes.Text = "Вы ввели неправильный символ.Мы сортируем либо числа либо строки.";
                            return;
                        }
                    }
                }
                long[] num = Sorts.arrayer(values);
                if (Plus.Checked) Sorts.InsertionSort(num);
                else
                {
                    Sorts.InsertionSort(num);
                    Array.Reverse(num);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                textBoxRes.Text = String.Join(' ', res);
                textBoxTime.Text = st.Elapsed.TotalSeconds.ToString();
            }
        }

        private void merge_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSort.Text))
            {
                textBoxRes.Text = "Введите хоть что-нибудь!";
                return;
            }
            textBoxRes.Text = "";
            Stopwatch st = new Stopwatch();
            st.Start();
            const string AlphaBet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
            bool sort = true;
            string text = textBoxSort.Text;
            string[] values = text.Split(' ', ',', '.', ';');
            long[] Numbers = new long[values.Length];
            string wor = "";
            foreach (string value in values)
            {
                if (!int.TryParse(value, out int M)) sort = false; break;

            }
            if (sort)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(values[i]);
                }

                if (Plus.Checked) Sorts.InsertionSort(Numbers);
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
                textBoxTime.Text = st.Elapsed.TotalSeconds.ToString();
                textBoxRes.Text = wor;
            }
            else
            {
                foreach (string value in values)
                {
                    foreach (char sub in value)
                    {
                        if (AlphaBet.IndexOf(sub) == -1)
                        {
                            textBoxRes.Text = "Вы ввели неправильный символ.Мы сортируем либо числа либо строки.";
                            return;
                        }
                    }
                }
                long[] num = Sorts.arrayer(values);
                if (Plus.Checked) Sorts.InsertionSort(num);
                else
                {
                    Sorts.InsertionSort(num);
                    Array.Reverse(num);
                }
                string[] res = Sorts.Wordsort(values, num);
                st.Stop();
                textBoxRes.Text = String.Join(' ', res);
                textBoxTime.Text = st.Elapsed.TotalSeconds.ToString();
            }
        }
    }
}
