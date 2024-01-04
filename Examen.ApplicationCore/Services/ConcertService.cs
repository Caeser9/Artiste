using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domaine;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ConcertService : Service<Concert>, IConcertService
    {
        public ConcertService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Concert> GetConcertsByMusicalTypes(StyleMusical style)
        {
            return GetAll().Where(c=>c.Artiste.Chansons.Any(ch=>ch.StyleMusic.Equals(style)));
        }
    }
}
