using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class PowerBlock
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Мощность")]
        public int power { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public PowerBlock()
        {
            id = Guid.NewGuid().ToString();
        }

        public PowerBlock(int power, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            this.power = power;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
}
