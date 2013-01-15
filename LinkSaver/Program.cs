using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NLite.Data;

namespace LinkSaver
{
    static class Program
    {

        

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 数据库

            DbConfiguration cfg = DbConfiguration
                  .Configure("Link")//通过connectionStringName对象创建DbConfiguration对象（可以用于配置文件中有多个数据库连接字符串配置）
                //.AddClass<MonoBookEntity.Index>()//注册实体到数据表的映射关系
                  .AddClass<Link>();

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
