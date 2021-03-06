﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxSimpleHelper.Models
{
    public class DBPlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkRef { get; set; }
        public string LinkText { get; set; }
        public string AboutPlace { get; set; }
        public int OpenTime { get; set; }
        public int CloseTime { get; set; }       
        public int Rate { get; set; }
        public string Icon { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }       
    }
}