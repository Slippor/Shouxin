using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ShouxinServer.Common;

namespace ShouxinServer.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        [Required]
        [Display(Name = "帐户名")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public override List<string> CustomCssPathes
        {
            get
            {
                return new List<string>() {
                    StyleConfigs.RegisterCssVirtualPath
                };
            }
            set
            {
                base.CustomCssPathes = value;
            }
        }
    }
}