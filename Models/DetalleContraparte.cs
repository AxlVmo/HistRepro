using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class DetalleContraparte
    {
        public string? Contrato { get; set; }
        public string? Foliofront { get; set; }
        public long Iddetallecontraparte { get; set; }
        public long Idprestador { get; set; }
        public long? Idsiefore { get; set; }
        public string? Nombrecorto { get; set; }
        public bool Estatus { get; set; }
    }
}
