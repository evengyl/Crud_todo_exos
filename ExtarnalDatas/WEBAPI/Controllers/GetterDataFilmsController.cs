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
    /// <summary>
    /// Permet de controller les films
    /// </summary>
    public class GetterDataFilmsController : ApiController
    {
        FilmServices DalFilm = new FilmServices();

        [Route("api/GetListFilm/")]
        public List<Film> GetListFilm()
        { 
            return DalFilm.GetAll();
        }

        [Route("api/GetFilm/{id:int}")]
        public Film GetFilm(int id)
        {
            Film Onefilm = DalFilm.Get(id);
            return Onefilm;
        }

        [HttpPost]
        [Route("api/PostFilm")]
        public void PostFilm(Film film)
        {
            DalFilm.Create(film);
        }


        [HttpPut]
        [Route("api/PutFilm")]
        public void PutFilm(Film film)
        {
            DalFilm.Update(film);
        }

        /// <summary>
        /// Test
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("api/DeleteFilm/{id:int}")]
        public void DeleteFilm(int id)
        {
            DalFilm.Delete(id);
        }

    }
}
