
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BloodDonationProject.Models
{

using System;
    using System.Collections.Generic;
    
public partial class donorRating
{

    public int rateId { get; set; }

    public int userID { get; set; }

    public Nullable<int> oneStar { get; set; }

    public Nullable<int> twoStar { get; set; }

    public Nullable<int> threeStar { get; set; }

    public Nullable<int> fourStar { get; set; }

    public Nullable<int> fiveStar { get; set; }



    public virtual userInfo userInfo { get; set; }

}

}
