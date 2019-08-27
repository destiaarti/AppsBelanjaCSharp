using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace daftar_belanja
{
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Saudara/Saudari " + "" + Program.nama + " silakan transfer di nomer rekening berikut:      " +"                    "+
                                "    no. rekening = 01000-1000-999-0000 (BRI)");
                MessageBox.Show("Untuk informasi lebih lanjut silakan hubungi 085468644777");
                MessageBox.Show("Happy SHOPPING!");
                this.Hide();
                frm1.Show();
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("Untuk informasi lebih lanjut silakan hubungi 085468644777");
                MessageBox.Show("Happy SHOPPING!");
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Silakan pilih cara pembayaran!");
            }
        }
    }
}

