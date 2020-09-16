using System.ComponentModel.DataAnnotations;

namespace Mercury.Models
{
    public class User
    {
        [Key] public int Id { get; set; }
        [Required] [MaxLength(50)] public string address { get; set; }
        [Required] [MaxLength(50)] public string email { get; set; }
        [Required] [MaxLength(30)] public string firstname { get; set; }
        [Required] [MaxLength(30)] public string lastname { get; set; }
        [Required] [MaxLength(20)] public string password { get; set; }
        [Required] [MaxLength(20)] public string phone { get; set; }
    }
}