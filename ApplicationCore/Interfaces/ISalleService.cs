using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    internal class ISalleService : IService<Salle>
    {
        public ISalleService()
        {
        }

        void IService<Salle>.Add(Salle entity)
        {
            throw new NotImplementedException();
        }

        void IService<Salle>.Commit()
        {
            throw new NotImplementedException();
        }

        void IService<Salle>.Delete(Salle entity)
        {
            throw new NotImplementedException();
        }

        void IService<Salle>.Delete(Expression<Func<Salle, bool>> where)
        {
            throw new NotImplementedException();
        }

        Salle IService<Salle>.Get(Expression<Func<Salle, bool>> where)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Salle> IService<Salle>.GetAll()
        {
            throw new NotImplementedException();
        }

        Salle IService<Salle>.GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Salle> IService<Salle>.GetMany(Expression<Func<Salle, bool>> where)
        {
            throw new NotImplementedException();
        }

        void IService<Salle>.Update(Salle entity)
        {
            throw new NotImplementedException();
        }
    }
}
