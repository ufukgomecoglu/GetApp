using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetApp.Models
{
    public class Retailer
    {
        public int ID { get; set; }
        public int RetailerSeniority_ID { get; set; }
        [ForeignKey("RetailerSeniority_ID")]
        public virtual RetailerSeniority RetailerSeniority { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 200, ErrorMessage = "En fazla 50 karakter olabilir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "Şifre 8 ile 20 karakter arasında olmalıdır")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 250, ErrorMessage = "En fazla 250 karakter olabilir")]
        public string Mail { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}