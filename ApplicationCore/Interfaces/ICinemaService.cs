using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    internal class ICinemaService : IService<Cinema>
    {
        public void Add(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Cinema, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Cinema Get(Expression<Func<Cinema, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cinema> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cinema GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cinema> GetMany(Expression<Func<Cinema, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Cinema entity)
        {
            throw new NotImplementedException();
        }
    }
}
