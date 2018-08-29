using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.Model
{
    /// <summary>
    /// 产品自定义属性
    /// </summary>
    [Serializable]
    public class AttributeInfo
    {
        /// <summary>
        ///产品自定义属性ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 产品自定义属性名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 所属库存分类
        /// </summary>
        public int TypeID { get; set; }

    }
}
