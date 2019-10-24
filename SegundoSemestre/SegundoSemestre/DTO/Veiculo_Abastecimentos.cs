using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
    public class Veiculo_Abastecimentos
    {
        public int codigo { get; set; } = 0;
        public int veiculo { get; set; } = 0;
        public double litros { get; set; } = 0;
        public double valor_litro { get; set; } = 0;
        public double total { get; set; } = 0;
        public DateTime datahora { get; set; }
        public byte[] anexo { get; set; } = null;
    }
}
