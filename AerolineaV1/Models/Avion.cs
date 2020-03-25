using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Models
{
    public class Avion
    {
        [Key] 
        public int AvionID { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Ingrese un Modelo de avion valido")]
        public string Modelo { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Capacidad de Pasajeros")]
        public int Capacidad { get; set; }
        [Column(TypeName = "varchar(25)")]
        [DisplayName("Categoria del Avion")]
        public string TipoAvion { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Numero de Turbinas")]
        public int CantMotor { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Vel. Maxima (km/h)")]
        public int Velocidad { get; set; }
    }
}
