using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Arr = new int[10];
        bool FirstClick = false;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewArray_Click(object sender, EventArgs e)
        {
            if (FirstClick == true)
            {


                int n = 10;
                int a = int.Parse(txtMin.Text);
                int b = int.Parse(txtMax.Text);
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    Arr[i] = r.Next(a, b);
                    lblArray.Text += Arr[i];
                    if (i != n) lblArray.Text += ",";
                }
                btnSort.Enabled = true;
            }
            else
            {
                lblArray.Text = "";
                
            }
            
            
        }
        private int MinNumber(int [] x, int m) // поиск минимального элемента массива 
        {
            int min = x[m];
            int MinN = m;
            for(int i = m; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN= i;
                }
            }
            return MinN;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for(int i = 0;i<Arr.Length;i++)
            {
                k= MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                lblResult.Text += Arr[i];
                if (i!=Arr.Length -1)
                {
                    lblResult.Text += ",";
                }
            }
            btnSort.Enabled= false;
        }
    }
}
