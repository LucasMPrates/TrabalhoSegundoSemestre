using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
   public class Pessoa_Anexos
    {
        public int codigo { get; set; } = 0;
        public string descricao { get; set; } = "";
        public int pessoa { get; set; } = 0;
        public byte[] imagem { get; set; } = null;

    }
}
