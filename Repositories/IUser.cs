using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface IUser
    {
        public List<UserDetails> GetAll();
        public UserDetails GetById(int id);
        public string AddUser(UserDetails user);
        public string UpdateUser(UserDetails user);
        public string RemoveUser(int id);
    }
}
