//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace DataAccessLayer
//{
//    public class IMyDal
//    {
//    }
//}

using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IMyDal
    {
        ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
    }
}