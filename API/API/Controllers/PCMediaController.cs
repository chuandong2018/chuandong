using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class PCMediaController : ApiController
    {
        //
        // GET: /PCMedia/

         /// <summary>
        /// 获取所有杂志内容
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Magazine> GetAllMagazine(int typeId)
        {
            IList<Magazine> mList = new List<Magazine>();
            string where = "";//" and CONVERT(nvarchar(30),joindate,121) like '%" + year + "%'";
            if (typeId == 1)//控制
            {
                where += "and magazinetype='control'";
            }
            if (typeId == 2)//伺服
            {
                where += "and magazinetype='servo'";
            }
            if (typeId == 3)//机器人
            {
                where += "and magazinetype='robot'";
            }
            IList<ChuanDong.Magazine.RemotingServer.Model.MagazineInfo> list = ChuanDong.Magazine.BLL.Magazine.GetMagazineList(-1, 1, -1, where);
            for (int i = 0; i < list.Count; i++)
            {
                Magazine m = new Magazine();
                m.img = list[i].ImgURL;
                m.mid = list[i].ID.ToString();
                m.title = list[i].Title;
                m.name = list[i].MagazineType;
                mList.Add(m);
            }
            return mList;
        }

    }
}
