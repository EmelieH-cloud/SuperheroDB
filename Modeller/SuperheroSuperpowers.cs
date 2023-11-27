using System.ComponentModel.DataAnnotations;

namespace SuperheroDB.Modeller
{
    public class SuperheroSuperpowers
    {
        [Key]
        public int SuperheroId { get; set; }
        public Superhero Superhero { get; set; } = null!;

        [Key]
        public int SuperpowerId { get; set; }
        public Superpower Superpower { get; set; } = null!;

    }
}