using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class RAM
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Тип памяти")]
        public string typeMemory { get; set; }

        [DisplayName("Частота")]
        public float frequency { get; set; }

        [DisplayName("Объем")]
        public int volune { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public RAM()
        {
            id = Guid.NewGuid().ToString();
        }

        public RAM(string typeMemory, float frequency, int volune, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            this.typeMemory = typeMemory;
            this.frequency = frequency;
            this.volune = volune;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
