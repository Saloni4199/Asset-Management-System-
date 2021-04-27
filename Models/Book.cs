
using System.ComponentModel.DataAnnotations;
namespace AssetMS.Models
{
    public class Book : Asset
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        public int ISBN { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }


    }
}