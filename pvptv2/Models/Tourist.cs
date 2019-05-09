using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pvptv2.Models
{
    public class Tourist
    {
        [Key]
        public int ID { get; set; } //tastezi prop, apesi tab 2 ori
        [MaxLength(30)]
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [MaxLength(300)]
        [Display(Name = "Feedback")]
        [Required(ErrorMessage = "Feedback is Required")]
        public string FeedBack { get; set; }
    }
}