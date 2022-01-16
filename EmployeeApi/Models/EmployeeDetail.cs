using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApi.Models
{
    public class EmployeeDetail


    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Department { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Branch { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Doj { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Preference { get; set; }
    }
}
