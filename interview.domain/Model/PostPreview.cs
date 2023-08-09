﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview.domain.Model
{
    public class PostPreview
    {
        public string id { get; set; }
        public string text { get; set; }
        public string image { get; set; }
        public string likes { get; set; }
        public List<string> tags { get; set; }
        public string owner { get; set; }
        public string publishDate { get; set; }
    }
}
