using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sunisoft.IrisSkin;

namespace ExcelToDB
{
    static class Program
    {

        static SkinEngine skinEngine = new SkinEngine();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            skinEngine.SkinFile = (Application.StartupPath + "\\skins\\Page\\Page.ssk");
            skinEngine.SkinAllForm = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
