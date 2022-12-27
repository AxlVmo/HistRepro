using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Domicilio
    {
        public long Iddomicilio { get; set; }
        public string Calle { get; set; } = null!;
        public string Codigopostal { get; set; } = null!;
        public string Colonia { get; set; } = null!;
        public string? Estado { get; set; }
        public string Municipio { get; set; } = null!;
        public string Numeroexterior { get; set; } = null!;
        public string? Numerointerior { get; set; }
        public string Pais { get; set; } = null!;

        public virtual Participante IddomicilioNavigation { get; set; } = null!;
    }
}
