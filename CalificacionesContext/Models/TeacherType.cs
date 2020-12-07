using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class TipoProfesor
    {
        //Attibutes

        [Key]
        public int IDTipoProfesor { get; set; }

        public string Nombre { get; set; }

        public int HorasMinimasTrabajadas { get; set; }

        public int HorasMaximasTrabajadas { get; set; }
    }
}