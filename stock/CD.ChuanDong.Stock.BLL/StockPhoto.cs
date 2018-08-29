using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.BLL
{
    public class StockPhoto
    {
        /// <summary>
        /// 添加库存产品图片
        /// </summary>
        /// <param name="model">库存产品图片实体</param>
        /// <returns></returns>
        public static int AddStockPhoto(StockPhotoInfo model)
        {
            return Remoting.RemoteObject().AddStockPhoto(model);

        }

        /// <summary>
        /// 修改库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public int UpdateStockPhoto(int id, int cover)
        {
            return Remoting.RemoteObject().UpdateStockPhoto(id, cover);
        }

        /// <summary>
        /// 删除库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public static int DelStockPhoto(int id)
        {
            return Remoting.RemoteObject().DelStockPhoto(id);

        }

        /// <summary>
        /// 根据ID查询库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public static IList<StockPhotoInfo> GetStockPhotoList(int id)
        {
            return Remoting.RemoteObject().GetStockPhotoList(id);


        }

    }
}
