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
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	GridForm
     * 机器名称:	LUMIA800
     * 命名空间:	LinkSaver
     * 文 件 名:	GridForm
     * 创建时间:	2013/1/15 21:41:55
     * 作    者:	常伟华 Changweihua
	 * 版    权:	GridForm说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	fd3869db-3d7d-4e1c-958e-40a5f8bba508  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 摘要
    /// </summary>
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = (Application.StartupPath + "\\skins\\Page\\Page.ssk");
            List<Link> links = null;
            using (var ctx = DbConfiguration.Items["Link"].CreateDbContext())
            {
                links = ctx.Set<Link>().ToList();
            }
            this.dgvLinks.DataSource = links;
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            new DetailForm().ShowDialog();
        }
    }
}
