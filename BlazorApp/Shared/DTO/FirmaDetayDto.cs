using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.DTO
{
    public class FirmaDetayDto
    {
        public FirmaDto Firma { get; set; }

        public IEnumerable<PersonelDto> PersonelListesi { get; set; }

    }
}
