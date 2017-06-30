using System;
using Sample.PlatFormServices;
using Sample.iOS.PlatformServices;

[assembly: Xamarin.Forms.Dependency(typeof(ValuePlatformService))]
namespace Sample.iOS.PlatformServices
{
    public class ValuePlatformService : IValuesPlatformService
    {
        public ValuePlatformService()
        {
            
        }

        public string GetServerBaseUrl() {
            return "http://localhost:5000";
        }
    }
}
