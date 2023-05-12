using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Projection
    {
        [Key]
        [DataType(DataType.Date)]
        public DateTime DateProjection { get; set; }
        public string TypeProjection { get; set;}
        [ForeignKey("Film")]
        public int FilmFk { get; set; }
        [ForeignKey("Salle")]
        public int SalleFk { get; set; }
        public virtual Film Film { get; set; }
        public virtual Salle Salle { get; set; }
    }
}
