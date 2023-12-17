using System.ComponentModel.DataAnnotations;

namespace Liviu_Padurariu_Proiect.Models
{
    public class User
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu majuscula (ex. Ion sau Ion Alexandru sau IonAlexandru")]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Numele trebuie sa inceapa cu majuscula (ex. Popescu")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        [Display(Name = "FullName")]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public string Email { get; set; }

        [RegularExpression(@"^0\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123'")]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
