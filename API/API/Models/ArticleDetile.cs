using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ArticleDetile
    {
        public int id { get; set; }

        public int mid { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public string time { get; set; }
    }
}