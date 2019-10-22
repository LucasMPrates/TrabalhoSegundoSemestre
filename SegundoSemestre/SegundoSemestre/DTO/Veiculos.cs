using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
    public class Veiculos
    {
        public int codigo { get; set; } = 0;
        public string placa { get; set; } = "";
        public string marca { get; set; } = "";
        public string modelo { get; set; } = "";
        public string tpcomb { get; set; } = "1";
        public string status { get; set; } = "1";
        public int ano_fabricacao { get; set; } = DateTime.Today.Year;
        public int ano_modelo { get; set; } = DateTime.Today.Year;
        public double media_consumo { get; set; } = 0.00;
        public int km { get; set; } = 0;
        
    }
}
