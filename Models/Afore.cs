using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Afore
    {
        public Afore()
        {
            Siefores = new HashSet<Siefore>();
        }

        public long Idafore { get; set; }
        public string? Claveconsar { get; set; }
        public string? Clavecorta { get; set; }
        public string? Estatusparticipacion { get; set; }
        public DateTime? Fechaaltaparticipacion { get; set; }
        public DateTime? Fechaautorizacionoficio { get; set; }
        public DateTime? Fechacambioparticipacion { get; set; }
        public DateTime? Fechaestatusparticipacion { get; set; }
        public string? Nombrecorto { get; set; }
        public string? Numerooficioautorizacion { get; set; }
        public string? Responsableinformacion { get; set; }
        public long? Claveentidad { get; set; }
        public string? Descripcionentidad { get; set; }

        public virtual Participante IdaforeNavigation { get; set; } = null!;
        public virtual ICollection<Siefore> Siefores { get; set; }
    }
}
