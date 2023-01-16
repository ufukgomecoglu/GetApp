using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GetApp.Models
{
    public class Card
    {
        public int ID { get; set; }
        public int Retailer_ID { get; set; }
        [ForeignKey("Retailer_ID")]
        public virtual Retailer Retailer { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 12, MinimumLength = 12, ErrorMessage = "12 karakter olmalıdır")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "2 karakter olmalıdır")]
        public string ReqMon { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "2 karakter olmalıdır")]
        public string ReqYear { get; set; }
    }
}