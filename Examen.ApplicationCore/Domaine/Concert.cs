using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public class Concert
    {
        public double Cachet { get; set; }
        public DateTime DateConcert { get; set; }
        public int Duree { get; set; }
        public int ArtisteFk { get; set; }
        public int FestivalFk { get; set; }
        [ForeignKey("FestivalFk")]
        public virtual Festival Festival { get; set; }
        [ForeignKey("ArtisteFk")]
        public virtual Artiste Artiste { get; set; }
    }
}
