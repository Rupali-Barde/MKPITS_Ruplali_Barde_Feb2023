using System.ComponentModel.DataAnnotations;

namespace Annotation2.Models
{
    public class StudentDetails
    {

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage ="This Field Is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect EmailFormat")]
       public string Email { get; set; }

        [Required(ErrorMessage ="Confirm Email Is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email",ErrorMessage ="Email Not Matched")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage ="Age Is Required")]
        [Range(1,120,ErrorMessage="Age Must Be Beetween 1-120 in Years" )]
        public int Age { get; set; }

    }
}
