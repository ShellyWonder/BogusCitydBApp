using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BogusCitydB.Data.Enums;

namespace BogusCitydB.Data.Models;

public class Licensee : CEUser
{
    [Key]
    
    public int Id { get; set; }

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
    public LicenseType LicenseType { get; set; }

    [Required]
    [Display(Name = "Exempt Status")]
    public ExemptStatus ExemptStatus { get; set; }

    [Required]
    [Display(Name = "License Status")]
    public LicenseStatus LicenseStatus { get; set; }
    [Display(Name = "Employment Status")]
    public EmploymentStatus EmploymentStatus { get; set; }

    //allows for lazy loading
    //establishes a navigation property
    public virtual Shop? Shop { get; set; }

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

    public List<LicenseStatus> LicenseStatusList { get; set; } = new()
    {
        LicenseStatus.Active,
        LicenseStatus.Inactive,
        LicenseStatus.Suspended,
        LicenseStatus.Revoked,
        LicenseStatus.Expired
    };

    public List<ExemptStatus> ExemptStatusList { get; } = new()
    {
        ExemptStatus.BoardDispensation,
        ExemptStatus.SchoolInstructor,
        ExemptStatus.PlumbingInspector,
        ExemptStatus.Retired,
        ExemptStatus.Other
    };
    public List<LicenseType> LicenseTypeList { get; } = new()
    {
        LicenseType.JourneymanPlumber,
        LicenseType.MasterPlumber,
        LicenseType.SewerLayer,
        LicenseType.WaterConditioner,
        LicenseType.LawnSprinklers
    };
    public List<EmploymentStatus>? EmploymentStatusList { get; } = new()
    {
        EmploymentStatus.Employed,
        EmploymentStatus.Unemployed,
        EmploymentStatus.ShopOwner,
        EmploymentStatus.Retired
    };
}
