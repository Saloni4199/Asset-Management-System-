
using System.ComponentModel.DataAnnotations;

namespace AssetMS.Models
{
    public class Hardware : Asset
    {
        [Required]
        public int HardwareId { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }


    }
}