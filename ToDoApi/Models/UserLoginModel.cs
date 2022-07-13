using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Models
{
    public class UserLoginModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
