namespace knockoutbootstrapmodal
{
	using System.Data.Entity;

	public class UsersContext : DbContext
	{
		#region Constructors and Destructors

		public UsersContext()
			: base("DefaultConnection")
		{
		}

		#endregion

		#region Public Properties

		public DbSet<UserProfile> UserProfiles { get; set; }

		#endregion
	}
}