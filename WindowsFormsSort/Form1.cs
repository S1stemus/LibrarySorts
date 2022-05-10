using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ;



namespace WindowsFormsSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Texts_TextChanged(object sender, EventArgs e)
        {
            Timer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string AlphaBet = "АаБбВвГгДдЕеЁёЖжЗзИиКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЫыЪъЭэЮюЯяAaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string word = Texts.Text;
            string[] words = word.Split(',','.',';','-');
            bool numsort = true;
            bool strsort = false;
            foreach (string word2 in words)
            {
                if (!int.TryParse(word2, out int M))
                {
                    numsort = false;
                    strsort = true;

                }
                foreach(char c in word2)
                {
                    if (AlphaBet.IndexOf(c) == -1) strsort = false;
                }
                
            }
            foreach (string word2 in words)
            {
                foreach (char c in word2)
                {
                    if (AlphaBet.IndexOf(c) == -1) strsort = false;
                }
            }
            if (numsort || strsort)
            {
                Texts.Text = "В тексте недопустимый символ";
            }
            else if (numsort)
            {
                int[] nums=new int[words.Length];
                for (int i = 0; i < words.Length; i++)
                {
                    nums[i] = int.Parse(words[i]);
                }
                Stopwatch st = new Stopwatch();
                st.Start();

                if (radioButton1.Checked==true)
                {
                    Sor
                }

                st.Stop();
            }
                
                
               
        }
    }
}
