using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string memo = "";
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.cmono.net/?post=504");

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                Stream receiveStream = myHttpWebResponse.GetResponseStream();
                Encoding encode = Encoding.GetEncoding("utf-8");
                StreamReader sr = new StreamReader(receiveStream, encode);
                char[] read  = new char[256];
                int count = sr.Read(read, 0, 256);
                while (count>0)
                {
                    string str = new string(read, 0, count);
                    memo += str;
                    count = sr.Read(read, 0, 256);

                }
                sr.Close();
                myHttpWebResponse.Close();
                this.textBox1.Text = memo;
                Regex reg = new Regex(@"<div.+class=context?>(?<content>.+?)</div>", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                string val = reg.Match(memo).Groups["content"].Value;
                MessageBox.Show(val);

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.SelectedRtf);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                    this.comboBox1.Items.Add("TabPage1");
                    break;
                case 1:
                    this.comboBox1.Items.Add("TabPage2");
                    break;
                default:
                    break;
            }
            this.comboBox1.SelectedIndex = 0;
        }
    }
}
