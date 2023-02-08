using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rentabike.Models
{
    public class AddBikeImage
    {
        public int BikeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public IFormFile Image { get; set; }
        public string Requirements { get; set; }
        public string Rules { get; set; }
        public string Weight { get; set; }
        public string Dimensions { get; set; }
        public string Material { get; set; }
        public bool Status { get; set; }
    }
}
