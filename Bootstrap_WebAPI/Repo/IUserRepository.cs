using Bootstrap_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap_WebAPI.Repo
{
    public interface IUserRepository
    {
         
         IEnumerable<User> GetUsers();

         IActionResult AddUser(User userec);

        int SaveUser();
    }

    public class UserDataRepository : IUserRepository
    {
        public static List<User> userlist { get => return userlist;
            set => new List<User>(); }

        public IActionResult AddUser(User userec)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public int SaveUser()
        {
            throw new NotImplementedException();
        }
    }
}
