using System.Collections.Generic;
using AjaxSimpleHelper.Models;

namespace AjaxSimpleHelper
{
    public interface IDAL
    {       
        ICollection<DBPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);       
    }
}