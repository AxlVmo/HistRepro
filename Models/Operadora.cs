using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Operadora
    {
        public long Idoperadora { get; set; }
        public string? Clavecasfim { get; set; }
        public string? Clavecnbv { get; set; }
        public string? Clavecorta { get; set; }
        public string? Estatusparticipacion { get; set; }
        public DateTime? Fechaaltaparticipacion { get; set; }
        public DateTime? Fechaautorizacionoficio { get; set; }
        public DateTime? Fechacambioparticipacion { get; set; }
        public DateTime? Fechaestatusparticipacion { get; set; }
        public string? Nombrecorto { get; set; }
        public string? Numerooficioautorizacion { get; set; }
        public string? Responsableinformacion { get; set; }

        public virtual Participante IdoperadoraNavigation { get; set; } = null!;
    }
}
