using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using CD.ChuanDong.Stock.RemotingServer.IBLL;


namespace CD.ChuanDong.Stock.BLL
{
    public class Remoting
    {
        #region Remoting

        public static IStock RemoteObject()
        {
            return (IStock)Activator.GetObject(typeof(IStock), ReportRemoteUrl);
            //return (IStock)new ChuanDong.Stock.RemotingServer.BLL.Stock();
        }

        private static string ReportRemoteUrl
        {
            get
            {
                if (ConfigurationManager.AppSettings[""] != null)
                    return ConfigurationManager.AppSettings[""];
                return "tcp://192.168.1.231:8100/Stock";
            }
        }

        #endregion
    }
}
