using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using ApiServer.Models.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository UserRepository;

        public UsersController(IUsersRepository userRepository) {
            UserRepository = userRepository;
        }

        // GET: api/users
        [HttpGet]
        public string Get()
        {
            var users = UserRepository.GetAll();
            return JsonConvert.SerializeObject(users);
        }

    }
}
