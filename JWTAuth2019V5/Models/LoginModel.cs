using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth2019V5.Models
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Username is required")]
		public string userName { get; set; }
		[Required(ErrorMessage = "Password is required")]
		public string password { get; set; }
	}
}
