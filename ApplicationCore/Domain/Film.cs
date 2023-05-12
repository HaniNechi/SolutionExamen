using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum TypeFilm
    {
        Fiction, Action, Comédie, Autre
    }
    public class Film
    {
        [Key]
        public int FilmId { get; set; }
        public string Titre { get; set; }
        public double Duree { get; set; }
        public DateTime DateRealisation { get; set; }
        public double Prix { get; set; }
        public TypeFilm TypeFilm { get; set; }
        public virtual IList<Projection> Projections { get; set; }

    }
}
