namespace knockoutbootstrapmodal
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("UserProfile")]
	public class UserProfile
	{
		#region Public Properties

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }

		public string UserName { get; set; }

		#endregion
	}
}