namespace knockoutbootstrapmodal
{
	using System.ComponentModel.DataAnnotations;

	public class RegisterExternalLoginModel
	{
		#region Public Properties

		public string ExternalLoginData { get; set; }

		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		#endregion
	}
}