using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth2019V5.Models
{
	public class ResetPasswordViewModel
	{
		[Required(ErrorMessage = "Username is required")]
		public string username { get; set; }
		[Required(ErrorMessage = "New Password is required")]
		public string newPassword { get; set; }
		[Required(ErrorMessage = "Confirm Password is required")]
		public string confirmPassword { get; set; }

		public string token { get; set; }
	}
}
