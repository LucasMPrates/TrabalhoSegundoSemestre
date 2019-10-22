using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
    public class Equipamentos
    {
        public int codigo { get; set; } = 0;
        public string descricao { get; set; } = "";
        public bool pneu { get; set; } = false;
        public bool peca { get; set; } = false;
    }
}
