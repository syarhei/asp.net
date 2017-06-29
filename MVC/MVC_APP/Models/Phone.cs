using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MVC_APP.Models {
    public class Phone {

        public Phone( string Surname,  string FirstName, string MiddleName, string PhoneNumber, DateTime BDay) {
            this.Surname = Surname;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.PhoneNumber = PhoneNumber;
            this.BDay = BDay;
        }

        public Phone() {
        }
        
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name ="Surname")]
        [StringLength(30, ErrorMessage ="Surname string must not be longer than 30 symbols")]
        public string Surname { get; set; }

        [Display(Name = "Name")]
        [StringLength(30, ErrorMessage ="Name string must not be longer than 30 symbols")]
        public string FirstName { get; set; }

        [Display(Name ="Middlename")]
        [StringLength(30, ErrorMessage ="Middlename must not be longer than 30 symbols")]
        public string MiddleName { get; set; }

        [Display(Name = "PhoneNumber")]
        [StringLength(15, ErrorMessage = "Phone number must not be longer than 30 symbols")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Birth date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode =true)]
        public DateTime BDay { get; set; }
    }
}