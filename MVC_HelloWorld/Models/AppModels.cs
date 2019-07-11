using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_HelloWorld.Models
{
    public class Registration
    {
        [Display(Name="Registration ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegId { get; set; }

        [Required(ErrorMessage ="*Name Required")]
        [StringLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage ="*Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Range(18,35,ErrorMessage ="Age between 18 to 35 is valid")]
        public int Age { get; set; }
    }

    [Table("login_Table")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("loginID")]
        public int LoginId { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName ="varchar(20)")]
        public string UserId { get; set; }


        [Required]
        [StringLength(15)]
        [DataType(DataType.Password)]
        [Column(TypeName = "varchar(15)")]
        public string Password { get; set; }
    }
}
