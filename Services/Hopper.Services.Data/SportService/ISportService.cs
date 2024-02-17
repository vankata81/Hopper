namespace Hopper.Services.Data.SportService
{
    using System.Collections.Generic;

    public interface ISportService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}
