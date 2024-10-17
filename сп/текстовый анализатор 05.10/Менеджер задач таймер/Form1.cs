using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace Менеджер_задач_таймер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        int x = 0;
        List<Manager> tasks = new List<Manager>();
        public class Manager
        {
            int secs = 0;
            public int time = 0;
            public string name = "";
            public Manager(string _name,int _hours, int _minutes, int _secs)
            {
                name = _name;
                time += _secs;
                time += _minutes*60;
                time += _hours*3600;
            }
            public void Timer()
            {
                time--;
            }
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Manager task = new Manager(textBox1.Text, int.Parse(textBox3.Text), int.Parse(textBox2.Text), int.Parse(textBox4.Text));
            tasks.Add(task);
            New();
        }
        void New()
        {
            listBox1.Items.Clear();
            foreach (Manager item in tasks)
            {
                string stroka = item.name + " "+item.time;
                listBox1.Items.Add(stroka);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            { 
                x = listBox1.SelectedIndex;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tasks[x].Timer();
            New();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = -1;
            timer1.Stop();
        }
    }
}
