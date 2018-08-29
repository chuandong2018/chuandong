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
    public class StockAttribute
    {
        /// <summary>
        /// 添加自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int AddAttribute(AttributeInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{

                new SqlParameter("@name",SqlDbType.NVarChar,200),
                new SqlParameter("@typeID",SqlDbType.Int)
            };
            param[0].Value = model.Name;
            param[1].Value = model.TypeID;
            return Convert.ToInt32(SqlHelper.RunProcedure("attribute_info_add", param, true));

        }

        /// <summary>
        /// 修改自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int UpdateAttribute(AttributeInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@ID ",SqlDbType.Int),
                new SqlParameter("@name",SqlDbType.NVarChar,200),
                new SqlParameter("@typeID",SqlDbType.Int)
            };
            param[0].Value = model.ID;
            param[1].Value = model.Name;
            param[2].Value = model.TypeID;
            return Convert.ToInt32(SqlHelper.RunProcedure("attribute_info_update", param, true));
        }

        /// <summary>
        /// 删除修改自定义属性信息
        /// </summary>
        /// <param name="id">自定义属性id</param>
        /// <returns></returns>
        public int DelAttribute(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@id",SqlDbType.Int)
                };
            param[0].Value = id;
            int result = -1;
            SqlHelper.RunProcedure("attribute_info_del", param, out result);
            return result;
        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public AttributeInfo SelectAttribute(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@id", SqlDbType.Int)
                };
            param[0].Value = id;

            using (DataSet ds = SqlHelper.RunProcedure("attribute_info_select", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return SetAttributeModel(ds.Tables[0].Rows[0]);
                }
            }
            return null;
        }

        /// <summary>
        /// 根据条件查询自定义属性信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<AttributeInfo> GetAttributeListBy(string where)
        {
            List<AttributeInfo> list = new List<AttributeInfo>();

            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@condition", SqlDbType.NVarChar,1000)
                };
            param[0].Value = where;

            using (DataSet ds = SqlHelper.RunProcedure("attribute_info_get", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetAttributeModel(ds.Tables[0].Rows[i]));
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
        public IList<AttributeInfo> GetAttributeListPage(int pageSize, int pageStart, string where, string orderString)
        {
            List<AttributeInfo> list = new List<AttributeInfo>();
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

            using (DataSet ds = SqlHelper.RunProcedure("attribute_info_getlist", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetAttributeModel(ds.Tables[0].Rows[i]));
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
        public int GetAttributeCount(string condition)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@condition", SqlDbType.NVarChar,2000)
            };
            param[0].Value = condition;
            return Convert.ToInt32(SqlHelper.RunProcedure("attribute_info_count", param, true));
        }

        /// <summary>
        /// 设置AttributeInfo值
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private AttributeInfo SetAttributeModel(DataRow dr)
        {
            AttributeInfo attributeInfo = new AttributeInfo();
            attributeInfo.ID = string.IsNullOrEmpty(dr["ID"].ToString()) ? 0 : int.Parse(dr["ID"].ToString());
            attributeInfo.Name = dr["Name"].ToString();
            attributeInfo.TypeID = string.IsNullOrEmpty(dr["TypeID"].ToString()) ? 0 : int.Parse(dr["TypeID"].ToString());
            return attributeInfo;
        }


    }
}
