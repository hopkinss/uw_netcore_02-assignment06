using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCard.Models
{
    public class BdayCard
    {
        [Required(ErrorMessage = "Please enter To")]
        [Display(Name = "To:")]
        [StringLength(50)]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter From")]
        [Display(Name = "From:")]
        [StringLength(50)]
        public string From  { get; set; }

        [Required(ErrorMessage = "Please enter Message")]
        [Display(Name = "Message:")]
        [StringLength(150)]
        public string Msg { get; set; }

        public string SentMessage { get; set; }
    }
}
