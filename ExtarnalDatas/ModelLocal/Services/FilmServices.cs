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
    public class FilmServices : IRepository<Film>
    {


        FilmRepository filmDal;
        public FilmServices()
        {
            filmDal = new FilmRepository();
        }

        public void Create(Film film)
        {
            filmDal.Create(film.ToGlobal());
        }

        public void Delete(int id)
        {
            filmDal.Delete(id);
        }

        public Film Get(int id)
        {
            return filmDal.Get(id).ToLocal();
        }

        public List<Film> GetAll()
        {
            return filmDal.GetAll().Select(x => x.ToLocal()).ToList();
        }

        public void Update(Film film)
        {
            filmDal.Update(film.ToGlobal());
        }

        public Film GetBy(string row, string value)
        {
            return filmDal.GetBy(row, value).ToLocal();
        }
    }
}
