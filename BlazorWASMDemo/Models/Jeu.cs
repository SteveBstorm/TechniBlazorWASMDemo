using System.ComponentModel.DataAnnotations;

namespace BlazorWASMDemo.Models
{
    public class Jeu
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Genre { get; set; }
        //[Required]
        [MinLength(10)]
        public string Description { get; set; }
    }
}
