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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
            Baju frm = new Baju();
        frm.Show();
        this.Hide();
            }
            else if (radioButton2.Checked == true)
            {
            kacamata a = new kacamata();
                a.Show();
                this.Hide();
             }
            else if (radioButton3.Checked == true)
            {
                sepatu b = new sepatu();
                b.Show();
                this.Hide();
            }
            else if (radioButton4.Checked == true)
            {
                tas c = new tas();
                c.Show();
                this.Hide();
              
            }
            else
            { MessageBox.Show("Silakan pilih pilihan anda!"); }
          
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
