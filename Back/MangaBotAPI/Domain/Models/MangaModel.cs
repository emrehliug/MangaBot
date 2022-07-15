using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class MangaModel
    {
        private int mangaID;
        public int MangaID
        {
            get
            {
                return mangaID;
            }
            set
            {
                mangaID = value;
            }
        }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int NumCapitulos { get; set; }
    }
}
