using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIPA.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
