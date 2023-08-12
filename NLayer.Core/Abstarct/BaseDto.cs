﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Abstarct
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public double? Number1 { get; set; }
        public double? Number2 { get; set; }
        public double? Number3 { get; set; }
        public double? Number4 { get; set; }
        public double? Number5 { get; set; }
        public string? Explanation1 { get; set; }
        public string? Explanation2 { get; set; }
        public string? Explanation3 { get; set; }
        public string? Explanation4 { get; set; }
        public string? Explanation5 { get; set; } 
        public DateTime CreateDate { get; set; }  
        public DateTime UpdateDate { get; set; }   
        public bool Status { get; set; }  
    }
}
