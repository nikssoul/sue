using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            int[,] a = new int[3, 3];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = rand.Next(-10, 10);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }
            int m = 0;            
            for (j = 0; j < 3; j++)
            {
                m += a[1, j];
            }
            int n = 1;
            for (i = 0; i < 3; i++)
            {
                n *= a[i, 0];
            }
           
            label1.Text = m.ToString();
            label2.Text = n.ToString();
           
        }
    }
}
