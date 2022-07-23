using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class UserService :IUser
    {
        private IUser _user;

        public UserService(IUser user)
        {
            _user = user;
        }
        public List<UserDetails> GetAll()
        {
            return _user.GetAll();
        }
        public UserDetails GetById(int id)
        {
            return _user.GetById(id);
        }
        public string AddUser(UserDetails user)
        {
            return _user.AddUser(user);
        }
        public string UpdateUser(UserDetails user)
        {
            return _user.UpdateUser(user);
        }
        public string RemoveUser(int id)
        {
            return _user.RemoveUser(id);
        }
    }
}
