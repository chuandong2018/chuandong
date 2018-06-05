using API.Models;
using ChuanDong.Robot.RemotingServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class RobotBasiceController : ApiController
    {
        /// <summary>
        /// 获取所有杂志内容
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MagazineList> GetAllMagazine()
        {
            IList<MagazineList> allList = new List<MagazineList>();
            int y = DateTime.Now.Year;
            for (int i = y; i > 2013; i--)
            {
                MagazineList ml = new MagazineList();
                IList<Magazine> list = new List<Magazine>();
                string where = " and ischecked=1 and CONVERT(nvarchar(30),joindate,121) like '%" + i + "%'";
                IList<MagazineInfo> mList = ChuanDong.Robot.BLL.Magazine.GetMagazineList(-1, 1, -1, where);
                int count = mList.Count;
                for (int j = 0; j < count; j++)
                {
                    Magazine m = new Magazine();
                    m.mid = mList[j].ID.ToString();
                    m.name = mList[j].Title.IndexOf("期") == -1 ? mList[j].Title.Substring(5).Replace("月", "") + "期" : mList[j].Title.Substring(5).Replace("月", "");
                    m.title = i + "年度" + mList[j].Title.Substring(5) + "刊";
                    m.img = mList[j].FrontCover;
                    list.Add(m);
                }
                ml.Year = i.ToString();
                ml.MazList = list;
                allList.Add(ml);
            }
            return allList;
        }
        /// <summary>
        /// 获取所有文章
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Article> GetAllAEticle(int id, string cate)
        {
            IList<Article> aList = new List<Article>();
            string where = " and  CategoryID<>10 and magazineid=" + id;
            //if (!string.IsNullOrEmpty(cate))
            //{
            //    int cateid = int.Parse(cate);
            //    if (cateid == 1)
            //    {
            //        where += " and (categoryid=7 or categoryid=43 or categoryid=14)";
            //    }
            //    if (cateid == 2)
            //    {
            //        where += " and (categoryid=39 or categoryid=33 or categoryid=29)";
            //    }
            //    if (cateid == 3)
            //    {
            //        where += " and (categoryid=19 or categoryid=24)";
            //    }
            //}
            //else
            //{
            //    where += " and (categoryid=7 or categoryid=43 or categoryid=14 or categoryid=39 or categoryid=33 or categoryid=29 or categoryid=19 or categoryid=24)";
            //}
           // int count = ChuanDong.Control.BLL.Article.GetArticleCount(where);
            IList<ArticleInfo> list = ChuanDong.Robot.BLL.Article.GetArticleList(-1, 1, -1, where, " joindate desc");
            for (int i = 0; i < list.Count; i++)
            {
                Article article = new Article();
                article.id = list[i].ID;
                article.mid = list[i].CategoryID;
                article.title = list[i].Title;
                article.img = list[i].FrontCover;
                article.hits = list[i].Hits;
                aList.Add(article);
            }
            return aList;
        }
        /// <summary>
        /// 获取杂志详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ArticleDetile GetArticleByID(int id)
        {
            ArticleDetile article = new ArticleDetile();
            ArticleInfo info = ChuanDong.Robot.BLL.Article.GetArticle(id);
            article.id = info.ID;
            article.mid = info.CategoryID;
            article.time = info.Joindate.ToString();
            article.title = info.Title;
            article.content = info.Content;
            return article;
        }
        /// <summary>
        /// 获取幻灯广告
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AD> GetSlideAD(int id)
        {
            IList<AD> aList = new List<AD>();
            IList<CommendInfo> list = ChuanDong.Robot.BLL.Commend.GetCommendList(-1, 1, -1, " and moduleid=8 and magazineid=" + id);
            for (int i = 0; i < list.Count; i++)
            {
                AD ad = new AD();
                ad.id = list[i].ID;
                ad.img = list[i].Img;
                ad.title = list[i].Title;
                ad.url = list[i].URL;
                ad.adimg = list[i].Description;
                aList.Add(ad);
            }
            return aList;
        }
        /// <summary>
        /// 获取企业广告广告
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AD> GetEntAD(int id, int mid)
        {
            IList<AD> aList = new List<AD>();
            IList<MobileADInfo> list = ChuanDong.Robot.BLL.MobileAD.GetMobileADList(-1, 1, -1, " and moduleid=" + mid + " and articleid=" + id);
            for (int i = 0; i < list.Count; i++)
            {
                AD ad = new AD();
                ad.id = list[i].ID;
                ad.img = list[i].PhotoURL;
                ad.title = list[i].Title;
                ad.url = list[i].URL;
                aList.Add(ad);
            }
            return aList;
        }
        /// <summary>
        /// 获取企业广告
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AD> GetEntADList(int mid)
        {
            IList<AD> aList = new List<AD>();
            IList<CommendInfo> list = ChuanDong.Robot.BLL.Commend.GetCommendList(-1, 1, -1, " and moduleid=9 and magazineid=" + mid);
            for (int i = 0; i < list.Count; i++)
            {
                AD ad = new AD();
                ad.id = list[i].ID;
                ad.img = list[i].Img;
                ad.title = list[i].Title;
                ad.url = list[i].URL;
                ad.adimg = list[i].Description;
                aList.Add(ad);
            }
            return aList;
        }
        /// <summary>
        /// 获取相关阅读信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public IEnumerable<ArticleDetile> GetDetailMore(int id, int cid)
        {
            IList<ArticleDetile> articleList = new List<ArticleDetile>();
            string where = " and ischecked=1 and CategoryID=" + cid + " and id<>" + id;
            IList<ArticleInfo> list = ChuanDong.Robot.BLL.Article.GetArticleList(3, 1, 3, where, " joindate desc");
            for (int i = 0; i < list.Count; i++)
            {
                ArticleDetile article = new ArticleDetile();
                article.id = list[i].ID;
                article.mid = list[i].CategoryID;
                article.time = list[i].Joindate.ToString();
                article.title = list[i].Title;
                article.content = list[i].FrontCover;
                articleList.Add(article);
            }
            return articleList;
        }
    }
}
