using System.ComponentModel.DataAnnotations;

namespace Lab1200WebApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "用户名不能为空。")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空。")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

}