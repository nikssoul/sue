using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._1
{
    public partial class Form1 : Form
    {
      
         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            int[,] a = new int[5, 5];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(-5, 5);
                }
            }
            int sum = 0;
            for(i=0;i<5;i++)
            {
                for(j=0;j<5;j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    sum += a[i, j];
                }
            }
            int b = 1;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                if (a[i, j] > 1)
                    
                   b *= a[i, j];
                    
                }
            }
            int c = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i==j)

                        c += a[i, j];

                }
            }
            label1.Text = sum.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
