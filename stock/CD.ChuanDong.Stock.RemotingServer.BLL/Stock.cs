using CD.ChuanDong.Stock.RemotingServer.IBLL;
using CD.ChuanDong.Stock.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD.ChuanDong.Stock.RemotingServer.BLL
{
    public class Stock : MarshalByRefObject, IStock
    {
        #region 库存信息
        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="stock">库存实体</param>
        /// <returns></returns>
        public int AddStock(StockInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().AddStock(model);
        }

        /// <summary>
        /// 修改库存信息
        /// </summary>
        /// <param name="model">库存信息实体</param>
        /// <returns></returns>
        public int UpdateStock(StockInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().UpdateStock(model);
        }

        /// <summary>
        /// 增加点击数
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public int AddHits(int id, int hits)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().AddHits(id, hits);
        }

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public int DelStock(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().DelStock(id);
        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public StockInfo SelectStock(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().SelectStock(id);
        }

        /// <summary>
        /// 根据条件查询库存信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<StockInfo> GetStockListBy(string where)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().GetStockListBy(where);
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
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().GetStockListPage(pageSize, pageStart, where, orderString);
        }

        /// <summary>
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int GetStockCount(string condition)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.Stock().GetStockCount(condition);
        }
        #endregion

        #region 库存产品图片信息
        /// <summary>
        /// 添加库存产品图片
        /// </summary>
        /// <param name="model">库存产品图片实体</param>
        /// <returns></returns>
        public int AddStockPhoto(StockPhotoInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockPhoto().AddStockPhoto(model);

        }



        /// <summary>
        /// 修改库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public int UpdateStockPhoto(int id, int cover)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockPhoto().UpdateStockPhoto(id, cover);

        }

        /// <summary>
        /// 删除库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public int DelStockPhoto(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockPhoto().DelStockPhoto(id);

        }

        /// <summary>
        /// 根据ID查询库存产品图片
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        public IList<StockPhotoInfo> GetStockPhotoList(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockPhoto().GetStockPhotoList(id);
        }
        #endregion

        #region 库存分类信息
        /// <summary>
        /// 添加库存分类信息
        /// </summary>
        /// <param name="model">库存分类实体</param>
        /// <returns></returns>
        public int AddType(TypeInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockType().AddType(model);

        }

        /// <summary>
        /// 修改库存分类信息
        /// </summary>
        /// <param name="model">库存分类实体</param>
        /// <returns></returns>
        public int UpdateType(TypeInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockType().UpdateType(model);
        }

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存id</param>
        /// <returns></returns>
        public int DelType(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockType().DelType(id);
        }

        /// <summary>
        /// 根据条件查询库存信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<TypeInfo> GetTypeListBy(string where)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockType().GetTypeListBy(where);

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
            return new ChuanDong.Stock.RemotingServer.DAL.StockType().GetTypeListPage(pageSize, pageStart, where, orderString);
        }


        /// <summary>
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int GetTypeCount(string condition)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockType().GetTypeCount(condition);
        }
        #endregion

        #region  自定义属性信息
        /// <summary>
        /// 添加自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int AddAttribute(AttributeInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().AddAttribute(model);

        }

        /// <summary>
        /// 修改自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int UpdateAttribute(AttributeInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().UpdateAttribute(model);

        }

        /// <summary>
        /// 删除修改自定义属性信息
        /// </summary>
        /// <param name="id">自定义属性id</param>
        /// <returns></returns>
        public int DelAttribute(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().DelAttribute(id);

        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public AttributeInfo SelectAttribute(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().SelectAttribute(id);

        }

        /// <summary>
        /// 根据条件查询自定义属性信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<AttributeInfo> GetAttributeListBy(string where)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().GetAttributeListBy(where);

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
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().GetAttributeListPage(pageSize, pageStart, where, orderString);

        }


        /// <summary>
        /// 统计符合条件总数（自定义属性信息）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int GetAttributeCount(string condition)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttribute().GetAttributeCount(condition);

        }
        #endregion

        #region 自定义属性值信息
        /// <summary>
        /// 添加自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int AddAttributeValues(AttributeValueInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().AddAttributeValues(model);

        }

        /// <summary>
        /// 修改自定义属性信息
        /// </summary>
        /// <param name="model">自定义属性实体</param>
        /// <returns></returns>
        public int UpdateAttributeValues(AttributeValueInfo model)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().UpdateAttributeValues(model);

        }

        /// <summary>
        /// 删除修改自定义属性值信息
        /// </summary>
        /// <param name="id">自定义属性值id</param>
        /// <returns></returns>
        public int DelAttributeValues(string where)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().DelAttributeValues(where);

        }

        /// <summary>
        /// 根据库存信息id查询详细
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public AttributeValueInfo SelectAttributeValues(int id)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().SelectAttributeValues(id);

        }

        /// <summary>
        /// 根据条件查询自定义属性信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns></returns>
        public IList<AttributeValueInfo> GetAttributeValueListBy(string where)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().GetAttributeValueListBy(where);


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
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().GetAttributeValuesList(pageSize, pageStart, where, orderString);

        }


        /// <summary>
        /// 统计符合条件总数（自定义属性信息）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int GetAttributeValueCount(string condition)
        {
            return new ChuanDong.Stock.RemotingServer.DAL.StockAttributeValues().GetAttributeValueCount(condition);

        }
        #endregion

    }
}
