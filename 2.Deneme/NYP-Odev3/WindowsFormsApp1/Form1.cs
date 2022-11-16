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

        private void button1_Click(object sender, EventArgs e)
        {
            long sayac = 0;
            long x = long.Parse(numericUpDown1.Text);
            if (x < 2)
            {
                MessageBox.Show("Asal Sayı Bulunamadı");
            }
            else
            {
                for (long i = 2; i <= x; i++)
                {
                    long kontrol = 0;
                    for (long j =2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }

            label1.Text = "1-" + x + " arasi " + sayac + " adet Asal Sayı Bulundu.";
        }

     
    }
}
