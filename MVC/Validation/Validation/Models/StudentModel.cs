using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="Name Is Required.It Cannot Be Empty")] 
            
        public string UserName { get;set ; } 
    }
}
