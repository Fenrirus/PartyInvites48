namespace PartyInvites48.Models
{
    using System.ComponentModel.DataAnnotations;

    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać imię i nazwisko")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Proszę podać prawidłowy email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Proszę podać nr telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Czy weźmiesz udział")]
        public bool? WillAttend { get; set; }
    }
}