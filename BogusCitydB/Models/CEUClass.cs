﻿using Bogus.DataSets;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BogusCitydB.Models.Enums.CEUClassEnums;

namespace BogusCitydB.Data.Models
{
    public class CEUClass
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 20 characters long.")]
        [Display(Name = "Instructor First Name")]
        public string? InstructorFirstName { get; set; }

        [StringLength(25, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 25 characters long.")]
        [Display(Name = "Instructor Last Name")]
        public string? InstructorLastName { get; set; }

        [NotMapped]
        [Display(Name = "Instructor")]
        public string? InstructorFullName { get { return $"{InstructorFirstName} {InstructorLastName}"; } set { } }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name of class must be between 2 and 50 characters long.")]
        [Display(Name = "Class Title")]
        public string? NameTitle { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 2, ErrorMessage = "Description must be between 2 and 250 characters long.")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Hours of Credit")]
        public int CEUHoursAssigned { get; set; }

        [Display(Name = "Board Approval Status")]
        public ECEUClassBoardApprovalStatus BoardApprovalStatus { get; set; }
        public ECEUClassStatus ApprovalStatus { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        public DateOnly Date { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        public TimeOnly Time { get; set; }

        [StringLength(75, MinimumLength = 2, ErrorMessage = "Location name must be between 2 and 75 characters long.")]
        [Display(Name = "Location")]
        public string? LocationName { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 2, ErrorMessage = "Location address must be between 2 and 75 characters long.")]
        [Display(Name = "Address")]
        public string? LocationAddress { get; set; }

        [Display(Name = "Registration Method")]
        public ERegistrationProcedure RegistrationProcedure { get; set; }

        public virtual Provider? Provider { get; set; }
        public virtual ICollection<Licensee>? LicenseesByCEUClass { get; set; }
    }
}
