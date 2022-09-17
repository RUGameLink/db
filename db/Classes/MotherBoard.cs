using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class MotherBoard
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Сокет")]
        public string socket { get; set; }

        [DisplayName("Поддерживаемые видеокарты")]
        public string GCPUtype { get; set; }

        [DisplayName("Тип поддерживаемой RAM")]
        public string RAMtype { get; set; }

        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public MotherBoard()
        {
            id = Guid.NewGuid().ToString();
        }

        public MotherBoard(string socket, string gCPUtype, string rAMtype, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            this.socket = socket;
            GCPUtype = gCPUtype;
            RAMtype = rAMtype;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
