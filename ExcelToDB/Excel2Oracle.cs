using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelToDB
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	Excel2Oracle
     * 机器名称:	LUMIA800
     * 命名空间:	ExcelToDB
     * 文 件 名:	Excel2Oracle
     * 创建时间:	2013/6/5 11:53:57
     * 作    者:	常伟华 Changweihua
     * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	f9596cf7-21b9-41a2-b5a6-86d39552d80a  
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
    public partial class Excel2Oracle : Form
    {
        public Excel2Oracle()
        {
            InitializeComponent();
        }

        DataSet ImportExcel(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
                return null;

            //string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + file + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1'";
            string strConn = string.Format("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties=Excel 12.0;");
            OleDbConnection objConn = new OleDbConnection(strConn);
            DataSet dsExcel = new DataSet();
            try
            {
                objConn.Open();
                string strSql = "select * from  [Sheet1$]";
                OleDbDataAdapter odbcExcelDataAdapter = new OleDbDataAdapter(strSql, objConn);
                odbcExcelDataAdapter.Fill(dsExcel);
                return dsExcel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DataSet ds;
            var ofd = new OpenFileDialog();
            ofd.Filter = "Excel 2007+|*.xlsx|Excel 2003|*.xls";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtExcelName.Text = ofd.FileName;
                //DataTable dtbl = new DataTable();
                //try
                //{
                //    string strCon = string.Format("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtExcelName.Text + ";Extended Properties=Excel 12.0;");
                //    //string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + txtExcelName.Text + ";" + "Extended Properties=Excel 8.0;";
                //    string strSheetName = "";
                //    using (OleDbConnection con = new OleDbConnection(strCon))
                //    {
                //        con.Open();
                //        DataTable dtbl1 = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //        //dataGridView1.DataSource = dtbl1;  
                //        strSheetName = dtbl1.Rows[0][2].ToString().Trim();
                //    }
                //    String strCmd = "select top 1 * from [" + strSheetName + "]";
                //    OleDbDataAdapter cmd = new OleDbDataAdapter(strCmd, strCon);
                //    cmd.Fill(dtbl);
                //    MessageBox.Show(dtbl.Rows[0][0].ToString() + dtbl.Rows[0][1].ToString() + dtbl.Rows[0][2].ToString());
                //    dataGridView1.DataSource = dtbl;
                //}
                //catch (Exception ex) { MessageBox.Show(ex.Message); }   


                ds = ImportExcel(ofd.FileName);//获得Excel  

                int odr = 0;

                string connString = "Data Source=127.0.0.1/orcl;User ID=WC;Password=admin;Unicode=True"; //orcl为监听的服务名
                OracleConnection conn = new OracleConnection(connString);//获得conn连接  

                try
                {
                    conn.Open();

                    OracleCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "INSERT INTO table1 (name, score, grade) VALUES(:name,:score,:grade) ";//删除记录  

                    int dsLength = ds.Tables[0].Rows.Count;//获得Excel中数据长度  

                    for (int i = 1; i < dsLength; i++)
                    {
                        cmd.Parameters.Add("name", OracleType.VarChar).Value = ds.Tables[0].Rows[i][0];
                        cmd.Parameters.Add("score", OracleType.Int32).Value = ds.Tables[0].Rows[i][1];
                        cmd.Parameters.Add("grade", OracleType.Double).Value = ds.Tables[0].Rows[i][2];
                       
                        odr = cmd.ExecuteNonQuery();//提交  
                    }

                    //如果查到了数据，才使控制分页按钮生效  
                    if (odr > 0)
                    {
                        MessageBox.Show("导入成功");
                    }
                    conn.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }
    }
}
