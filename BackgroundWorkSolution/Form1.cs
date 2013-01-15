using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BackgroundWorkSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialWork();
        }

        BackgroundWorker backWorker = new BackgroundWorker();
        private static int MaxRecord = 100;

        private void InitialWork()
        {
            backWorker.WorkerReportsProgress = true;
            backWorker.WorkerSupportsCancellation = true;
            backWorker.DoWork += new DoWorkEventHandler(backWorker_DoWork);
            backWorker.ProgressChanged += new ProgressChangedEventHandler(backWorker_ProgressChanged);
            backWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backWorker_RunWorkerCompleted);
        }

        private int RetrieveDate(BackgroundWorker worker, DoWorkEventArgs e)
        {
            int maxRecorders = (int)e.Argument;

            int percent = 0;

            for (int i = 0; i <= maxRecorders; i++)
            {
                if (worker.CancellationPending)
                    return i;
                else
                {
                    percent = (int)((double)i / (double)maxRecorders * 100);
                    worker.ReportProgress(percent, new KeyValuePair<int, string>(i, Guid.NewGuid().ToString()));
                    Thread.Sleep(100);
                }
            }

            return maxRecorders;


        }


        void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            KeyValuePair<int, string> record = (KeyValuePair<int, string>)e.UserState;

            label1.Text = string.Format("There are {0} recorders finished!", record.Key);

            progressBar1.Value = e.ProgressPercentage;

            this.listBox1.Items.Add(record.Value);
        }

        void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = string.Format("Total {0} recorders", e.Result);
            button1.Enabled = true;
            button2.Enabled = false;

        }

        void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = RetrieveDate(backWorker, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            listBox1.Items.Clear();

            backWorker.RunWorkerAsync(MaxRecord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;


            backWorker.CancelAsync();
        }
    }


}
