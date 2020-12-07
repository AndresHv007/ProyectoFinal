using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class GrupoEnEscuela
    {
        //Attibutes

        [Key]
        public int IDGrupo { get; set; }

        public int IDTipoPeriodo { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }


    }
}