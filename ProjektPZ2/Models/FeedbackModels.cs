using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektPZ2.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public int ProfileModelsID { get; set; }
        public int OfertaModelsID { get; set; }

        public int Rating { get; set; }

        public string Image { get; set; }
        public virtual PrzetargModels PrzetargModels { get; set; }
        public virtual Feedback FeedbackModels { get; set; }

    }
}