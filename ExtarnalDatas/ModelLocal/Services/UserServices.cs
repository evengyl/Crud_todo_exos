using DAL2.IRepositories;
using DAL2.Services;
using Dal = DAL2.Models;

using ModelLocal.Models;
using ModelLocal.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLocal.Services
{
    public class UserServices : IRepository<User>
    {


        UserRepository userDal;
        public UserServices()
        {
            userDal = new UserRepository();
        }

        public void Create(User user)
        {
            userDal.Create(user.ToGlobal());
        }

        public void Delete(int id)
        {
            userDal.Delete(id);
        }

        public User Get(int id)
        {
            return userDal.Get(id).ToLocal();
        }

        public List<User> GetAll()
        {
            return userDal.GetAll().Select(x => x.ToLocal()).ToList();
        }

        public void Update(User user)
        {
            userDal.Update(user.ToGlobal());
        }

        public User GetBy(string row, string value)
        {
            return userDal.GetBy(row, value).ToLocal();
        }

        public void SetUser(int id)
        {
            userDal.SetUser(id);
        }

        public void SetAdmin(int id)
        {
            userDal.SetAdmin(id);
        }

    }
}
