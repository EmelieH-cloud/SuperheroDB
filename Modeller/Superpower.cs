using System.ComponentModel.DataAnnotations;

namespace SuperheroDB.Modeller
{
    public class Superpower
    {
        [Key]
        public int SuperpowerId { get; set; }
        public string? Name { get; set; }
        public List<SuperheroSuperpowers>? SuperheroSuperpowers { get; set; }
    }
}
