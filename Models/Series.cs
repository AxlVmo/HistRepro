using System;
using System.Collections.Generic;

namespace HistRepro.Models
{
    public partial class Series
    {
        public long Idserie { get; set; }
        public decimal Accionesemitidasnuevo { get; set; }
        public decimal Capitalautorizadonuevo { get; set; }
        public string? Clave { get; set; }
        public string Liquidacioncompra { get; set; } = null!;
        public string? Liquidacionentradas { get; set; }
        public string? Liquidacionsalidas { get; set; }
        public string Liquidacionventa { get; set; } = null!;
        public string Descripciontipoinversionista { get; set; } = null!;
        public decimal? Diarecepcion { get; set; }
        public long? Idfondo { get; set; }
        public string? Fecharecepcion { get; set; }
        public long Idliquidacioncompra { get; set; }
        public long? Idliquidacionentradas { get; set; }
        public long? Idliquidacionsalidas { get; set; }
        public long Idliquidacionventa { get; set; }
        public long? Idtipoinversionista { get; set; }
        public decimal? Montomaximodepositochequera { get; set; }
        public decimal? Montomaximoprestamovalores { get; set; }
        public decimal? Montomaximoreportos { get; set; }
        public decimal? Montomaximovaloresgub { get; set; }
        public decimal? Montomaximovaloresdeuda { get; set; }
        public decimal? Montomaximovaloresrenta { get; set; }
        public decimal? Montomaximovaloresvencimiento { get; set; }
        public decimal? Montominimodepositochequera { get; set; }
        public decimal? Montominimoprestamovalores { get; set; }
        public decimal? Montominimoreportos { get; set; }
        public decimal? Montominimovaloresgub { get; set; }
        public decimal? Montominimovaloresdeuda { get; set; }
        public decimal? Montominimovaloresrenta { get; set; }
        public decimal? Montominimovaloresvencimiento { get; set; }
        public decimal? Montominimoinversion { get; set; }
        public bool Ispensionados { get; set; }
        public long? Plazominimo { get; set; }
        public decimal Porcadministracion { get; set; }
        public decimal Precioinicio { get; set; }
        public bool Isretenerderivados { get; set; }
        public bool Isretenerdividendos { get; set; }
        public string Serie { get; set; } = null!;
        public string Tipoisr { get; set; } = null!;
        public string Valornominal { get; set; } = null!;
        public decimal? Comisiondistribucion { get; set; }
        public bool? Borradologico { get; set; }
        public string? Idtipovalor { get; set; }

        public virtual Fondo? IdfondoNavigation { get; set; }
    }
}
