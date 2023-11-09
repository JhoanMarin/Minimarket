using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaEntidades
{
    public class Proveedor
    {
        public int idproveedor { get; set; }
        public String nit { get; set; }
        public String razonSocial{ get; set; }
        public String telefono{ get; set; }
        public String correo{ get; set; }
        public String nomenclatura{ get; set; }
        public String ciudad{ get; set; }
        public String departamento{ get; set; }
    }
}
