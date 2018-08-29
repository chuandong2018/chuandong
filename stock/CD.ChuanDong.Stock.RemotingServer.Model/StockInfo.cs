using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.Model
{
    /// <summary>
    /// 库存信息表
    /// </summary>
    [Serializable]
    public class StockInfo
    {
        /// <summary>
        /// 库存ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 库存物料ID
        /// </summary>
        public string MaterialID { get; set; }

        /// <summary>
        /// 库存产品名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 库存描述
        /// </summary>
        public string Describle { get; set; }

        /// <summary>
        ///库存产品介绍
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 品牌id（所属品牌）
        /// </summary>
        public int BrandID { get; set; }

        /// <summary>
        /// 产品 单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 优惠价
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        public decimal Freight { get; set; }


        /// <summary>
        /// 库存总量
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime Joindate { get; set; }

        /// <summary>
        /// 库存更新时间
        /// </summary>
        public DateTime UpTime { get; set; }

        /// <summary>
        /// 库存所属分类
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sales { get; set; }

        /// <summary>
        /// 点击数
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 库存状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 库存所在地
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 是否推荐到首页
        /// </summary>
        public int IsRecommend { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }



    }
}
