using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.DTO
{
    public class FirmaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string FirmaAdi { get; set; }

        [DefaultValue(false)]
        public bool IsYetkiliFirma { get; set; }

        public DateTime? VizeBitisTarihi { get; set; }
        public DateTime? SertifikaBitisTarihi { get; set; }

        [MaxLength(300)]
        public string Adres { get; set; }

        [MaxLength(30)]
        public string Telefon { get; set; }

        [MaxLength(30)]
        public string Eposta { get; set; }

        [DefaultValue(0)]
        public double PerformansPuani { get; set; }

        [DefaultValue(0)]
        public double GazAcimYuzdesi { get; set; }

    }
}
