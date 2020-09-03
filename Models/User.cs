using System.ComponentModel.DataAnnotations;

namespace Mercury.Models
{
    public class User
    {
        [Key]
        public int Id {get; set;}
        public string address {get; set;}
        public string email {get; set;}
        public string firstname {get; set;}
        public string lastname {get; set;}
        public string password {get; set;}
        public string phone {get; set;}
    }
}