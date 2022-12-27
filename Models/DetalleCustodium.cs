using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class DetalleCustodium
    {
        public long Iddetallecustodia { get; set; }
        public long? Idsiefore { get; set; }
        public long Idprestador { get; set; }
        public string? Serie { get; set; }
        public string? Cuentaindeval { get; set; }
        public string? Nombrecorto { get; set; }
        public bool Estatus { get; set; }
    }
}
