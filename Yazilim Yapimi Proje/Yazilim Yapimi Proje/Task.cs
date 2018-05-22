using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yazilim_Yapimi_Proje
{

    public enum taskTuru
        {
        Not_Started = 0,
        In_Progress = 1,
        Done = 2,
        }

    public class Task
    {
        public string Baslik { get; set; }
        public string YapanKisi { get; set; }
        public DateTime YapilisTarihi { get; set; }
        public string Bilgi { get; set; }
        public taskTuru Durumu { get; set; }
        public Story aitOlduguStory { get; set; }

        public Task(Story s)
        {
            aitOlduguStory = s;
        }
    }
}
