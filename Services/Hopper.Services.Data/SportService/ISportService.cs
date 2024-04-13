namespace Hopper.Services.Data.SportService
{
    using System.Collections.Generic;

    using Hopper.Web.ViewModels.PracticeListViewModel;

    public interface ISportService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<PracticeinListViewModel> GetAll(int page, int itemsPerPage = 12);
    }
}
