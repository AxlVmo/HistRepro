using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Emisore
    {
        public Emisore()
        {
            Calificacionesemisores = new HashSet<Calificacionesemisore>();
        }

        public int Idemisor { get; set; }
        public string? Estatusparticipacion { get; set; }
        public DateTime? Fechaaltaparticipacion { get; set; }
        public DateTime? Fechacambioparticipacion { get; set; }
        public DateTime? Fechaestatusparticipacion { get; set; }
        public string? Nombrecorto { get; set; }
        public string? Responsableinformacion { get; set; }
        public int? Idtipomercado { get; set; }
        public int? Idclasificacionsectorial { get; set; }
        public string? NombreLargo { get; set; }

        public virtual Catclasificacionessectoriale? IdclasificacionsectorialNavigation { get; set; }
        public virtual Tiposmercado? IdtipomercadoNavigation { get; set; }
        public virtual ICollection<Calificacionesemisore> Calificacionesemisores { get; set; }
    }
}
