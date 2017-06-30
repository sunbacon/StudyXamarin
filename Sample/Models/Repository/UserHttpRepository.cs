using System;
using System.Collections.Generic;
using Sample.Models.Entity;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

using Xamarin.Forms;
using Sample.PlatFormServices;

namespace Sample.Models.Repository
{
    public class UserHttpRepository : IUserRepository
    {
        private string baseUrl;
        public UserHttpRepository()
        {
			IValuesPlatformService valuesPlatformService = DependencyService.Get<IValuesPlatformService>();

            // android エミュレータはIPがlocalhostでは動かないためプラットフォームで区別
			baseUrl = valuesPlatformService.GetServerBaseUrl();
        }

        public async Task<List<User>> GetAllUsers() {
			try
			{
				using (var client = new HttpClient())
				{
					// http get
					string json = await client.GetStringAsync(baseUrl + "/api/users");

					return JsonConvert.DeserializeObject<List<User>>(json);
				}
			}
			catch (Exception ex)
			{
                throw ex;
			}
			finally
			{
			}
        }
    }
}
