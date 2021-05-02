using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodDonationProject.Models
{
    public class UserInfoMetaData
    {
        public int userID { get; set; }
        [Required(ErrorMessage = "Name Can't be Empty")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Password can't be empty"),
            MinLength(6, ErrorMessage = "Minimum Length is 6"),
            MaxLength(20, ErrorMessage = "Max Length is 20")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Email can't be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number can't be empty"),
            MinLength(11, ErrorMessage = "Minimum Length is 11"),
            MaxLength(11, ErrorMessage = "Max Length is 11"),
            Range(typeof(int), "0", "01999999999", ErrorMessage = "Number only")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address can't be empty")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Date can't be empty")]
        public System.DateTime DOB { get; set; }
        [Required(ErrorMessage = "Type can't be empty")]
        public string Type { get; set; }
        public string Docoment { get; set; }
        public string ProPic { get; set; }
        [Required(ErrorMessage = "Blood Group can't be empty")]
        public string BloodGroup { get; set; }
        public Nullable<int> ReportCounter { get; set; }
        public string BanStatus { get; set; }
        public string isVerified { get; set; }
        public string darkMood { get; set; }
    }

    [MetadataType(typeof(UserInfoMetaData))]
    public partial class userInfo
    {

    }
}