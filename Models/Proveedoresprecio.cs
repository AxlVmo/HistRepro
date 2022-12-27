﻿using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Proveedoresprecio
    {
        public long Idproveedorprecios { get; set; }
        public string? Estatusparticipacion { get; set; }
        public DateTime? Fechaaltaparticipacion { get; set; }
        public DateTime? Fechacambioparticipacion { get; set; }
        public DateTime? Fechaestatusparticipacion { get; set; }
        public string? Nombrecorto { get; set; }
        public string? Responsableinformacion { get; set; }

        public virtual Participante IdproveedorpreciosNavigation { get; set; } = null!;
    }
}
