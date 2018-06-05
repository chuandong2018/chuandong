using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Article
    {
        public int id { get; set; }

        public int mid { get; set; }

        public string title { get; set; }

        public string img { get; set; }

        public int hits { get; set; }
    }
}