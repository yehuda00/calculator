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
        private float penjumlahan(float a, float b)
        {
            return a + b;
        }
        private float pengurangan(float a, float b)
        {
            return a - b;
        }
        private float perkalian(float a, float b)
        {
            return a * b;
        }
        private float pembagian(float a, float b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(NilaiA.Text);
            float b = float.Parse(NilaiB.Text);
            float c;
            if (comboBox1.SelectedIndex ==  0)
            {
                c = penjumlahan(a, b);
                Hasil.Text = c.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                c = pengurangan(a, b);
                Hasil.Text = c.ToString();
            } 
            if (comboBox1.SelectedIndex == 2)
            {
                c = perkalian(a, b);
                Hasil.Text = c.ToString();
            } 
            if (comboBox1.SelectedIndex == 3)
            {
                c = pembagian(a, b);
                Hasil.Text = c.ToString();
            }
            else
            {
                Hasil.Text = "Error";
            }
        }
    }
}
