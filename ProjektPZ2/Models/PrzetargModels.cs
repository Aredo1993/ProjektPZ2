using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektPZ2.Models
{
    public class PrzetargModels
    {
        public int ID { get; set; }
        public int ProfileID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfCreate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DateOfEnd { get; set; }



        // public virtual PrzetargModels PrzetargiModels { get; set; }

        public virtual ICollection<OfertaModels> Oferty { get; set; }

        public virtual Profile ProfileModels { get; set; }
    }
}