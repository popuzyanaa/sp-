using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анализатор_текста
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = "";
            string stroka = textBox1.Text;
            label1.Text = "Количество символов в строке: " + stroka.Length;
            int a = 0;
            words = stroka.Replace('.', ' ');
            string[] arr = words.Split(' ');
            foreach (string s in arr)
            {
                if (s.Length != 0)
                {
                    a++;
                }
            }
            label2.Text = $"Количество слов в строке: {a}";
            a = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == '.')
                {
                    for (int j = i; j < stroka.Length; j++)
                    {
                        if (stroka[j] != '.')
                        {
                            a++;
                            i = j;
                            break;
                        }

                    }
                }
            }
            label3.Text = $"Количество предложений в строке: {a + 1}";
            string dsf = "";

            a = 0;
            words = stroka.Replace('.', ' ');
            arr = words.Split(' ');
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                dsf += arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        b++;
                    }
                }
                if (b == 1)
                {
                    a++;
                }
                b = 0;
            }
            label4.Text = "количество уникальных слов: " + a;
            dsf = "";
            a = 0;
            words = stroka.Replace('.', ' ');
            arr = words.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                if (dsf.Length < arr[i].Length)
                {
                    dsf = arr[i];
                }
            }

            label5.Text = "Самое длинное слово: " + dsf;

            for (int i = 0; i < arr.Length; i++)
            {
                if (dsf.Length > arr[i].Length && arr.Length != 0)
                {
                    dsf = arr[i];
                }
            }
            label6.Text = "Самое короткое слово: " + dsf;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
