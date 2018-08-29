using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.Model
{
    /// <summary>
    /// 产品自定义属性值
    /// </summary>
    [Serializable]
    public class AttributeValueInfo
    {
        /// <summary>
        ///产品自定义属性值ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 产品自定义属性名称
        /// </summary>
        public int AttributeID { get; set; }

        /// <summary>
        /// 对应库存
        /// </summary>
        public int StockID { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string Values { get; set; }

    }
}
