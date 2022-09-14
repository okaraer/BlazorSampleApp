using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Entities
{

    [Table("Personel")]
    public class Personel: BaseEntity
    {
        [DefaultValue(false)]
        public bool IsFirmaYetkilisi { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adi { get; set; }

      
        [MaxLength(100)]
        public string Soyadi { get; set; }

        [MaxLength(100)]
        public string Unvani { get; set; }

        [MaxLength(50)]
        public string TelefonNumarisi { get; set; }

        [MaxLength(80)]
        public string Eposta { get; set; }


        [ForeignKey("fk_firma")]
        public Firmalar Firmalar { get; set; }

        [Required]
        public int fk_firma { get; set; }


    }
}
