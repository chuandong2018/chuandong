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
    public class StockType
    {

        /// <summary>
        /// 添加库存分类信息
        /// </summary>
        /// <param name="model">库存分类实体</param>
        /// <returns></returns>
        public int AddType(TypeInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@typename",SqlDbType.NVarChar,200),
                new SqlParameter("@depth",SqlDbType.Int),
                new SqlParameter("@parentid",SqlDbType.Int)
            };
            param[0].Value = model.TypeName;
            param[1].Value = model.Depth;
            param[2].Value = model.ParentID;
            return Convert.ToInt32(SqlHelper.RunProcedure("type_info_add", param, true));

        }

        /// <summary>
        /// 修改库存分类信息
        /// </summary>
        /// <param name="model">库存分类实体</param>
        /// <returns></returns>
        public int UpdateType(TypeInfo model)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@id",SqlDbType.Int),
                new SqlParameter("@typename",SqlDbType.NVarChar,50),
                new SqlParameter("@depth",SqlDbType.NVarChar,200),
                new SqlParameter("@parentid",SqlDbType.NVarChar,500)
            };
            param[0].Value = model.ID;
            param[1].Value = model.TypeName;
            param[2].Value = model.Depth;
            param[3].Value = model.ParentID;
            int result = -1;
            SqlHelper.RunProcedure("type_info_update", param, out result);
            return result;
        }

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public int DelType(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@id",SqlDbType.Int)
                };
            param[0].Value = id;
            int result = -1;
            SqlHelper.RunProcedure("type_info_del", param, out result);
            return result;
        }

        /// <summary>
        /// 根据条件查询库存信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<TypeInfo> GetTypeListBy(string where)
        {
            List<TypeInfo> list = new List<TypeInfo>();

            SqlParameter[] param = new SqlParameter[]{
                    new SqlParameter("@condition", SqlDbType.NVarChar,1000)
                };
            param[0].Value = where;

            using (DataSet ds = SqlHelper.RunProcedure("type_info_get", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetTypeModel(ds.Tables[0].Rows[i]));
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 根据条件获取库存分类信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderString">排序字段</param>
        /// <returns></returns>
        public IList<TypeInfo> GetTypeListPage(int pageSize, int pageStart, string where, string orderString)
        {
            List<TypeInfo> list = new List<TypeInfo>();
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

            using (DataSet ds = SqlHelper.RunProcedure("type_info_getlist", param, "ds"))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        list.Add(SetTypeModel(ds.Tables[0].Rows[i]));
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
        public int GetTypeCount(string condition)
        {

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@condition", SqlDbType.NVarChar,2000)
            };
            param[0].Value = condition;
            return Convert.ToInt32(SqlHelper.RunProcedure("type_info_count", param, true));
        }



        /// <summary>
        /// 设置StockInfo值
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private TypeInfo SetTypeModel(DataRow dr)
        {
            TypeInfo typeInfo = new TypeInfo();
            typeInfo.ID = string.IsNullOrEmpty(dr["ID"].ToString()) ? 0 : int.Parse(dr["ID"].ToString());
            typeInfo.TypeName = dr["TypeName"].ToString();
            typeInfo.Depth = string.IsNullOrEmpty(dr["Depth"].ToString()) ? 0 : int.Parse(dr["Depth"].ToString());
            typeInfo.ParentID = string.IsNullOrEmpty(dr["ParentID"].ToString()) ? 0 : int.Parse(dr["ParentID"].ToString());
            return typeInfo;
        }

    }
}
