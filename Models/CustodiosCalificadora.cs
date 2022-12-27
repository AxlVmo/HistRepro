using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class CustodiosCalificadora
    {
        public int IdCustodiosCalificadoras { get; set; }
        public int? IdCalificacionHomologada { get; set; }
        public int? IdCustodios { get; set; }
        public int? EstatusRegistro { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public DateOnly? FechaModificacion { get; set; }

        public virtual Custodio? IdCustodiosNavigation { get; set; }
    }
}
