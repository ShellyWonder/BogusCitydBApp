﻿using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class Shop : CEUser  
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Business name must be between 1 and 50 characters long.")]
        [Display(Name = "Legal Business Name")]
        public string BusinessName { get; set; } = null!;

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Business name must be between 1 and 50 characters long.")]
        [Display(Name = "Doing Business As Name")]
        public string? DBAName { get; set; }

        public int ShopLicenseNumber { get; set; }

        //sets up the relationship between the shop and the licensees
        public virtual ICollection<LicenseeUser>? ShopLicensees { get; set; }
        public virtual ICollection<LicenseeUser>? ShopLicenseesByType { get; set; }

        /*example of lazy loading in JPA(Java Persistence API):
    *@Entity
       public class Shop { 
            @Id
            @GeneratedValue(strategy = GenerationType.IDENTITY)
            private Long id;
            private String name;

            @OneToMany(mappedBy = "shop")
            private List<Licensee> licensees; 
            }
        */


    }
}
