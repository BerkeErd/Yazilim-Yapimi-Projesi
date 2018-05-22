using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yazilim_Yapimi_Proje
{
    public class Story
    {
        public string Baslik { get; set; }
        public string Bilgi { get; set; }
        public List<Task> Tasklar = new List<Task>();
        public Story()
        {
           
            
        }
    }
    
}
