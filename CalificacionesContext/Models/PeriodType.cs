using System;
using System.ComponentModel.DataAnnotations;

namespace CalificacionesContext.Models
{
    public class TipoPeriodo
    {
        //Attibutes

        [Key]
        public int IDTipoPeriodo { get; set; }

        public string Nombre { get; set; }

        public int Meses { get; set; }
    }
}