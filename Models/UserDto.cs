using System.ComponentModel.DataAnnotations;

namespace Rejestracja.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250,ErrorMessage ="Imie nie moze przekraczać 250 znaków.")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "Email nie moze przekraczać 250 znaków.")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [StringLength(250, ErrorMessage = "Nazwisko nie moze przekraczać 250 znaków.")]
        [Required]
        public string LastName { get; set; }

        public int CityId { get; set; }

    }
}
