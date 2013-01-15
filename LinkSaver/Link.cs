using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace LinkSaver
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	Link
     * 机器名称:	LUMIA800
     * 命名空间:	LinkSaver
     * 文 件 名:	Link
     * 创建时间:	2013/1/15 20:45:17
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Link说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	fd943f75-b970-4f76-a4f4-3bde8a2f2216  
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
    /// 
    [Table(Name="tbLink")]
    public class Link
    {
        public int Id { get; set; }
        public string LinkName { get; set; }
        public string LinkUrl { get; set; }
        public string LinkDescription { get; set; }
    }
}
