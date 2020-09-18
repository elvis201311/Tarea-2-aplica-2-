using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "Introduzca Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Introduzca Telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Introduzca Cedula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Introduzca Direccion")]
        public string Direccion { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Introduzca una Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Fecha = DateTime.Now;

        }
    }

}
