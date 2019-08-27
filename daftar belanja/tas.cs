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
    public partial class tas : Form
    {
                        
        data a = new data();
        

        public tas()
        {
            InitializeComponent();
            
        }
        
      
        public void button2_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
     if (checkBox1.Checked == true)
            {
                MessageBox.Show("Silakan untuk mengisi data pengiriman");
                a.Show();
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("Silakan untuk mengisi data pengiriman");
                a.Show();
                this.Close();
            }
            else if (checkBox3.Checked == true)
            {
                MessageBox.Show("Silakan untuk mengisi data pengiriman");
                a.Show();
                this.Close();
            }
            else if (checkBox4.Checked == true)
            {
                MessageBox.Show("Silakan untuk mengisi data pengiriman");
                a.Show();
                this.Close();
            }
                      else
            {
                MessageBox.Show("Silakan masukan pilihan anda");

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
