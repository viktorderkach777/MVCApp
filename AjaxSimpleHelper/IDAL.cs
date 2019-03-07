using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AjaxSimpleHelper.Models;

namespace AjaxSimpleHelper
{
    public interface IDAL
    {
        ICollection<DBPlace> GetDBPlacesByParams(string icon, string time, string rate);
        ICollection<DBPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
        ICollection<DBPlace> GetDBPlacesByIcon(string icon);
        ICollection<DBPlace> GetDBPlacesById(string Id);
    }
}