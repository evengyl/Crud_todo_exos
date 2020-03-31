using ModelLocal.Models;
using ModelLocal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    public class GetterDataUserController : ApiController
    {
        UserServices DalUser = new UserServices();

        [Route("api/GetListUser/")]
        public List<User> GetListUser()
        {
            return DalUser.GetAll();
        }


        [Route("api/GetUser/{id:int}")]
        public User GetListUser(int id)
        {
            User OneUser = DalUser.Get(id);
            return OneUser;
        }


        [HttpPost]
        public void PostUser(User user)
        {
            DalUser.Create(user);
        }

        [HttpPut]
        public void PutUser(User user)
        {
            DalUser.Update(user);
        }


        [HttpDelete]
        [Route("api/DelUser/{id:int}")]
        public void DeleteUser(int id)
        {
            DalUser.Delete(id);
        }

        
    }
}
