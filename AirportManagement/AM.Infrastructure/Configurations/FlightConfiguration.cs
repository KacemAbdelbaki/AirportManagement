using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // Config ManyToMany
            builder.HasMany(f => f.Passengers)
                .WithMany(p => p.Flights)
                .UsingEntity(j => j.ToTable("ReservationFlightPassenger"));

            // Config OneToMany
            builder.HasOne(f => f.Plane)
                .WithMany(p => p.Flights)
                .HasForeignKey(f => f.Plane.PlaneId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
