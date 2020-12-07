using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class Profesor
    {
        [Key]
        public int IDProfesor { get; set; }

        public int IDTipoProfesor { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string RFC { get; set; }

        public string CURP { get; set; }

        public int Nomina { get; set; }

        public string Contraseña { get; set; }
    }
}