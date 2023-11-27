using Microsoft.EntityFrameworkCore;
using SuperheroDB.Modeller;

namespace SuperheroDB.Databas
{
    public class myDbContext : DbContext
    {

        // Ett DbSet för varje tabell. 
        public DbSet<Superhero> Heroes { get; set; }
        public DbSet<Superpower> Powers { get; set; }

        public DbSet<SuperheroSuperpowers> superPowers { get; set; }


        // OnConfiguring: 
        // Här lägger vi till vår connection string. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Kommer skapas en databas på servern med detta namnet.
            // Ibland vill man spara strängen som en fil också för att dölja den. 
            optionsBuilder.UseSqlServer("Server=USER-PC\\SQLEXPRESS;Database=SuperHeroDB;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Explicit definition för many-to-many, composite key. 
            modelBuilder.Entity<SuperheroSuperpowers>().HasKey(sc => new { sc.SuperheroId, sc.SuperpowerId });


            modelBuilder.Entity<Superpower>().HasData(
       new Superpower { SuperpowerId = 1, Name = "Super Strength" },
       new Superpower { SuperpowerId = 2, Name = "Flight" },
       new Superpower { SuperpowerId = 3, Name = "Telekinesis" }

   );

            modelBuilder.Entity<Superhero>().HasData(
                new Superhero
                {
                    SuperheroId = 1,
                    Name = "Wonder Woman",
                    SecretIdentity = "Diana Prince",
                    ImageUrl = "Images/wonderwoman.jpg"
                },
                new Superhero
                {
                    SuperheroId = 2,
                    Name = "Superman",
                    SecretIdentity = "Clark Kent",
                    ImageUrl = "Images/superman.jpg"
                }

            );

            modelBuilder.Entity<SuperheroSuperpowers>().HasData(
                new SuperheroSuperpowers { SuperheroId = 1, SuperpowerId = 1 },
                new SuperheroSuperpowers { SuperheroId = 1, SuperpowerId = 2 },
                new SuperheroSuperpowers { SuperheroId = 2, SuperpowerId = 1 }

            );
        }
    }
}
