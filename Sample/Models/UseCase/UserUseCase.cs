using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Sample.Models.Entity;
using Sample.Models.Repository;

namespace Sample.Models.UseCase
{
    public class UserUseCase
    {
        protected IUserRepository UserRepository;

        public UserUseCase()
        {
            UserRepository = new UserHttpRepository();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await UserRepository.GetAllUsers();
        }       
    }
}
