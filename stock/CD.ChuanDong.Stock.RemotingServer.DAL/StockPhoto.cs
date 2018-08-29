using CD.ChuanDong.Stock.RemotingServer.DbHelper;
using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.DAL
{
    public class StockPhoto
    {


        /// <summary>
        /// 添加库存产品图片
        /// </summary>
        /// <param name="model">库存产品图片实体</param>
        /// <returns></returns>
        public int AddStockPhoto(StockPhotoInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@stockID",SqlDbType.Int),
                new SqlParameter("@photo",SqlDbType.NVarChar,200),
                new SqlParameter("@cover",SqlDbType.Int)
            };
            param[0].Value = model.StockID;
            param[1].Value = model.Photo;
            param[2].Value = model.Cover;
            return Convert.ToInt32(SqlHelper.RunProcedure("cd_photo_info_add", param, true));
        }

        /// <summary>
        /// 修改库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public int UpdateStockPhoto(int id, int cover)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@id",SqlDbType.Int),
                new SqlParameter("@cover",SqlDbType.Int)

            };
            param[0].Value = id;
            param[1].Value = cover;

            int result = -1;
            SqlHelper.RunProcedure("cd_photo_info_update", param, out result);
            return result;
        }


        /// <summary>
        /// 删除库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public int DelStockPhoto(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@id",SqlDbType.Int)
            };
            param[0].Value = id;
            int result = -1;
            SqlHelper.RunProcedure("cd_photo_info_del", param, out result);
            return result;
        }

        /// <summary>
        /// 根据ID查询库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public IList<StockPhotoInfo> GetStockPhotoList(int id)
        {

            List<StockPhotoInfo> list = new List<StockPhotoInfo>();

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@id", SqlDbType.Int)
            };
            param[0].Value = id;

            using (DataSet ds = SqlHelper.RunProcedure("cd_photo_info_select", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetStockModel(ds.Tables[0].Rows[i]));
                    }
                }
            }
            return list;

        }


        /// <summary>
        /// 设置StockPhotoInfo值
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private StockPhotoInfo SetStockModel(DataRow dr)
        {
            StockPhotoInfo stockPhotoInfo = new StockPhotoInfo();
            stockPhotoInfo.ID = string.IsNullOrEmpty(dr["ID"].ToString()) ? 0 : int.Parse(dr["ID"].ToString());
            stockPhotoInfo.StockID = string.IsNullOrEmpty(dr["StockID"].ToString()) ? 0 : int.Parse(dr["StockID"].ToString());
            stockPhotoInfo.Cover = string.IsNullOrEmpty(dr["Cover"].ToString()) ? 0 : int.Parse(dr["Cover"].ToString());
            stockPhotoInfo.Photo = dr["Photo"].ToString();
            return stockPhotoInfo;
        }

    }
}
