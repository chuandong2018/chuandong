using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class MagazineList
    {
        public string Year { get;set;}

        public IList<Magazine> MazList { get; set; }
    }
}