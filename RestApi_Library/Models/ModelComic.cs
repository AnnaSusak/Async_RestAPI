﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi_Library.Models
{
    public class ModelComic
    {
        public int Num { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
    }
}
