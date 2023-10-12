using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_2.Models
{
   public class Person
    {
        public Person(string ad, string soyad, string email, string telefon, string dogum)
        {
            _ad = ad;
            _soyad = soyad;
            _email = email;
            _telefon = telefon;
            _dogum = dogum;
        }

        public string _ad { get; set; }
        public string _soyad { get; set; }
        public string _email { get; set; }
        public string _telefon { get; set; }
        public string _dogum { get; set; }

        public override string ToString()
        {
            return $"{_ad}";
        }

    }
}
