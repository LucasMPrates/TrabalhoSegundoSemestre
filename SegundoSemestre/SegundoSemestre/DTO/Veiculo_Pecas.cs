using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
   public class Veiculo_Pecas
    {
        public int codigo { get; set; } = 0;
        public int veiculo { get; set; } = 0;
        public int peca { get; set; } = 0;
        public DateTime data { get; set; }
        public int km_rodados { get; set; } = 0;
    }
}
