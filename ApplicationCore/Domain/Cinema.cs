using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public string Localisation { get; set; }
        [ForeignKey("Salle")]
        public int SalleFk { get; set; }
        public virtual ICollection<Salle> Salles { get; set; }

    }
}
