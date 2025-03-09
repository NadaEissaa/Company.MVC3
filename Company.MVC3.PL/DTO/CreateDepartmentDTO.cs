using System.ComponentModel.DataAnnotations;

namespace Company.MVC3.PL.DTO
{
    public class CreateDepartmentDTO
    {

        [Required (ErrorMessage = "Code is Required !")]
        public int Code { get; set; }
        [Required(ErrorMessage = "Name is Required !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "CreateAt is Required !")]
        public DateTime CreateAt { get; set; }
    }
}
