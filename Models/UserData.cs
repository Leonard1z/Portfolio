using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Work { get; set; }
        public string Description { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string AboutMeDescription { get; set; }

    }
}
