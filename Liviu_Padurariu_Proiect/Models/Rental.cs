using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Liviu_Padurariu_Proiect.Models
{
    public class Rental
    {
        public int ID { get; set; }

        [Display(Name = "Car")]
        public int? CarID { get; set; }
        public Car? Car { get; set; }
        [Display(Name = "User")]
        public int? UserID { get; set; }
        public User? User { get; set; }
        [Display(Name = "Location")]
        public int? LocationID { get; set; }
        public Location? Location { get; set; }
        [DataType(DataType.Date)]
        public DateTime PickupDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime DropoffDate { get; set; }
    }
}
