using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAOMINHQUANG108.model
{
    [Table("CMQ108s")]
    public class CMQ108
    {   [Key, Column(TypeName = "varchar"), StringLength(20)]
        public string CMQId { get; set; }
        [StringLength(50), Display(Name = "Tên")]
        public string CMQName { get; set; }
        [Required, Display(Name = "Giới Tính")]
        public Boolean CMQGender { get; set; }
    }
}