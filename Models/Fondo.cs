using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Fondo
    {
        public Fondo()
        {
            Series = new HashSet<Series>();
        }

        public long Idfondo { get; set; }
        public bool? Activo { get; set; }
        public long? Calificadoraid { get; set; }
        public string? Clavecasfim { get; set; }
        public string? Clavecorta { get; set; }
        public string Clavepizarra { get; set; } = null!;
        public string? Comentarios { get; set; }
        public bool Comienzaoperarhoy { get; set; }
        public long? Custodiovaloresid { get; set; }
        public long? Emisorid { get; set; }
        public bool? Esemisor { get; set; }
        public string Estatusfondo { get; set; } = null!;
        public DateTime Fechaalta { get; set; }
        public DateTime? Fechaautorizacion { get; set; }
        public DateTime? Fechaautorizacionoficio { get; set; }
        public DateTime? Fechacambio { get; set; }
        public DateTime? Fechainioperacion { get; set; }
        public bool? Necesitacapitalbancos { get; set; }
        public string? Nooficioautorizacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Nombrecorto { get; set; } = null!;
        public string Nombredirector { get; set; } = null!;
        public string? Objetivodeinversion { get; set; }
        public long Operadoraid { get; set; }
        public string? Rfc { get; set; }
        public string? Tipodecambio { get; set; }
        public long? Valuadoraid { get; set; }
        public long? Idhorizonte { get; set; }
        public long? Idprospecto { get; set; }
        public long? Idtipofondo { get; set; }
        public int? Idtipomercado { get; set; }
        public long? Idtipooperacion { get; set; }

        public virtual Horizonte? IdhorizonteNavigation { get; set; }
        public virtual Prospecto? IdprospectoNavigation { get; set; }
        public virtual Tiposfondo? IdtipofondoNavigation { get; set; }
        public virtual Tiposmercado? IdtipomercadoNavigation { get; set; }
        public virtual ICollection<Series> Series { get; set; }
    }
}
