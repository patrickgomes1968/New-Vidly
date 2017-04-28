using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name for the customer")]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        [DataType(DataType.Date)]
        //[BirthdateValidator(ErrorMessage = "Sorry, but cannot be over 110 or under 12")]
        [Min18YearsIfAMember]

        public DateTime? BirthDate { get; set; }
    }
}