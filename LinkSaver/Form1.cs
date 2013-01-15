using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NLite.Data;

namespace LinkSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = (Application.StartupPath + "\\skins\\Page\\Page.ssk" );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            using (var ctx = DbConfiguration.Items["Link"].CreateDbContext())
            {
                count = ctx.Set<Link>().Insert(new Link
                {
                    LinkDescription = txtLinkDescription.Text,
                    LinkName = txtLinkName.Text,
                    LinkUrl = txtLinkUrl.Text
                });
            }

            if (count == 1)
            {
                MessageBox.Show("保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
