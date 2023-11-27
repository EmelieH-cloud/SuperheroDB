using SuperheroDB.Modeller;

namespace SuperheroDB.Databas
{
    public class HeroesRepository
    {
        private readonly myDbContext myContext;

        public HeroesRepository(myDbContext context)
        {
            myContext = context;
        }

        // En metod för att hämta alla hjältar från databasen
        public List<Superhero> GetAll()
        {
            return myContext.Heroes.ToList();
        }

        // En metod för att hämta en hjälte utifrån id från databasen
        public Superhero? GetById(int id)
        {
            return myContext.Heroes.FirstOrDefault(h => h.SuperheroId == id);
        }

        // En metod för att lägga till en hjälte i databasen
        public void Add(Superhero hero)
        {
            myContext.Heroes.Add(hero);
        }


        // En metod för att ta bort en hjälte i databasen
        public void Delete(int id)
        {
            Superhero? heroToDelete = myContext.Heroes.FirstOrDefault(h => h.SuperheroId == id);

            if (heroToDelete != null)
            {
                myContext.Heroes.Remove(heroToDelete);
            }
        }
    }
}
