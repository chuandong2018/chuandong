using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.BLL
{
    public class StockTra
    {
        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="stock">库存实体</param>
        /// <returns></returns>
        public static int AddStock(StockInfo model)
        {
            return Remoting.RemoteObject().AddStock(model);
        }

        /// <summary>
        /// 修改库存信息
        /// </summary>
        /// <param name="model">库存信息实体</param>
        /// <returns></returns>
        public static int UpdateStock(StockInfo model)
        {
            return Remoting.RemoteObject().UpdateStock(model);
        }

        /// <summary>
        /// 增加点击数
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public static int AddHits(int id, int hits)
        {
            return Remoting.RemoteObject().AddHits(id, hits);
        }

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public static int DelStock(int id)
        {
            return Remoting.RemoteObject().DelStock(id);
        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public static StockInfo SelectStock(int id)
        {
            return Remoting.RemoteObject().SelectStock(id);
        }

        /// <summary>
        /// 根据条件查询库存信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public static IList<StockInfo> GetStockListBy(string where)
        {
            return Remoting.RemoteObject().GetStockListBy(where);
        }

        /// <summary>
        /// 根据条件获取库存信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public static IList<StockInfo> GetStockListPage(int pageSize, int pageStart, string where, string orderString)
        {
            return Remoting.RemoteObject().GetStockListPage(pageSize, pageStart, where, orderString);
        }

        /// <summary>
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public static int GetStockCount(string condition)
        {
            return Remoting.RemoteObject().GetStockCount(condition);
        }
    }
}
