using System.Collections.Generic;
using System.Linq;

namespace MVCApp
{
    public interface IDAL
    {
        ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
        DALPlace GetDBPlacesById(string id);

        ICollection<DALPlace> GetDBPlaces();

        bool AddPlace(DALPlace place);

        bool EditPlace(DALPlace place);
    }


}