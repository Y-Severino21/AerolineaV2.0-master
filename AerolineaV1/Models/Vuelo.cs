using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class Vuelo
    {
        [Key] 
        public int VueloID { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Ingrese un Destino valido")]
        public string Destino { get; set; }
        [Column(TypeName = "varchar(25)")]
        [Required(ErrorMessage = "Ingrese un Piloto valido")]
        public string Piloto { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Ingrese un Destino valido")]
        [DisplayName("Modelo del Avion")] 
        public string ModeloAvion { get; set; }
        [Column(TypeName = "int")]
        public int Pasajeros { get; set; }
        [Column(TypeName = "Date")]
        [DisplayName("Fecha de Abordaje")]
        public DateTime FechaAbordaje { get; set; }
    }
}
