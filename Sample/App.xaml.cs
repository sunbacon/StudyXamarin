using Sample.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace Sample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync(nameof(StartPage));
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<StartPage>();
			Container.RegisterTypeForNavigation<UserListPage>();
		}
    }
}
