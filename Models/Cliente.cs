using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCRUD_SolisAndrade.Models
{
    public class Cliente
    {
        public int clienteID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string fechaNacimiento { get; set; }
        public bool estado { get; set; }
    }
}
