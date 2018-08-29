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
    public class StockAttributeValues
    {

        /// <summary>
        /// 添加自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int AddAttributeValues(AttributeValueInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{

                new SqlParameter("@attributeID",SqlDbType.Int),
                new SqlParameter("@stockID",SqlDbType.Int),
                new SqlParameter("@values",SqlDbType.NVarChar,200)
            };
            param[0].Value = model.AttributeID;
            param[1].Value = model.StockID;
            param[2].Value = model.Values;
            return Convert.ToInt32(SqlHelper.RunProcedure("attribute_value_info_add", param, true));
        }

        /// <summary>
        /// 修改自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int UpdateAttributeValues(AttributeValueInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@ID ",SqlDbType.NVarChar,200),
                new SqlParameter("@attributeID",SqlDbType.Int),
                new SqlParameter("@stockID",SqlDbType.Int),
                new SqlParameter("@values",SqlDbType.NVarChar,200)
            };
            param[0].Value = model.ID;
            param[1].Value = model.AttributeID;
            param[2].Value = model.StockID;
            param[3].Value = model.Values;
            return Convert.ToInt32(SqlHelper.RunProcedure("attribute_value_info_update", param, true));
        }

        /// <summary>
        /// 删除修改自定义属性值信息
        /// </summary>
        /// <param name="id">自定义属性值id</param>
        /// <returns></returns>
        public int DelAttributeValues(string where)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@condition",SqlDbType.NVarChar,1000)
                };
            param[0].Value = where;
            int result = -1;
            SqlHelper.RunProcedure("attribute_value_info_del", param, out result);
            return result;
        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public AttributeValueInfo SelectAttributeValues(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@ID", SqlDbType.Int)
                };
            param[0].Value = id;

            using (DataSet ds = SqlHelper.RunProcedure("attribute_value_info_select", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return SetAttributeValueModel(ds.Tables[0].Rows[0]);
                }
            }
            return null;
        }

        /// <summary>
        /// 根据条件查询自定义属性信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<AttributeValueInfo> GetAttributeValueListBy(string where)
        {
            List<AttributeValueInfo> list = new List<AttributeValueInfo>();

            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@condition",  SqlDbType.NVarChar,100)
                };
            param[0].Value = where;

            using (DataSet ds = SqlHelper.RunProcedure("attribute_value_info_get", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetAttributeValueModel(ds.Tables[0].Rows[i]));
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 根据条件获取自定义属性信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public IList<AttributeValueInfo> GetAttributeValuesList(int pageSize, int pageStart, string where, string orderString)
        {
            List<AttributeValueInfo> list = new List<AttributeValueInfo>();
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

            using (DataSet ds = SqlHelper.RunProcedure("attribute_value_info_getlist", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetAttributeValueModel(ds.Tables[0].Rows[i]));
                    }
                }
            }
            return list;
        }


        /// <summary>
        /// 统计符合条件总数（自定义属性信息）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int GetAttributeValueCount(string condition)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@condition", SqlDbType.NVarChar,2000)
            };
            param[0].Value = condition;
            return Convert.ToInt32(SqlHelper.RunProcedure("attribute_value_info_count", param, true));
        }

        /// <summary>
        /// 设置AttributeValueInfo值
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private AttributeValueInfo SetAttributeValueModel(DataRow dr)
        {
            AttributeValueInfo attributeInfo = new AttributeValueInfo();
            attributeInfo.ID = string.IsNullOrEmpty(dr["ID"].ToString()) ? 0 : int.Parse(dr["ID"].ToString());
            attributeInfo.AttributeID = string.IsNullOrEmpty(dr["AttributeID"].ToString()) ? 0 : int.Parse(dr["AttributeID"].ToString());
            attributeInfo.StockID = string.IsNullOrEmpty(dr["StockID"].ToString()) ? 0 : int.Parse(dr["StockID"].ToString());
            attributeInfo.Values = dr["Values"].ToString();
            return attributeInfo;
        }
    }
}
