using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChromiumApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Lu = "我的名字";

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show(saveFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Lu + textBox1.Text, true);
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.Text))
            {
                MessageBox.Show(data.GetData(DataFormats.Text).ToString());
            }
            //saveFileDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = (Application.StartupPath + "\\Warm.ssk");
        }
    }
}
