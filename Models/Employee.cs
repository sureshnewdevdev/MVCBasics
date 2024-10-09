using System.ComponentModel.DataAnnotations;

namespace MVCBasics.Models
{
    public class Employee
    {
        [Display(Name ="Employee Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
    }
}
