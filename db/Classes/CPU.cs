using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class CPU
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Тактовая частота")]
        public float frequency { get; set; }

        [DisplayName("Энергопотребление")]
        public int power { get; set; }

        [DisplayName("Сокет")]
        public string socket { get; set; }

        [DisplayName("Архитектура")]
        public string archetype { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public CPU()
        {
            id = Guid.NewGuid().ToString();
        }

        public CPU(float frequency, int power, string socket, string archetype, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            this.frequency = frequency;
            this.power = power;
            this.socket = socket;
            this.archetype = archetype;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
