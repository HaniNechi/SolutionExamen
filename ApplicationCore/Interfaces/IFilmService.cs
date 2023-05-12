using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    internal class IFilmService : IService<Film>
    {
        public void Add(Film entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Film entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Film, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Film Get(Expression<Func<Film, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetAll()
        {
            throw new NotImplementedException();
        }

        public Film GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetMany(Expression<Func<Film, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Film entity)
        {
            throw new NotImplementedException();
        }
    }
}
