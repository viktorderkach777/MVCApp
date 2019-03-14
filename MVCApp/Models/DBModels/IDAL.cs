using System.Collections.Generic;

namespace MVCApp
{
    public interface IDAL
    {
        ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);

        DALPlace GetDBPlacesById(string id);

        ICollection<DALPlace> GetDBPlaces();

        bool AddPlace(DALPlace place);

        bool EditPlace(DALPlace place);

        bool RemovePlace(DALPlace place);

        ICollection<LogTable> GetLogTables();

        bool AddLogTable(LogTable logTable);
    }
}