using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ReserveBikeMessage
    {
        [Key]
        public int MessageId { get; set; }
        public string ClientFullname { get; set; }
        public string ClientPhone { get; set; }
        public string ClientMail { get; set; }
        public string ClientMessage { get; set; }
        public bool Status { get; set; }
        public DateTime MessageDate { get; set; }
        public int BikeId { get; set; }
        public Bike Bike { get; set; }
    }
}
