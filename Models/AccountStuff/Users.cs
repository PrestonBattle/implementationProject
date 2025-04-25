using Microsoft.AspNetCore.Identity;

namespace ThriveHavenMovies.Models.AccountStuff
{
    public class Users : IdentityUser<Guid>  // Ensure IdentityUser<Guid> here
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
