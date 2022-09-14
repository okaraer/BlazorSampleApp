using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.DTO
{
    public class PersonelDto
    {

        public int Id { get; set; }

        [DefaultValue(false)]
        public bool IsFirmaYetkilisi { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adi { get; set; }


        [MaxLength(100)]
        public string Soyadi { get; set; }

        [MaxLength(200)]
        public string AdiSoyadi { get; set; }

        [MaxLength(100)]
        public string Unvani { get; set; }

        [MaxLength(50)]
        public string TelefonNumarisi { get; set; }

        [MaxLength(80)]
        public string Eposta { get; set; }


        public FirmaDto Firmalar { get; set; }

        public int fk_firma { get; set; }
    }
}
