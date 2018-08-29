using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.BLL
{
    public class StockAttributeTra
    {
        /// <summary>
        /// 添加自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public static int AddAttribute(AttributeInfo model)
        {
            return Remoting.RemoteObject().AddAttribute(model);

        }

        /// <summary>
        /// 修改自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public static int UpdateAttribute(AttributeInfo model)
        {
            return Remoting.RemoteObject().UpdateAttribute(model);

        }

        /// <summary>
        /// 删除修改自定义属性信息
        /// </summary>
        /// <param name="id">自定义属性id</param>
        /// <returns></returns>
        public static int DelAttribute(int id)
        {
            return Remoting.RemoteObject().DelAttribute(id);

        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public static AttributeInfo SelectAttribute(int id)
        {
            return Remoting.RemoteObject().SelectAttribute(id);

        }

        /// <summary>
        /// 根据条件查询自定义属性信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public static IList<AttributeInfo> GetAttributeListBy(string where)
        {
            return Remoting.RemoteObject().GetAttributeListBy(where);

        }

        /// <summary>
        /// 根据条件获取自定义属性信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public static IList<AttributeInfo> GetAttributeListPage(int pageSize, int pageStart, string where, string orderString)
        {
            return Remoting.RemoteObject().GetAttributeListPage(pageSize, pageStart, where, orderString);

        }


        /// <summary>
        /// 统计符合条件总数（自定义属性信息）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public static int GetAttributeCount(string condition)
        {
            return Remoting.RemoteObject().GetAttributeCount(condition);

        }
    }
}
