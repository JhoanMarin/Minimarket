using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CapaEntidades
{
    public class Producto
    {

        public int idproducto { get; set; }
        public String nombre { get; set; }
        public String marca { get; set; }
        public int Stock { get; set; }
        public Decimal pvp  { get; set; }
        public String descripcion { get; set; }
        public String unidadMedida { get; set; }
        public int idcategoria { get; set; }
        

    }
}
