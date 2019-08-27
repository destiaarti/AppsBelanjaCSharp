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
    public partial class kacamata : Form
    {
        data a = new data();
        public kacamata()
        {
            InitializeComponent();
        }

              private void button1_Click_1(object sender, EventArgs e)
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
            else if (checkBox5.Checked == true)
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

              private void button3_Click(object sender, EventArgs e)
              {
                  Application.Exit();
              }

              private void button2_Click(object sender, EventArgs e)
              {
                  Form1 frm1 = new Form1();
                  frm1.Show();
                  this.Hide();
              }
    }
}
