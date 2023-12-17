using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Liviu_Padurariu_Proiect.Models
{
    public class Car
    {
        public int ID { get; set; }
        public int? CarMakerID { get; set; }

        [Display(Name = "Maker")]
        public CarMaker? CarMaker { get; set; }

        [Display(Name = "Color")]
        public int? ColorID { get; set; }
        public Color? Color { get; set; }

        [Display(Name = "Transmission Type")]
        public int? TransmissionID { get; set; }
        public Transmission? Transmission { get; set; }
        public int Seats { get; set; }

        [Column(TypeName = "numeric(5,0)")]
        [Range(100, 10000)]
        public int Price { get; set; }
        public int HP { get; set; }
    }
}
