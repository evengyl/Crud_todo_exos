using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal = DAL2.Models;
using Local = ModelLocal.Models;

namespace ModelLocal.Utils
{
    public static class Mappers
    {
        public static Local.Film ToLocal(this Dal.Film filmDAL)
        {
            return new Local.Film
            {
                Id = filmDAL.Id,
                Titre = filmDAL.Titre,
                AnneeSortie = filmDAL.AnneeSortie,
                Genre = filmDAL.Genre
            };
        }

        public static Dal.Film ToGlobal(this Local.Film FilmLocal)
        {
            return new Dal.Film
            {
                Id = FilmLocal.Id,
                Titre = FilmLocal.Titre,
                AnneeSortie = FilmLocal.AnneeSortie,
                Genre = FilmLocal.Genre
            };
        }




        public static Local.User ToLocal(this Dal.User UserDAL)
        {
            return new Local.User
            {
                Id = UserDAL.Id,
                Login = UserDAL.Login,
                Password = UserDAL.Password,
                Active = UserDAL.Active,
                Role = UserDAL.Role
            };
        }

        public static Dal.User ToGlobal(this Local.User UserLocal)
        {
            return new Dal.User
            {
                Id = UserLocal.Id,
                Login = UserLocal.Login,
                Password = UserLocal.Password,
                Active = UserLocal.Active,
                Role = UserLocal.Role
            };
        }



        public static Local.Todo ToLocal(this Dal.Todo TodoDAL)
        {
            return new Local.Todo { 
            

                id = TodoDAL.id,
                Titre = TodoDAL.Titre,
                Description = TodoDAL.Description,
                Date = TodoDAL.Date,
                Done = TodoDAL.Done
            };
        }

        public static Dal.Todo ToGlobal(this Local.Todo TodoLocal)
        {
            return new Dal.Todo
            {
                id = TodoLocal.id,
                Titre = TodoLocal.Titre,
                Description = TodoLocal.Description,
                Date = TodoLocal.Date,
                Done = TodoLocal.Done
            };
        }
    }
}
