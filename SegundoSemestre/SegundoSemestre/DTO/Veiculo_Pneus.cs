using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
   public class Veiculo_Pneus
    {
        public int codigo { get; set; } = 0;
        public int pneu { get; set; } = 0;
        public int km_rodados { get; set; } = 0;
        public int veiculo { get; set; } = 0;
        public bool estepe { get; set; } = false;
        public double sulco { get; set; } = 0;
    }
}
