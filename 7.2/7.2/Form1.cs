using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[10];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Mas[i] = rand.Next(-20, 20);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int Min = Mas[0];
            int j = 0;

            for (int i = 0; i < 10; i++)
            {
                if (Min > Mas[i])
                {
                    Min = Mas[i];
                    j = i;
                }
            }
            Mas[j] = Mas[8];
            Mas[8] = Min;
            listBox2.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
