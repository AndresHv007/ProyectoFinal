using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class ProfesorMateria
    {
        //Attibutes

        [Key]
        public int IDProfesorMateria { get; set; }

        public int IDProfesor { get; set; }

        public int IDMateria { get; set; }

    }
}