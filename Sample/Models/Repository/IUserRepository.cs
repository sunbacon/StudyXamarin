using System;
using System.Collections.Generic;
using Sample.Models.Entity;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Sample.Models.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
    }
}
