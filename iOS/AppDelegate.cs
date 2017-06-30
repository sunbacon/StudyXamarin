using Foundation;
using UIKit;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace Sample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

			var application = new App(new iOSInitializer());
			LoadApplication(application);

            return base.FinishedLaunching(app, options);
        }
    }

	public class iOSInitializer : IPlatformInitializer
	{
		public void RegisterTypes(IUnityContainer container)
		{

		}
	}
}
