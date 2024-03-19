using System.ComponentModel.DataAnnotations;

namespace BlazorApp_urlap.Components.Modell
{
    public class CustomerItem
    {
      
        public int Id { get; set; }

        [Required (ErrorMessage = "A mezőt kötelező kitölteni")]
        public string? FName { get; set; }

        [Required]
        public string? LName { get; set; }

        [Required]
        [EmailAddress (ErrorMessage ="Nem megfelelő e-mail cím!")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}$", ErrorMessage = "Érvénytelen e-mail formátum.")]
        public string? EMail { get; set; }

        [Required]
        [StringLength(12, MinimumLength =3, ErrorMessage ="A mező hossza minimum 3 karakter és maximum 12 karaktert tartalmazhet.")]
        public string? PhoneNmber { get; set; }

        [Required]
        [Range(typeof(DateTime),"1920-01-01","2024-01-01",ErrorMessage ="A dátum 1920.01.01-2024.01.01 -ig adható meg")]
        public DateTime BirthDay { get; set; } = new DateTime(2000,01,01); //DateTime.Now;

        public string? Country { get; set; }

        public string? City  { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage ="Az árat 0 és 100 között határozhatod meg")]
        public int Price { get; set; }

        //teljes név megadása
        public string GetFullname()
        {
            //return FName+" "+LName; //ez a hagyományos megközelítés
            return $"{FName} {LName}"; //string interpoláció
        }

        //életkor kiszámítása
        public int Age()
        {
            //évszámítás          
            int age = DateTime.Now.Year - BirthDay.Year;

            if (DateTime.Now.Month < BirthDay.Month || (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
            {
                age--;
            }
            return age;
            //return (int)DateTime.Now.Year-BirthDay.Year ;
        }



    }
}
