using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.BLL
{
    public class StockAttributeValuesTra
    {
        /// <summary>
        /// 添加自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public static int AddAttributeValues(AttributeValueInfo model)
        {
            return Remoting.RemoteObject().AddAttributeValues(model);

        }

        /// <summary>
        /// 修改自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public static int UpdateAttributeValues(AttributeValueInfo model)
        {
            return Remoting.RemoteObject().UpdateAttributeValues(model);

        }

        /// <summary>
        /// 删除修改自定义属性值信息
        /// </summary>
        /// <param name="id">自定义属性值id</param>
        /// <returns></returns>
        public static int DelAttributeValues(string where)
        {
            return Remoting.RemoteObject().DelAttributeValues(where);
        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public static AttributeValueInfo SelectAttributeValues(int id)
        {
            return Remoting.RemoteObject().SelectAttributeValues(id);
        }

        /// <summary>
        /// 根据条件查询自定义属性信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public static IList<AttributeValueInfo> GetAttributeValueListBy(string where)
        {
            return Remoting.RemoteObject().GetAttributeValueListBy(where);
        }

        /// <summary>
        /// 根据条件获取自定义属性信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public static IList<AttributeValueInfo> GetAttributeValuesList(int pageSize, int pageStart, string where, string orderString)
        {
            return Remoting.RemoteObject().GetAttributeValuesList(pageSize, pageStart, where, orderString);

        }


        /// <summary>
        /// 统计符合条件总数（自定义属性信息）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public static int GetAttributeValueCount(string condition)
        {
            return Remoting.RemoteObject().GetAttributeValueCount(condition);

        }
    }
}
