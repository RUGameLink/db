using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class VideoCard
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Графический CPU")]
        public string GCPU { get; set; }

        [DisplayName("Объем памяти")]
        public int volumeMemory { get; set; }

        [DisplayName("Тип памяти")]
        public string typeMemory { get; set; }

        [DisplayName("Частота памяти")]
        public float frequencyMemory { get; set; }

        [DisplayName("Мощность")]
        public int power { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public VideoCard()
        {
            id = Guid.NewGuid().ToString();
        }

        public VideoCard(string gCPU, int volumeMemory, string typeMemory, float frequencyMemory, int power, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            GCPU = gCPU;
            this.volumeMemory = volumeMemory;
            this.typeMemory = typeMemory;
            this.frequencyMemory = frequencyMemory;
            this.power = power;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
