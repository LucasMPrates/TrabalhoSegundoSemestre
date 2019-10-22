using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
  public class Pessoas
    {
        public int codigo { get; set; } = 0;
        public string nome { get; set; } = "";
        public string cpf { get; set; } = "";
        public DateTime nascimento { get; set; } = new DateTime(2000, 1, 1);
        public string endereco { get; set; } = "";
        public int numero { get; set; } = 0;
        public string vila { get; set; } = "";
        public string cidade { get; set; } = "";
        public string estado { get; set; } = "";
        public bool motorista { get; set; } = false;
        public string telefone { get; set; } = "";
        public string sexo { get; set; } = "";
        public int cargo { get; set; } = 0;
    }
}
