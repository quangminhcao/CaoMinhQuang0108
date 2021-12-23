using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaoMinhQuang108.Models
{
    public class UniversityCMQ108
    {
        [Key, Column(TypeName = "varchar"), StringLength(20), Display(Name = "ID Đại học")]
        public string UniversityId { get; set; }
        [StringLength(50), Display(Name = "Tên Đại học")]
        public string UniversityName { get; set; }
    }
}