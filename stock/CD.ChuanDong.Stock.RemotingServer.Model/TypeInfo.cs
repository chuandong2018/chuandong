using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.Model
{
    /// <summary>
    /// 库存分类
    /// </summary>
    [Serializable]
    public class TypeInfo
    {
        /// <summary>
        /// 库存分类ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 显示深度
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// 父类，一级为0
        /// </summary>
        public int ParentID { get; set; }

    }
}
