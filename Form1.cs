using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haier_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NIM : 17.11.1039", "Program Made by :");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            if (textNilaiA.Text == "")
            {
                a = 0;
                MessageBox.Show("Anda Belum Menginputkan nilai", "Peringatan!");
            } else
            {
                a = int.Parse(textNilaiA.Text);
            }

            if (textNilaiB.Text == "")
            {
                b = 0;
            } else
            {
                b = Convert.ToInt32(textNilaiB.Text);
            }

            textHasilAB.Clear();

            if (comboBox.Text == "Penjumlahan")
            {
                textHasilAB.Text = Convert.ToString(Penjumlahan(a, b));
            }
            else if (comboBox.Text == "Pengurangan")
            {
                textHasilAB.Text = Convert.ToString(Pengurangan(a, b));
            }
            else if(comboBox.Text == "Perkalian")
            {
                textHasilAB.Text = Convert.ToString(Perkalian(a, b));
            }
            else if(comboBox.Text == "Pembagian")
            {
                textHasilAB.Text = Convert.ToString(Pembagian(a, b));
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
