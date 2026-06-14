using System.ComponentModel.DataAnnotations;

namespace Tools.Models
{
    public class Samples
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Year { get; set; }

        public string Logo { get; set; }

    }
}
