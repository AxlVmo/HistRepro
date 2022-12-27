using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Autorizacionesestado
    {
        public long Idautorizacionestado { get; set; }
        public DateTime? Fechaalta { get; set; }
        public DateTime? Fechaejecución { get; set; }
        public long? Idtipoparticipacion { get; set; }
        public bool Isactivo { get; set; }
        public long? Supervisorid { get; set; }
        public string? Username { get; set; }
        public long? Usuarioid { get; set; }
    }
}
