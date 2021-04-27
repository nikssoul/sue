using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            int[,] a = new int[3, 4];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a[i, j] = rand.Next(-10, 10);
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();                  
                }
            }
            int m = 10;
            for(j=0;j<4;j++)
            {
                if (a[0,j]<m)
                {
                    m = a[0, j];
                }
            }
            int n = 10;
            for (j = 0; j < 4; j++)
            {
                if (a[1, j] < n)
                {
                    n = a[1, j];
                }
            }
            int p = 10;
            for (j = 0; j < 4; j++)
            {
                if (a[2, j] < p)
                {
                    p = a[2, j];
                }
            }
            label1.Text = m.ToString();
            label2.Text = n.ToString();
            label3.Text = p.ToString();
        }
    }
}
