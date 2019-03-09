using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxSimpleHelper
{
    public class GeometryJS
    {
        public string type { get; set; }
        public double[] coordinates { get; set; }

        public GeometryJS()
        {
            coordinates = new double[2];
        }
    }
}