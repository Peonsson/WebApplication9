using WebApplication9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace WebApplication9.Controllers
{
    public class UsersController : ApiController
    {
        User[] users = new User[]
        {
            new Models.User {Id = 1, LastLogin = DateTime.Now, Register = DateTime.Now, Status = "Online" },
            new Models.User {Id = 2, LastLogin = DateTime.Now, Register = DateTime.Now, Status = "Away" },
            new Models.User {Id = 3, LastLogin = DateTime.Now, Register = DateTime.Now, Status = "Busy" },
            new Models.User {Id = 4, LastLogin = DateTime.Now, Register = DateTime.Now, Status = "Offline" }
        };

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public IHttpActionResult GetUser(int id)
        {
            var user = users.FirstOrDefault((p) => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
