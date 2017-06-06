using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektPZ2.ViewModels
{
    public class PrzetargDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? DateOfCreate { get; set; }
        public int PrzetargCount { get; set; }
    }
}