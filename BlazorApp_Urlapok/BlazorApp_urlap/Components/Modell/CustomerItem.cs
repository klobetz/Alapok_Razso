using System.ComponentModel.DataAnnotations;

namespace BlazorApp_urlap.Components.Modell
{
    public class CustomerItem
    {
      
        public int Id { get; set; }

        [Required (ErrorMessage ="A mezőt kötelező kitölteni")]
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? EMail { get; set; }
        public string? PhoneNmber { get; set; }
        public DateTime BirthDay { get; set; } = new DateTime(2024,01,01);
        public string? Country { get; set; }
        public string? City  { get; set; }
        public int Price { get; set; }
    }
}
