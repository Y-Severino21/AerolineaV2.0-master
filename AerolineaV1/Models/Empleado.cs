using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AerolineaV1.Models
{
    public class Empleado
    {
        [Key]
        public int EmpID { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Ingrese una Cedula validad")]
        public string Cedula { get; set; }

        [Column(TypeName = "varchar(25)")]
        [DisplayName("Nombre Completo")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Puesto de Trabajo")]
        public string Puesto { get; set; }

        [Column(TypeName = "int")]
        public int Salario { get; set; }
    }
}
