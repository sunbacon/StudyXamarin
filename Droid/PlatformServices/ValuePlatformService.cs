using System;
using Sample.PlatFormServices;
using Sample.Droid.PlatformServices;

[assembly: Xamarin.Forms.Dependency(typeof(ValuePlatformService))]
namespace Sample.Droid.PlatformServices
{
    public class ValuePlatformService : IValuesPlatformService
    {
        public ValuePlatformService()
        {
        }

        public string GetServerBaseUrl() {
            // AndroidエミュレータはこのIPでローカルマシンにアクセスする
            return "http://10.0.2.2:5000";
        }
    }
}
