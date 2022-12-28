using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class BitacoraPrestadore
    {
        public int IdBitacoraPrestadores { get; set; }
        public int? IdControl { get; set; }
        public int? IdTipoAccion { get; set; }
        public string? NombreTabla { get; set; }
        public string? Contenido { get; set; }
        public string? Usuario { get; set; }
        public int? EstatusRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }

    }
}
