using System.Data.Common;
using System.ComponentModel.DataAnnotations;
namespace mvcProject.Models
{
    public class Employee
    {   
        static int count=2;
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Gender { get; set; }

    public Employee(){
        Id=count;
        count++;
    }    


    }
}