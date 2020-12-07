using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class Asignatura
    {
        //Attibutes

        [Key]
        public int IDAsignatura { get; set; }

        public int IDProfesor { get; set; }

        public int IDMateria { get; set; }

        public int IDGrupo { get; set; }


    }
}