
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
    
public partial class userInfo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public userInfo()
    {

        this.BloodBooks = new HashSet<BloodBook>();

        this.donorRatings = new HashSet<donorRating>();

        this.FlagPosts = new HashSet<FlagPost>();

        this.Posts = new HashSet<Post>();

        this.reports = new HashSet<report>();

        this.reports1 = new HashSet<report>();

        this.RequestBloods = new HashSet<RequestBlood>();

        this.RequestBloods1 = new HashSet<RequestBlood>();

        this.Salaries = new HashSet<Salary>();

    }


    public int userID { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public System.DateTime DOB { get; set; }

    public string Type { get; set; }

    public string Docoment { get; set; }

    public string ProPic { get; set; }

    public string BloodGroup { get; set; }

    public Nullable<int> ReportCounter { get; set; }

    public string BanStatus { get; set; }

    public string isVerified { get; set; }

    public string darkMood { get; set; }

    public Nullable<int> Salary { get; set; }

    public Nullable<System.DateTime> LastDonate { get; set; }

    public string Gender { get; set; }

    public string NID { get; set; }

    public string Social_Profile { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BloodBook> BloodBooks { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<donorRating> donorRatings { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FlagPost> FlagPosts { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Post> Posts { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<report> reports { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<report> reports1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RequestBlood> RequestBloods { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RequestBlood> RequestBloods1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Salary> Salaries { get; set; }

    public virtual userInfo userInfo1 { get; set; }

    public virtual userInfo userInfo2 { get; set; }

    public virtual userInfo userInfo11 { get; set; }

    public virtual userInfo userInfo3 { get; set; }

}

}
