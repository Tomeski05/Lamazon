using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lamazon.WebModels.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please insert username!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please insert upassword!")]
        public string Password { get; set; }

    }
}
