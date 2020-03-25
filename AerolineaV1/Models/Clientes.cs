using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class Clientes
    {
        [Key]
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Destino { get; set; }
        public string EMail { get; set; }
        public string DIreccion { get; set; }
        public DateTime FechaDeVuelo { get; set; }
    }
}
