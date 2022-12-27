using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Custodio
    {
        public Custodio()
        {
            CustodiosCalificadoras = new HashSet<CustodiosCalificadora>();
            CustodiosSeries = new HashSet<CustodiosSeries>();
        }

        public int IdCustodios { get; set; }
        public string? NombreCorto { get; set; }
        public string? NombreLargo { get; set; }
        public int? IdConsar { get; set; }
        public string? IdCasfim { get; set; }
        public string? Domicilio { get; set; }
        public int? EstatusRegistro { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public DateOnly? FechaModificacion { get; set; }

        public virtual ICollection<CustodiosCalificadora> CustodiosCalificadoras { get; set; }
        public virtual ICollection<CustodiosSeries> CustodiosSeries { get; set; }
    }
}
