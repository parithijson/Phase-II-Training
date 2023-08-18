using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UserJWT.Models
{
    public class User
    {
        [Key]
        [JsonIgnore]
        public int? UserId { get; set; }
        [Required]

        public string UserName { get; set; } = string.Empty;
        [Required]

        public string UserEmail { get; set; } = string.Empty;
        [Required]

        public string UserPassword { get; set; } = string.Empty;
        [Required]

        public bool isAdmin { get; set; }


    }
}
