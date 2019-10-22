using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DTO
{
    public class Login
    {
        public int codigo { get; set; } = 0;
        public string usuario { get; set; } = "";
        public string senha { get; set; } = "";
        public int pessoa { get; set; } = 0;
    }
}
