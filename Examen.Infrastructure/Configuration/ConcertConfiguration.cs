using Examen.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configuration
{
    public class ConcertConfiguration : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.HasOne(c => c.Artiste)
                .WithMany(a => a.Concerts)
                .HasForeignKey(c => c.ArtisteFk);
            builder.HasOne(c => c.Festival)
                .WithMany(f => f.ConcertList)
                .HasForeignKey(c => c.FestivalFk);
            builder.HasKey(c => new
            {
                c.FestivalFk,
                c.ArtisteFk,
                c.DateConcert
            });
        }
    }
}
