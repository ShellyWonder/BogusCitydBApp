using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BogusCitydB.Models.Enums.LicenseeEnums;

namespace BogusCitydB.Data.Models;

public class Licensee : CEUser
{
    [Key]
    
    [Required]
    [StringLength(7, MinimumLength = 1, ErrorMessage = "License must be between 1 and 7 numbers long.")] //adds attribute to restrict licenseNumber property to range of 1-5 chars
    [Display(Name = "License Number")]
    public string? LicenseNumber { get; set; }
      public string? ShopId { get; set; } = null;

    [Display(Name = "Employer Tracking Permission")]
    public bool ShopAccessPermission { get; set; } = false;
    public bool EmploymentChange { get; set; } = false;
    
    [DisplayFormat(DataFormatString = "{0:yyyy}")]
    [Display(Name = "Year License Attained")]
    public DateOnly YearLicenseAttained { get; set; }

    [Required]
    [Display(Name = "License Type")]
    public ELicenseType LicenseType { get; set; }

    [Required]
    [Display(Name = "Exempt Status")]
    public EExemptStatus ExemptStatus { get; set; }

    [Required]
    [Display(Name = "License Status")]
    public ELicenseStatus LicenseStatus { get; set; }
    [Display(Name = "Employment Status")]
    public EEmploymentStatus EmploymentStatus { get; set; }

    //allows for lazy loading
    //establishes a navigation property
    public virtual Shop? Shop { get; set; }
    public virtual Provider? Provider { get; set; }
    public virtual CEUClass? CEUClasses { get; set; }
    

    /*example of lazy loading in JPA(Java Persistence API):
     *@Entity
        public class Licensee { 
            @Id
            @GeneratedValue(strategy = GenerationType.IDENTITY)
            private Long id;
            private String name;

            @ManyToOne(fetch = FetchType.LAZY)
            private Shop shop; 
        } 
     */

    public List<ELicenseStatus> LicenseStatusList { get; set; } = new()
    {
        ELicenseStatus.Active,
        ELicenseStatus.Inactive,
        ELicenseStatus.Suspended,
        ELicenseStatus.Revoked,
        ELicenseStatus.Expired
    };

    public List<EExemptStatus> ExemptStatusList { get; } = new()
    {
        EExemptStatus.BoardDispensation,
        EExemptStatus.SchoolInstructor,
        EExemptStatus.PlumbingInspector,
        EExemptStatus.Retired,
        EExemptStatus.Other
    };
    public List<ELicenseType> LicenseTypeList { get; } = new()
    {
        ELicenseType.JourneymanPlumber,
        ELicenseType.MasterPlumber,
        ELicenseType.SewerLayer,
        ELicenseType.WaterConditioner,
        ELicenseType.LawnSprinklers
    };
    public List<EEmploymentStatus>? EmploymentStatusList { get; } = new()
    {
        EEmploymentStatus.Employed,
        EEmploymentStatus.Unemployed,
        EEmploymentStatus.ShopOwner,
        EEmploymentStatus.Retired
    };
}
