using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Project.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]

        public string GenreName { get; set; }
        [Required]
        public List<Product> Products { get; set; }       
    }
}
