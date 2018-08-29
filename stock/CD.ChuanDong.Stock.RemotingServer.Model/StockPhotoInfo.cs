using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.Model
{
    /// <summary>
    /// 库存产品图片
    /// </summary>
    [Serializable]
    public class StockPhotoInfo
    {
        /// <summary>
        /// 库存产品图片ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 库存ID
        /// </summary>
        public int StockID { get; set; }

        /// <summary>
        /// 库存图片
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// 默认0,1表示为封面图
        /// </summary>
        public int Cover { get; set; }
    }
}
