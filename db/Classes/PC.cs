using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class PC
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Процессор")]
        public CPU cpu { get; set; }

        [DisplayName("Видеокарта")]
        public VideoCard videoCard { get; set; }

        [DisplayName("Блок питания")]
        public PowerBlock powerBlock { get; set; }

        [DisplayName("RAM")]
        public RAM ram { get; set; }

        [DisplayName("Материнская плата")]
        public MotherBoard motherBoard { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public PC()
        {
            id = Guid.NewGuid().ToString();
        }

        public PC(CPU cpu, VideoCard videoCard, PowerBlock powerBlock, RAM ram, MotherBoard motherBoard, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            this.cpu = cpu;
            this.videoCard = videoCard;
            this.powerBlock = powerBlock;
            this.ram = ram;
            this.motherBoard = motherBoard;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
