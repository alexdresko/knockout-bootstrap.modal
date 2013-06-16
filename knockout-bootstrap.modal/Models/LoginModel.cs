namespace knockoutbootstrapmodal
{
	using System.ComponentModel.DataAnnotations;

	public class LoginModel
	{
		#region Public Properties

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }

		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		#endregion
	}
}