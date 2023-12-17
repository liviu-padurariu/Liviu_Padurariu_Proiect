using System.ComponentModel.DataAnnotations;

namespace Liviu_Padurariu_Proiect.Models
{
    public class CarMaker
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        [Display(Name = "Name")]
        public string Name
        {
            get
            {
                return Make + " " + Model;
            }
        }
    }
}
