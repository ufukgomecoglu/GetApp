using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GetApp.Models
{
    public partial class GetModel : DbContext
    {
        public GetModel()
            : base("name=GetModel")
        {
        }
        public virtual DbSet<Maneger> Manegers { get; set; }
        public virtual DbSet<ManegerSeniority> ManegerSeniorities { get; set; }
        public virtual DbSet<Retailer> Retailers { get; set; }
        public virtual DbSet<RetailerSeniority> RetailerSeniorities { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
