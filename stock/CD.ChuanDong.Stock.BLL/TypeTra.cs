using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.BLL
{
    public class TypeTra
    {
        /// <summary>
        /// 添加库存分类信息
        /// </summary>
        /// <param name="model">库存分类实体</param>
        /// <returns></returns>
        public static int AddType(TypeInfo model)
        {
            return Remoting.RemoteObject().AddType(model);

        }

        /// <summary>
        /// 修改库存分类信息
        /// </summary>
        /// <param name="model">库存分类实体</param>
        /// <returns></returns>
        public static int UpdateType(TypeInfo model)
        {
            return Remoting.RemoteObject().UpdateType(model);
        }

        /// <summary>
        /// 删除库存分类信息
        /// </summary>
        /// <param name="id">库存分类id</param>
        /// <returns></returns>
        public static int DelType(int id)
        {
            return Remoting.RemoteObject().DelType(id);
        }

        /// <summary>
        /// 根据条件查询库存分类信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public static IList<TypeInfo> GetTypeListBy(string where)
        {
            return Remoting.RemoteObject().GetTypeListBy(where);
        }

        /// <summary>
        /// 根据条件获取库存分类信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public static IList<TypeInfo> GetTypeListPage(int pageSize, int pageStart, string where, string orderString)
        {
            return Remoting.RemoteObject().GetTypeListPage(pageSize, pageStart, where, orderString);
        }

        /// <summary>
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public static int GetTypeCount(string condition)
        {
            return Remoting.RemoteObject().GetTypeCount(condition);
        }

    }
}
