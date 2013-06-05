using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrowserApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = (Application.StartupPath + "\\Warm.ssk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(this.textBox1.Text);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                if (e.Delta > 0)
                {
                    MessageBox.Show("往前");
                }
                else
                {
                    MessageBox.Show("往后");
                }
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
