using BlazorApp.Data.Entities;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.FakeData
{
    public static class FakeSeedData
    {
        public static Faker<Firmalar> FirmaFaker;
        public static Faker<Personel> PersonelFaker;

        public static List<Firmalar> Firma { get; set; }
        public static List<Personel> Personel { get; set; }

        public static void Init()
        {

            DateTime startDate = new DateTime(2022, 8, 1);
            DateTime endDate = new DateTime(2023, 8, 1);
            var meslekler = new[] { "Makina Mühendisi", "Tesisatçı", "Teknisyen", "Tekniker", "Mühendis" };

            //firma
            var firmaIds = 1;
            FirmaFaker = new Faker<Firmalar>("tr")
               .StrictMode(true)
               .RuleFor(m => m.Id, f => firmaIds++)
               .RuleFor(m => m.FirmaAdi, f => f.Company.CompanyName())
               .RuleFor(m => m.Adres, f => f.Address.State() + " " + f.Address.StreetAddress(true) + " " + f.Address.City())
               .RuleFor(m => m.Eposta, f => f.Internet.Email())
               .RuleFor(m => m.Telefon, f => f.Phone.PhoneNumber())
               .RuleFor(m => m.IsYetkiliFirma, f => f.Random.Bool())
               .RuleFor(m => m.SertifikaBitisTarihi, f => f.Date.Between(startDate, endDate))
               .RuleFor(m => m.VizeBitisTarihi, f => f.Date.Between(startDate, endDate))
               .RuleFor(m => m.GazAcimYuzdesi, f => f.Random.Double(0, 100))
               .RuleFor(m => m.PerformansPuani, f => f.Random.Double(0, 100))
               .RuleFor(m => m.CreationTime, f => f.Date.Between(startDate, endDate))
               .RuleFor(m => m.DeletionTime, f => f.Date.Between(startDate, endDate))
               .RuleFor(m => m.IsDeleted, false);

            Firma = FirmaFaker.Generate(30);



            //personel
            var personelIds = 1;
            PersonelFaker = new Faker<Personel>("tr")
               .StrictMode(false)
               .RuleFor(m => m.Id, f => personelIds++)
               .RuleFor(m => m.Adi, f => f.Person.FirstName)
               .RuleFor(m => m.Soyadi, f => f.Person.LastName)
               .RuleFor(m => m.Eposta, f => f.Internet.Email())
               .RuleFor(m => m.TelefonNumarisi, f => f.Phone.PhoneNumber())
               .RuleFor(m => m.Unvani, f => meslekler[f.Random.Int(0, 4)])
               .RuleFor(m => m.IsFirmaYetkilisi, f => f.Random.Bool())
               .RuleFor(m => m.CreationTime, f => f.Date.Between(startDate, endDate))
               .RuleFor(m => m.DeletionTime, f => f.Date.Between(startDate, endDate))
               .RuleFor(m => m.IsDeleted, f => false)
               .RuleFor(m => m.fk_firma, f => f.PickRandom(Firma).Id);


            Personel = PersonelFaker.Generate(100);
        }
    }
}
