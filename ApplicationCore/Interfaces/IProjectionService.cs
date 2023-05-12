using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    internal class IProjectionService : IService<Projection>
    {
        public void Add(Projection entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Projection entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Projection, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Projection Get(Expression<Func<Projection, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projection> GetAll()
        {
            throw new NotImplementedException();
        }

        public Projection GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Projection> GetMany(Expression<Func<Projection, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Projection entity)
        {
            throw new NotImplementedException();
        }
    }
}
