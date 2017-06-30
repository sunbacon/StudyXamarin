using System;
using System.Collections.Generic;

using ApiServer.Models.Entity;

namespace ApiServer.Models.Repository
{
    public interface IUsersRepository
    {
        List<User> GetAll();
    }
}
