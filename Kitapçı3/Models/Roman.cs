using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kitapçı3.Models
{
    public class Roman
    {
        [Key]
        public int ID { get; set; }
        public string Kitapad { get; set; }
        public int Fiyat { get; set; }
        public string Yayınevi { get; set; }
        public int Tarih { get; set; }
        public string Yazar { get; set; }
        public string Hakkında { get; set; }
    }
}
