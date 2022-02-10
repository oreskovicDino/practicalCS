namespace EFDataAccessLibrary.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Email
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string EmailAddress { get; set; }
    }
}
