using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Usuario_MangaModel
    {
        public int UsuarioID { get; set; }
        public UsuarioModel UsuarioModel { get; set; }
        public int MangaID { get; set; }
        public MangaModel MangaModel { get; set; }
    }
}
