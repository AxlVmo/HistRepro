using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class BdBitacora
    {
        public long IdBdBitacoras { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public string? Usuario { get; set; }
        public string? Ambiente { get; set; }
        public string? BaseDatos { get; set; }
        public string? NombreTabla { get; set; }
        public int? Registros { get; set; }
    }
}
