﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vPret
{
    /// <summary>
    ///  Object for data binding to Reportldlc
    /// </summary>
    public class DetailsReport
    {
        public string NameProduit { get; set; }
        public string Sn { get; set;  }
        public string CommentProduit { get; set; }
        public string NameAcessorie { get; set; }
        public string Pn { get; set; }
        public string CommentAccessorie { get; set; }
    }
}