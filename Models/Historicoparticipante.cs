using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Historicoparticipante
    {
        public long Idhistoricoparticipante { get; set; }
        public DateTime Fecharegistro { get; set; }
        public DateTime Fechaversion { get; set; }
        public string? Historico { get; set; }
        public long Idparticipante { get; set; }
    }
}
