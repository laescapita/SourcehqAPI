using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourcehqAPI.Models
{
    public class OfficerTypeModel
    {
        int UtepId { get; set; }
        string FullName { get; set; }
        string Position { get; set; }
        string Chapter { get; set; }
        string Email { get; set; }
        string NormalizedEmail { get; set; }
        string Socials { get; set; }
        string ProfileImageUrl { get; set; }
        string PasswordHash { get; set; }

    }
}
