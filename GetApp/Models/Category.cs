using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace GetApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public Nullable<int> TopCategory_ID { get; set; }
        [ForeignKey("TopCategory_ID")]
        public virtual Category TopCategory { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Alan Boş Bırakılamaz")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Category> Categoryies { get; set; }
    }
}