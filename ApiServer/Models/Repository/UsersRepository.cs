using System;
using System.Collections.Generic;
using Npgsql;
using ApiServer.Models.Entity;

namespace ApiServer.Models.Repository
{
    public class UsersRepository : IUsersRepository
    {
		private string connString;

        public UsersRepository()
        {
            connString = @"Server=localhost;Port=5411;User Id=postgres;Password=mysecretpassword;Database=postgres";
        }

		public List<User> GetAll()
		{
			var ret = new List<User>();
			using (var conn = new NpgsqlConnection(connString))
			{
				conn.Open();
				var command = new NpgsqlCommand(@"select * from users", conn);
				var dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
                    var user = new User();
                    user.Name = dataReader["name"].ToString();
                    user.Password = dataReader["password"].ToString();
                    user.Email = dataReader["email"].ToString();
                    user.Id = dataReader["id"].ToString();
                    ret.Add(user);
				}
			}

			return ret;
		}
    }
}
