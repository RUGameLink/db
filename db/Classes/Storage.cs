using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class Storage
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Объем")]
        public int volune { get; set; }

        [DisplayName("Тип памяти")]
        public string type { get; set; }

        [DisplayName("Скорость записи")]
        public int speedOfWrite { get; set; }

        [DisplayName("Скорость чтения")]
        public int speedOfRead { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public Storage()
        {
            id = Guid.NewGuid().ToString();
        }

        public Storage(int volune, string type, int speedOfWrite, int speedOfRead, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            this.volune = volune;
            this.type = type;
            this.speedOfWrite = speedOfWrite;
            this.speedOfRead = speedOfRead;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
