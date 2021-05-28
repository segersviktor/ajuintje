using Microsoft.EntityFrameworkCore;
using MyKafka.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyKafka.DataAccess
{
    public class MyKafkaDbContext : DbContext
    {
        public MyKafkaDbContext(DbContextOptions<MyKafkaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Association> Associations { get; set; }
        public DbSet<AssociationType> AssociationTypes { get; set; }
        public DbSet<AssociationUnit> AssociationUnits { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<CertificateLog> CertificateLogs { get; set; }
        public DbSet<CertificateReceiver> CertificateReceivers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // get custom configurations from assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyKafkaDbContext).Assembly);
            modelBuilder.Entity<AssociationType>().HasData(new AssociationType { Id = 1, Name = "Scouts en Gidsen Vlaanderen" });
            modelBuilder.Entity<AssociationType>().HasData(new AssociationType { Id = 2, Name = "Chirojeugd Vlaanderen" });
            modelBuilder.Entity<CertificateReceiver>().HasData(new CertificateReceiver
            { Id = 1, Name = "Christelijke Mutualiteit" }, new CertificateReceiver { Id = 2, Name = "Nationale Verbond van Socialistische Mutualiteiten" });

            modelBuilder.Entity<Association>().HasData(new Association
            {
                Id = 1,
                Name = "Scouts 92ste",
                Slug = "scouts-92ste",
                MemberFee = 45,
                AssociationTypeId = 1,
            });

            modelBuilder.Entity<AssociationUnit>().HasData(new List<AssociationUnit>
            {
                new AssociationUnit
                {
                    Id = 1,
                    Name = "Paloebies",
                    CampStartDate = new DateTime(2021, 07, 07),
                    CampEndDate = new DateTime(2021, 07, 12),
                    AssociationId = 1,
                    GroupIndex = 1

                },
                new AssociationUnit
                {
                    Id = 2,
                    Name = "Wolven",
                    AssociationId = 1,
                    GroupIndex = 2
                },
                new AssociationUnit
                {
                    Id = 3,
                    Name = "Poema's",
                    AssociationId = 1,
                    GroupIndex = 3
                },
                new AssociationUnit
                {
                    Id = 4,
                    Name = "JV/PV",
                    AssociationId = 1,
                    GroupIndex = 4
                },
                new AssociationUnit
                {
                    Id = 5,
                    Name = "Kevins",
                    AssociationId = 1,
                    GroupIndex = 5
                },
                new AssociationUnit
                {
                    Id = 6,
                    Name = "Jins",
                    AssociationId = 1,
                    GroupIndex = 6
                }
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<CertificateLog>())
            {
                entry.Entity.DateCreated = entry.State switch
                {
                    EntityState.Added => DateTime.Now,
                    _ => entry.Entity.DateCreated
                };
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
