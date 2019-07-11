using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootstrap_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserAPIController : Controller
    {
        public static List<User> userList = new List<User>();
        public UserAPIController()
        {
            if(userList.Count==0)
            {
                userList.Add(new Models.User { ID = 1, Name = "Pushkar", Age = 30 });
            }
        }
        
        [HttpGet]
        [Produces("application/json")]
        public JsonResult GetUsers()
        {
            return Json(userList);
        }

        [HttpPost]
        public IActionResult PostUser(User userrec)
        {
            if(userrec!=null)
            {
                userrec.ID = userList.Max(x => x.ID) + 1;
                userList.Add(userrec);
                return Ok(new {data=userrec, message = "Data is added" });

            }
            return BadRequest(new {message="Data Invalid"  });
        }
        [HttpPut]
        public IActionResult PutUser(User newrec)
        {
            if(newrec!=null)
            {
                var rec = userList.Where(x => x.ID == newrec.ID).FirstOrDefault();
                if (rec != null)
                {
                    rec.Name = newrec.Name;
                    rec.Age = newrec.Age;
                    return Ok(new { message = "Record Updated" });
                }
                return NotFound(new { message = "User Id Not Found" });
            }
            return BadRequest(new { message = "Data Invalid" });
        }

        [HttpDelete]
        public IActionResult DeleteUser(int userid)
        {
            if(userid>0)
            {
               userList.Remove(userList.FirstOrDefault(x => x.ID == userid));
                return Ok();
            }
            return BadRequest();
        }
    }
}