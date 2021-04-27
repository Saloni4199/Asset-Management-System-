
using System.ComponentModel.DataAnnotations;

namespace AssetMS.Models
{
    public class Software : Asset
    {
        [Required]
        public int SoftwareId { get; set; }
        public string Name { get; set; }


    }
}