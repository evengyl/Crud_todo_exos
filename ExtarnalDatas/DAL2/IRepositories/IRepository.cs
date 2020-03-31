using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2.IRepositories
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();

        TEntity Get(int id);

        TEntity GetBy(string row, string value);

        void Create(TEntity t);

        void Delete(int id);

        void Update(TEntity t);
    }
}
