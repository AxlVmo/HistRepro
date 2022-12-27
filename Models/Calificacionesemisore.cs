using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Calificacionesemisore
    {
        public int Idcalificacionemisor { get; set; }
        public string? Nombrecalificadora { get; set; }
        public string? Calificacion { get; set; }
        public DateOnly? Fecha { get; set; }
        public int? Idemisor { get; set; }

        public virtual Emisore? IdemisorNavigation { get; set; }
    }
}
