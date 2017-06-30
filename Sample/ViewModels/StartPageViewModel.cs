using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Prism.Services;
using Prism.Navigation;

namespace Sample.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        public Command NavigateCommand { get; }

        public StartPageViewModel(INavigationService navigationService)
        {
            this.NavigateCommand = new Command(async () => await navigationService.NavigateAsync("UserListPage"));
        }
    }
}
