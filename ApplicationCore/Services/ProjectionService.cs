using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ProjectionService : Service<Projection>
    {
        public ProjectionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
