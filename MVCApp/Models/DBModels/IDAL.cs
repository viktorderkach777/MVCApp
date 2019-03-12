using System.Collections.Generic;

namespace MVCApp
{
    public interface IDAL
    {
        ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
    }
}