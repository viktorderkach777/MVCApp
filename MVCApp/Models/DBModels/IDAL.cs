using System.Collections.Generic;
using System.Linq;

namespace MVCApp
{
    public interface IDAL
    {
        ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
    }


}