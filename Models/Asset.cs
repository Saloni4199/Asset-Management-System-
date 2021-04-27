
using System.ComponentModel.DataAnnotations;

namespace AssetMS.Models
{
    public class Asset
    {

        [Required]
        public int Price { get; set; }

        public int Quantity { get; set; }

    }
}