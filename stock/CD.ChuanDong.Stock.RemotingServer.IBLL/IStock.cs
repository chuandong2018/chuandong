using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CD.ChuanDong.Stock.RemotingServer.Model;
namespace CD.ChuanDong.Stock.RemotingServer.IBLL
{
    public interface IStock
    {
        #region 库存信息
        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="stock">库存实体</param>
        /// <returns></returns>
        int AddStock(StockInfo stock);

        /// <summary>
        /// 修改库存信息
        /// </summary>
        /// <param name="stock">库存实体</param>
        /// <returns></returns>
        int UpdateStock(StockInfo stock);

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        int DelStock(int id);

        /// <summary>
        /// 根据ID获取库存详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        StockInfo SelectStock(int id);

        /// <summary>
        /// 增加点击率
        /// </summary>
        /// <param name="id">库存id</id>
        /// <param name="hits">每次点击增加的点击量</param>

        /// <returns></returns>
        int AddHits(int id, int hits);

        /// <summary>
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        int GetStockCount(string condition);

        /// <summary>
        /// 根据条件获取库存信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="orderStr">数据排序字段</param>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<StockInfo> GetStockListPage(int pageSize, int pageStart, string where, string orderStr);


        /// <summary>
        /// 根据条件获取库存信息
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<StockInfo> GetStockListBy(string where);

        #endregion

        #region 库存产品图片信息
        /// <summary>
        /// 添加库存产品图片
        /// </summary>
        /// <param name="stockPhotoInfo">库存产品图片实体</param>
        /// <returns></returns>
        int AddStockPhoto(StockPhotoInfo stockPhotoInfo);


        /// <summary>
        /// 更新库存产品图片
        /// </summary>
        /// <param name="stockID">库存ID</param>
        /// <returns></returns>
        int UpdateStockPhoto(int id, int cover);


        /// <summary>
        /// 删除库存产品图片
        /// </summary>
        /// <param name="stockID">库存ID</param>
        /// <returns></returns>
        int DelStockPhoto(int stockID);

        /// <summary>
        /// 根据ID查询库存产品图片
        /// </summary>
        /// <param name="stockID">库存ID</param>
        /// <returns></returns>
        IList<StockPhotoInfo> GetStockPhotoList(int stockID);
        #endregion

        #region 库存分类信息
        /// <summary>
        /// 添加库存分类信息
        /// </summary>
        /// <param name="type">库存实体</param>
        /// <returns></returns>
        int AddType(TypeInfo type);

        /// <summary>
        /// 修改库存信息
        /// </summary>
        /// <param name="type">库存实体</param>
        /// <returns></returns>
        int UpdateType(TypeInfo type);

        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="id">库存ID</param>
        /// <returns></returns>
        int DelType(int id);

        ///// <summary>
        ///// 根据ID获取库存详细信息
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //StockInfo SelectStock(int id);

        /// <summary>
        /// 统计符合条件总数库存信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        int GetTypeCount(string condition);

        /// <summary>
        /// 根据条件获取库存信息并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="orderStr">数据排序字段</param>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<TypeInfo> GetTypeListPage(int pageSize, int pageStart, string where, string orderStr);

        /// <summary>
        /// 根据条件获取库存信息
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<TypeInfo> GetTypeListBy(string where);

        #endregion

        #region 库存产品自定义属性信息
        /// <summary>
        /// 添加库存产品自定义属性信息
        /// </summary>
        /// <param name="attribute">自定义属性实体</param>
        /// <returns></returns>
        int AddAttribute(AttributeInfo attribute);

        /// <summary>
        /// 修改库存产品自定义属性信息
        /// </summary>
        /// <param name="attribute">自定义属性实体</param>
        /// <returns></returns>
        int UpdateAttribute(AttributeInfo attribute);

        /// <summary>
        /// 删除库存产品自定义属性信息
        /// </summary>
        /// <param name="id">自定义属性ID</param>
        /// <returns></returns>
        int DelAttribute(int id);

        /// <summary>
        /// 根据ID获取库存产品自定义属性信息
        /// </summary>
        /// <param name="id">自定义属性ID</param>
        /// <returns></returns>
        AttributeInfo SelectAttribute(int id);

        /// <summary>
        /// 根据条件获取库存库存产品自定义属性并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="orderStr">数据排序字段</param>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<AttributeInfo> GetAttributeListPage(int pageSize, int pageStart, string where, string orderStr);

        /// <summary>
        /// 统计符合条件总数（自定义属性信息）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        int GetAttributeCount(string condition);


        /// <summary>
        /// 根据条件获取库存信息
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<AttributeInfo> GetAttributeListBy(string where);

        #endregion

        #region 库存产品自定义属性值信息

        /// <summary>
        /// 添加库存产品自定义属性值信息
        /// </summary>
        /// <param name="attributeValue">自定义属性值实体</param>
        /// <returns></returns>
        int AddAttributeValues(AttributeValueInfo attributeValue);

        /// <summary>
        /// 修改库存产品自定义属性值信息
        /// </summary>
        /// <param name="attributeValue">自定义属性值实体</param>
        /// <returns></returns>
        int UpdateAttributeValues(AttributeValueInfo attributeValue);

        /// <summary>
        /// 删除库存产品自定义属性值信息
        /// </summary>
        /// <param name="id">自定义属性值ID</param>
        /// <returns></returns>
        int DelAttributeValues(string where);

        /// <summary>
        /// 根据ID获取库存产品自定义属性值信息
        /// </summary>
        /// <param name="id">自定义属性值ID</param>
        /// <returns></returns>
        AttributeValueInfo SelectAttributeValues(int id);

        /// <summary>
        /// 根据条件获取库存库存产品自定义属性值并分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="pageStart">当前第几页</param>
        /// <param name="orderStr">数据排序字段</param>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<AttributeValueInfo> GetAttributeValuesList(int pageSize, int pageStart, string where, string orderStr);


        /// <summary>
        /// 获取总数（自定义属性值）
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        int GetAttributeValueCount(string condition);

        /// <summary>
        /// 根据条件获取库存信息
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        IList<AttributeValueInfo> GetAttributeValueListBy(string where);
        #endregion


    }
}
