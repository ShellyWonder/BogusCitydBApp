namespace BogusCitydB.Data.Enums
{
    public enum EmploymentStatus
    {
        Employed,
        //I am substituting shop owner for self-employed.
        //Per client ordinance, shop owners must be licensed as a master plumber
        //or their business is overseen by a master plumber.
        //Therefore, plumbers who consider themselves self-employed are operating
        //as a shop owner & must utilize a master plumber license to conduct business.
        ShopOwner, 
        Unemployed,
        Retired
        
    }
}
