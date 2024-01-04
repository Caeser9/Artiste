using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public class Chanson
    {
        [Key]
        public int ChansonId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }
        public int Duree { get; set; }
        public string StyleMusic { get; set; }
        [MaxLength(12), MinLength(3)]
        public string Titre { get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="Nombre de vue doit etre positive")]
        public int VuesYoutube { get; set; }
        public virtual int ArtisteFk { get; set; }
        [ForeignKey("ArtisteFk")]
        public virtual Artiste Artiste { get; set; }
        
    }
}
