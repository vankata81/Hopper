namespace Hopper.Services.Data.SportService
{
    using System.Collections.Generic;

    using Hopper.Data.Models;
    using Hopper.Web.ViewModels.PracticeListViewModel;

    public interface ISportService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        int GetCount();

        T GetById<T>(int id);
    }
}
