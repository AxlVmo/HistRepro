using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Siefore
    {
        public Siefore()
        {
            Comisionessobresaldoafores = new HashSet<Comisionessobresaldoafore>();
            Seriesiefores = new HashSet<Seriesiefore>();
        }

        public long Idsiefore { get; set; }
        public decimal? Accionesemitidas { get; set; }
        public bool Activacion { get; set; }
        public long Idafore { get; set; }
        public long? Calificadoraid { get; set; }
        public decimal? Capitalsocialautorizado { get; set; }
        public string? Clavecorta { get; set; }
        public string Clavepizarra { get; set; } = null!;
        public string? Comentarios { get; set; }
        public long? Custodiovaloresid { get; set; }
        public string? Descripcionsociedadinversion { get; set; }
        public string Estatus { get; set; } = null!;
        public DateTime Fechaalta { get; set; }
        public DateTime? Fechaautorizacion { get; set; }
        public DateTime? Fechaautorizacionoficio { get; set; }
        public DateTime? Fechainiciooperaciones { get; set; }
        public DateTime? Fechamodificacion { get; set; }
        public int? Iddivisaoperaciones { get; set; }
        public int? Idtiposociedadinversion { get; set; }
        public string? Nooficioautorizacion { get; set; }
        public string Nombre { get; set; } = null!;
        public long? Padreid { get; set; }
        public long? Proveedorpreciosid { get; set; }
        public string? Rfc { get; set; }
        public string? Tipodecambio { get; set; }
        public decimal? Valornominalaccion { get; set; }
        public long? Valuadoraid { get; set; }
        public int? Idtipomercado { get; set; }
        public long? Idtipooperacion { get; set; }
        public byte[]? Archivodoc { get; set; }
        public string? Archivonombre { get; set; }
        public string? Idsubtipoentidad { get; set; }
        public string? Descripciontipoentidad { get; set; }
        public int? Idtipoentidad { get; set; }
        public string? Descripcionsubtipoentidad { get; set; }

        public virtual Afore IdaforeNavigation { get; set; } = null!;
        public virtual Tiposmercado? IdtipomercadoNavigation { get; set; }
        public virtual Tiposoperacion? IdtipooperacionNavigation { get; set; }
        public virtual ICollection<Comisionessobresaldoafore> Comisionessobresaldoafores { get; set; }
        public virtual ICollection<Seriesiefore> Seriesiefores { get; set; }
    }
}
