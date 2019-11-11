using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
  public  class Veiculo_Anexos
    {
        public int codigo { get; set; } = 0;
        public string descricao { get; set; } = "";
        public int veiculo { get; set; } = 0;
        public byte[] imagem { get; set; } = null;
    }
}
