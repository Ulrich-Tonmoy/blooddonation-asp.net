//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Xml.Serialization;
namespace BloodDonation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class report
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }
        public string Report1 { get; set; }

        public int DonorID { get; set; }
        public int UserID { get; set; }


        // public virtual userinfo userInfo { get; set; }
        //public virtual userinfo userInfo1 { get; set; }

        [NotMapped]
        List<Link> links = new List<Link>();
        [NotMapped]
        public List<Link> Links { get { return links; } }
    }
}
