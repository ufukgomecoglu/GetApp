using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace GetApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        [StringLength(maximumLength: 75, ErrorMessage = "Bu alan en fazla 75 karakter olmalıdır")]
        public string Name { get; set; }
        [Display(Name = "Ürün Açıklama")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Ham Fiyat")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        public decimal RawPrice { get; set; }
        [Display(Name = "Kar Oranı")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        [Range(0.0, 1, ErrorMessage = "0 ile 1 arasında ve virgülden sonra maksimum 4 sayı giriniz")]
        [DisplayFormat(DataFormatString = "{0:n4}")]
        public decimal Profit { get; set; }
        [Display(Name = "İndirim Oranı")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        [Range(0.0, 1, ErrorMessage = "0 ile 1 arasında ve virgülden sonra maksimum 4 sayı giriniz")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal Discount { get; set; }
        [Display(Name = "Hesaplanan Kar")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal CalculatedProfit { get; set; }
        [Display(Name = "KDV Oranı")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal KDV { get; set; }
        [Display(Name = "Toplam Fiyat")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal TotalPrice { get; set; }
        [Display(Name = "Icon")]
        [StringLength(maximumLength: 150)]
        public string IconPath { get; set; }
        public bool IsActive { get; set; }
    }
}