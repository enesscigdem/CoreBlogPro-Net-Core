using System;
using Microsoft.AspNetCore.Identity;

namespace YoutubeBlog.Entity.Entities
{
	public class AppRole : IdentityRole<Guid>
    {
		public AppRole()
		{
		}
	}
}

