using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class CalificadorasCalificacione
    {
        public long IdCalificadoraCalificacion { get; set; }
        public long? IdCalificadora { get; set; }
        public int? IdCalificacionHomologada { get; set; }
        public long? IdHorizonte { get; set; }
        public int? IdCnbv { get; set; }
        public string? CalificacionEscalaNacional { get; set; }
        public string? CalificacionEscalaGlobal { get; set; }
        public int? EstatusRegistro { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public int? EstatusModificacion { get; set; }
        public long? Idoperadora { get; set; }

        public virtual Calificadorasalt2? IdCalificadoraNavigation { get; set; }
    }
}
