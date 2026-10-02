using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TravelTripProje.Models.Sınıflar
{
    public class Yorum
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorums { get; set; }
        public int Blogid { get; set; } 
        public virtual Blog Blog { get; set; }
    }
}