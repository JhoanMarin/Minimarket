using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaEntidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public String tipodocumento { get; set; }
        public String identificacion { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String correo { get; set; }
        public String celular { get; set; }
    }
}
