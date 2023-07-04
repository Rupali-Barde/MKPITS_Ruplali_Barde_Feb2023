using System.ComponentModel.DataAnnotations;

namespace Annotation.Models
{
    public class StudentModel
    {

        [Required(ErrorMessage ="This Field Is Required")]
        [StringLength(50,MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email ID Is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+[a-z0-9.-]+\.[a-z]{2,4}",ErrorMessage ="Incorrect Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age Is Mandatory field")]
        [Range(1,120,ErrorMessage ="Age Must Be Between 1-120 In Years.")]
        public int Age { get; set; }    
            

    }
}
