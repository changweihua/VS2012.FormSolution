using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace PanguApplication
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	Note
     * 机器名称:	LUMIA800
     * 命名空间:	PanguApplication
     * 文 件 名:	Note
     * 创建时间:	2013/4/2 10:58:47
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	5044e721-4117-4676-85ba-00026773662c  
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

    [Table(Name = "tbNote")]
    [Serializable]
    public class Note
    {
        [Id(Name = "n_guid")]
        public string Guid { get; set; }

        [Column(Name = "n_title")]
        public string Title { get; set; }

        [Column(Name = "n_content")]
        public string Content { get; set; }

        [Column(Name = "n_create_date")]
        public string CreateDate { get; set; }

        [Column(Name = "n_update_date")]
        public string UpdateDate { get; set; }

        [Column(Name = "n_attachment")]
        public string Attachment { get; set; }

        [Column(Name = "n_tag")]
        public string Tag { get; set; }

        [Column(Name = "n_record_type_id")]
        public int RecordType { get; set; }

        [Column(Name = "n_is_sync")]
        public int? IsSync { get; set; }

        [Column(Name = "n_is_modified")]
        public int? IsModified { get; set; }
    }
}
