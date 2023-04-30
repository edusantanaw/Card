using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infra.Db
{
    public class CardDbContext : DbContext
    {

        public CardDbContext(DbContextOptions<CardDbContext> options) : base(options) { }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Card>(c =>
            {
                c.HasKey(cd => cd.Id);

                c.Property(cd => cd.Title)
                    .IsRequired(true)
                    .HasColumnName("title");
                c.Property(cd => cd.Description)
                    .IsRequired(true)
                    .HasColumnName("description");
                c.Property(cd => cd.List)
                    .IsRequired(true)
                    .HasColumnName("list");

            });

        }

    }

}