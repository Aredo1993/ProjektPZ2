using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektPZ2.Models
{
    
     public class Profile
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Display(Name = "Is business")]
        public bool IsBusiness { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name cannot be longer than 50 characters.")]

        [Display(Name = "First name")]
        public string Name { get; set; }


        [StringLength(50, MinimumLength = 3, ErrorMessage = "Surname cannot be longer than 50 characters.")]
        [Display(Name = "Last name")]
        public string SurnName { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        [Display(Name = "Phone number")]
        public string TelNumber { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        [Display(Name = "Apartment number")]
        public string ApartmentNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }



        public virtual ICollection<PrzetargModels> Przetargi { get; set; }
        public virtual ICollection<Feedback> FeedBack { get; set; }

        public virtual ICollection<OfertaModels> Oferty { get; set; }

    }
}