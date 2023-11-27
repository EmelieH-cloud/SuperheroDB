using System.ComponentModel.DataAnnotations;

namespace SuperheroDB.Modeller
{
    public class Superhero
    {
        [Key]
        public int SuperheroId { get; set; }
        public string? Name { get; set; }
        public string? SecretIdentity { get; set; }
        public string? ImageUrl { get; set; }
        public List<SuperheroSuperpowers>? SuperheroSuperpowers { get; set; }
    }

}
