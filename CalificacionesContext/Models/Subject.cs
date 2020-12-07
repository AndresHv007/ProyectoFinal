using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class Materia
    {
        //Attibutes

        [Key]
        public int IDMateria { get; set; }

        public string Nombre { get; set; }

        public int HorasTeoricas { get; set; }

        public int HorasPracticas { get; set; }


    }
}