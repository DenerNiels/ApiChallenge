using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ApiChallenge.Models
{
    public class User
    {
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }

        public string AcessToken { get; set; }
    }
}
