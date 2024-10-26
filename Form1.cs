using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Arr; //= new int[10];

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewArray_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int arraySize) && arraySize > 0)
            {
                Arr = new int[arraySize];

                ClearFields();
                int n = arraySize;
                int a = int.Parse(txtMin.Text);
                int b = int.Parse(txtMax.Text);
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    Arr[i] = r.Next(a, b);
                    lblArray.Text += Arr[i];
                    if (i != n - 1) lblArray.Text += ",";
                }
                //    SortArray();
                //for (int i = 0; i < Arr.Length; i++)
                //{
                //    lblArray.Text += Arr[i];
                //    if (i != Arr.Length - 1)
                //        lblArray.Text += ",";
                //}
                btnSort.Enabled = true;
            }
            else
                MessageBox.Show("Массив должен быть положительным");
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
        private void ClearFields()
        {
            lblArray.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }
        //private void SortArray()
        //{
        //    int index;
        //    int CurrentNumber;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        index = i;
        //        CurrentNumber = Arr[i];
        //        while (index > 0 && CurrentNumber < Arr[index - 1])
        //        {
        //            Arr[index] = Arr[index - 1];
        //            index--;
        //        }
        //        Arr[index] = CurrentNumber;
        //    }
        //}
    }
}
