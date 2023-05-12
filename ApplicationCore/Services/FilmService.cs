using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class FilmService : Service<Film>
    {
        public FilmService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
            
        }

        public Film Film()
        {
            IEnumerable<Film> films = GetAll();
            Film filmax = (Film)films.Take(1);
            int max = 0;
            foreach (Film film in films)
            {
                if (film.Projections.Count() > max)
                {
                    max = film.Projections.Count();
                    filmax = film;
                }
            }
            return filmax;
        }
    }
}
