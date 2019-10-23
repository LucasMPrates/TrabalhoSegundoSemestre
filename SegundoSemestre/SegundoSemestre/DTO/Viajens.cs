using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
    public class Viajens
    {
        public int codigo { get; set; } = 0;
        public int motorista { get; set; } = 0;
        public string destino { get; set; } = "";
        public int km_rodados { get; set; } = 0;
        public string status { get; set; } = "A";
        public int veiculo { get; set; } = 0;
        public string obs1 { get; set; } = "";
        public string obs2 { get; set; } = "";
        public DateTime data_ida { get; set; }
        public DateTime data_retorno { get; set; }
    }
}
