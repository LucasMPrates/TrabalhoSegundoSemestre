using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
    public class Veiculo_Manutencoes
    {
        public int codigo { get; set; } = 0;
        public int veiculo { get; set; } = 0;
        public string descricao { get; set; } = "";
        public DateTime data { get; set; }
        public int km_rodados { get; set; } = 0;
        public int proxima_manutencao { get; set; } = 0;
    }
}
