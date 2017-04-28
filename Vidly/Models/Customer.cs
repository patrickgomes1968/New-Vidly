using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name for the customer")]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Birth Date")]
        [DataType(DataType.Date)]
        //[BirthdateValidator(ErrorMessage = "Sorry, but cannot be over 110 or under 12")]
        [Min18YearsIfAMember]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? BirthDate { get; set; }
    }
}