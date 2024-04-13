namespace Hopper.Services.Data.CreateService
{
    using System.Threading.Tasks;

    using Hopper.Web.ViewModels.Create;

    public interface ICreateService
    {
       Task CreateAsync(CreateViewModel viewModel);
    }
}
