using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektPZ2.Models
{
    public class OfertaModels
    {
        public int ID { get; set; }
        public int PrzetargModelsID { get; set; }

        public double OfferPrice { get; set; }

        public int ProfileModelsID { get; set; }

        public DateTime DateOfCreate { get; set; }

        public virtual PrzetargModels PrzetargModels { get; set; }

        public virtual Profile ProfilModels { get; set; }
    }
}