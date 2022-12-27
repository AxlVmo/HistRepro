using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class CustodiosSeries
    {
        public int IdCustodiosSeries { get; set; }
        public string? CuentaCustodio { get; set; }
        public string? NombreCorto { get; set; }
        public int? IdControl { get; set; }
        public int? IdArea { get; set; }
        public int? IdSerie { get; set; }
        public int? IdCustodios { get; set; }
        public int? EstatusRegistro { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public DateOnly? FechaModificacion { get; set; }

        public virtual Custodio? IdCustodiosNavigation { get; set; }
    }
}
