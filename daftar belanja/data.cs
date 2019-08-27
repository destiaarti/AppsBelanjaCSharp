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
    public partial class data : Form
    {

       
       
        public data()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           Program.nama = textBox1.Text;
           Program.alamat = textBox4.Text;

            if (textBox1.Text == "")
            { MessageBox.Show("Isi nama dengan benar!"); }
            else if(textBox5.Text == "")
            { MessageBox.Show("Isi alamat dengan benar!"); }
            else if (textBox4.Text == "")
            { MessageBox.Show("Isi email dengan benar!"); }
            else if (maskedTextBox1.Text == "")
            { MessageBox.Show("Isi No.Hp dengan benar!"); }
            else if (textBox2.Text == "")
            {   MessageBox.Show("Isi Kota dengan benar!"); }
            else
            { MessageBox.Show("Saudara/Saudari "+""+Program.nama+" yang beralamat "+Program.alamat+" .Silakan memilih cara pembayaran");
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

      

      
    }
}
