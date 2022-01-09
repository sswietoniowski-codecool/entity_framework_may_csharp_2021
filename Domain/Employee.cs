using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [NotMapped]
        public string MiddleName { get; set; }
        public PassportInfo PassportInfo { get; set; }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            return $"{EmpId}: {FirstName} {LastName} {PassportInfo}";
        }

        public bool LastNameStartsWithK()
        {
            return LastName.StartsWith("K");
        }
    }
}
