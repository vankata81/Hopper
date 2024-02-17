namespace Hopper.Services.Data.CreateService
{
    using Hopper.Web.ViewModels.Create;
    using System.Threading.Tasks;

    public interface ICreateService
    {
       Task CreateAsync(CreateViewModel viewModel);
    }
}
