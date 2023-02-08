using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Bike
    {
        [Key]
        public int BikeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Requirements { get; set; }
        public string Rules { get; set; }
        public string Weight { get; set; }
        public string Dimensions { get; set; }
        public string Material { get; set; }
        public bool Status { get; set; }
        public List<ReserveBikeMessage> ReserveBikeMessages { get; set; }

    }
}
