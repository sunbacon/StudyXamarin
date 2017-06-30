using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Sample.Models.Entity;
using Sample.Models.UseCase;
using System.Threading.Tasks;
using System.Diagnostics;
using Prism.Services;
using Prism.Navigation;

namespace Sample.ViewModels
{
    
    public class UserListPageViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public Command GetUsersCommand{ get; }
        public Command BackCommand { get; }
        public Command DialogCommand { get; }

        private UserUseCase UserUseCase;

        private IPageDialogService PageDialogService;

        public UserListPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            PageDialogService = pageDialogService;

            Users = new ObservableCollection<User>();
            UserUseCase = new UserUseCase();

            GetUsersCommand = new Command(
                async () => {
                    await this.GetUsers();
                },
                () => true
            );
            BackCommand = new Command(
                async () =>
                {
                    await navigationService.GoBackAsync();
                }
            );
			DialogCommand = new Command(
				async () =>
				{
			        await pageDialogService.DisplayAlertAsync("aa", "bb", "cc", "dd");
				}
			);
        }

        async Task GetUsers() {
            
            Users.Clear();

            try {
                var users = await UserUseCase.GetAllUsers();
				foreach (var user in users)
				{
					Users.Add(user);
				}
            } catch(Exception ex) {
                Debug.WriteLine("err:" + ex);
                await PageDialogService.DisplayAlertAsync("エラー", "fail to http", "OK");
            }
        }

		public override void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("to");
            GetUsersCommand.Execute(null);
        }   

    }
}
