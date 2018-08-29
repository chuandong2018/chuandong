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
    public class Stock
    {

        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="stock">库存实体</param>
        /// <returns></returns>
        public int AddStock(StockInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@materialID",SqlDbType.NVarChar,50),
                new SqlParameter("@title",SqlDbType.NVarChar,200),
                new SqlParameter("@describle",SqlDbType.NVarChar,500),
                new SqlParameter("@content",SqlDbType.NText),
                new SqlParameter("@freight",SqlDbType.Decimal),
                new SqlParameter("@price",SqlDbType.Decimal),
                new SqlParameter("@discount",SqlDbType.Decimal),
                new SqlParameter("@total",SqlDbType.Int),
                new SqlParameter("@brandID",SqlDbType.Int),
                new SqlParameter("@joindate",SqlDbType.DateTime),
                new SqlParameter("@hits",SqlDbType.Int),
                new SqlParameter("@upTime",SqlDbType.DateTime),
                new SqlParameter("@typeID",SqlDbType.Int),
                new SqlParameter("@sales",SqlDbType.Int),
                new SqlParameter("@state",SqlDbType.Int),
                new SqlParameter("@Address",SqlDbType.NVarChar,200),
                new SqlParameter("@isrecommend",SqlDbType.Int),
                new SqlParameter("@brandname",SqlDbType.NVarChar,100)
            };
            param[0].Value = model.MaterialID;
            param[1].Value = model.Title;
            param[2].Value = model.Describle;
            param[3].Value = model.Content;
            param[4].Value = model.Freight;
            param[5].Value = model.Price;
            param[6].Value = model.Discount;
            param[7].Value = model.Total;
            param[8].Value = model.BrandID;
            param[9].Value = model.Joindate;
            param[10].Value = model.Hits;
            param[11].Value = model.UpTime;
            param[12].Value = model.TypeID;
            param[13].Value = model.Sales;
            param[14].Value = model.State;
            param[15].Value = model.Address;
            param[16].Value = model.IsRecommend;
            param[17].Value = model.BrandName;

            return Convert.ToInt32(SqlHelper.RunProcedure("cd_stock_info_add", param, true));

        }

        /// <summary>
        /// 修改库存信息
        /// </summary>
        /// <param name="model">库存信息实体</param>
        /// <returns></returns>
        public int UpdateStock(StockInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@ID",SqlDbType.Int),
                new SqlParameter("@materialID",SqlDbType.NVarChar,50),
                new SqlParameter("@title",SqlDbType.NVarChar,200),
                new SqlParameter("@describle",SqlDbType.NVarChar,500),
                new SqlParameter("@content",SqlDbType.NText),
                new SqlParameter("@freight",SqlDbType.Decimal),
                new SqlParameter("@price",SqlDbType.Decimal),
                new SqlParameter("@discount",SqlDbType.Decimal),
                new SqlParameter("@total",SqlDbType.Int),
                new SqlParameter("@brandID",SqlDbType.Int),
                new SqlParameter("@joindate",SqlDbType.DateTime),
                new SqlParameter("@hits",SqlDbType.Int),
                new SqlParameter("@upTime",SqlDbType.DateTime),
                new SqlParameter("@typeID",SqlDbType.Int),
                new SqlParameter("@sales",SqlDbType.Int),
                new SqlParameter("@state",SqlDbType.Int),
                new SqlParameter("@Address",SqlDbType.NVarChar,200),
                new SqlParameter("@isrecommend",SqlDbType.Int),
                new SqlParameter("@brandname",SqlDbType.NVarChar,100)

            };
            param[0].Value = model.ID;
            param[1].Value = model.MaterialID;
            param[2].Value = model.Title;
            param[3].Value = model.Describle;
            param[4].Value = model.Content;
            param[5].Value = model.Freight;
            param[6].Value = model.Price;
            param[7].Value = model.Discount;
            param[8].Value = model.Total;
            param[9].Value = model.BrandID;
            param[10].Value = model.Joindate;
            param[11].Value = model.Hits;
            param[12].Value = model.UpTime;
            param[13].Value = model.TypeID;
            param[14].Value = model.Sales;
            param[15].Value = model.State;
            param[16].Value = model.Address;
            param[17].Value = model.IsRecommend;
            param[18].Value = model.BrandName;

            int result = -1;
            SqlHelper.RunProcedure("cd_stock_info_update", param, out result);
            return result;
        }

        /// <summary>
        /// 增加点击数
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public int AddHits(int id, int hits)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@id",SqlDbType.Int),
                    new SqlParameter("@hits",SqlDbType.Int)
            };
            param[0].Value = id;
            param[1].Value = hits;
            int result = -1;
            SqlHelper.RunProcedure("cd_stock_info_addhits", param, out result);
            return result;
        }

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public int DelStock(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@id",SqlDbType.Int)
                };
            param[0].Value = id;
            int result = -1;
            SqlHelper.RunProcedure("cd_stock_info_del", param, out result);
            return result;
        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public StockInfo SelectStock(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@id", SqlDbType.Int)
                };
            param[0].Value = id;

            using (DataSet ds = SqlHelper.RunProcedure("cd_stock_info_select", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return SetStockModel(ds.Tables[0].Rows[0]);
                }
            }
            return null;
        }

        /// <summary>
        /// 根据条件查询库存信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<StockInfo> GetStockListBy(string where)
        {
            List<StockInfo> list = new List<StockInfo>();

            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@condition", SqlDbType.Int)
                };
            param[0].Value = where;

            using (DataSet ds = SqlHelper.RunProcedure("cd_stock_info_get", param, "ds"))
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
        /// 根据条件获取库存信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public IList<StockInfo> GetStockListPage(int pageSize, int pageStart, string where, string orderString)
        {
            List<StockInfo> list = new List<StockInfo>();
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@pagesize", SqlDbType.Int),
                    new SqlParameter("@pagestart", SqlDbType.Int),
                    new SqlParameter("@condition", SqlDbType.NVarChar,1000),
                    new SqlParameter("@orderstr", SqlDbType.NVarChar,100)
                };
            param[0].Value = pageSize;
            param[1].Value = pageStart;
            param[2].Value = where;
            param[3].Value = orderString;

            using (DataSet ds = SqlHelper.RunProcedure("cd_stock_info_getlist", param, "ds"))
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
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int GetStockCount(string condition)
        {

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@condition", SqlDbType.NVarChar,1000),

            };
            param[0].Value = condition;
            return Convert.ToInt32(SqlHelper.RunProcedure("cd_stock_info_count", param, true));
        }



        /// <summary>
        /// 设置StockInfo值
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private StockInfo SetStockModel(DataRow dr)
        {
            StockInfo stockInfo = new StockInfo();
            stockInfo.ID = string.IsNullOrEmpty(dr["ID"].ToString()) ? 0 : int.Parse(dr["ID"].ToString());
            stockInfo.MaterialID = dr["MaterialID"].ToString();
            stockInfo.Title = dr["Title"].ToString();
            stockInfo.Describle = dr["Describe"].ToString();
            stockInfo.Content = dr["Content"].ToString();
            stockInfo.Freight = string.IsNullOrEmpty(dr["Freight"].ToString()) ? 0 : decimal.Parse(dr["Freight"].ToString());
            stockInfo.Discount = string.IsNullOrEmpty(dr["Discount"].ToString()) ? 0 : decimal.Parse(dr["Discount"].ToString());
            stockInfo.Price = string.IsNullOrEmpty(dr["Price"].ToString()) ? 0 : decimal.Parse(dr["Price"].ToString());
            stockInfo.Total = string.IsNullOrEmpty(dr["Total"].ToString()) ? 0 : int.Parse(dr["Total"].ToString());
            stockInfo.BrandID = string.IsNullOrEmpty(dr["BrandID"].ToString()) ? 0 : int.Parse(dr["BrandID"].ToString());
            stockInfo.Joindate = Convert.ToDateTime(dr["Joindate"]);
            stockInfo.UpTime = Convert.ToDateTime(dr["UpTime"]);
            stockInfo.TypeID = string.IsNullOrEmpty(dr["TypeID"].ToString()) ? 0 : int.Parse(dr["TypeID"].ToString());
            stockInfo.Sales = string.IsNullOrEmpty(dr["Sales"].ToString()) ? 0 : int.Parse(dr["Sales"].ToString());
            stockInfo.Hits = string.IsNullOrEmpty(dr["Hits"].ToString()) ? 0 : int.Parse(dr["Hits"].ToString());
            stockInfo.State = string.IsNullOrEmpty(dr["State"].ToString()) ? 0 : int.Parse(dr["State"].ToString());
            stockInfo.IsRecommend = string.IsNullOrEmpty(dr["IsRecommend"].ToString()) ? 0 : int.Parse(dr["IsRecommend"].ToString());
            stockInfo.Address = dr["Address"].ToString();
            stockInfo.BrandName = dr["BrandName"].ToString(); ;

            return stockInfo;
        }
    }
}
