using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HistRepro.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Afore> Afores { get; set; } = null!;
        public virtual DbSet<Aseguradora> Aseguradoras { get; set; } = null!;
        public virtual DbSet<Autorizacionesestado> Autorizacionesestados { get; set; } = null!;
        public virtual DbSet<BdBitacora> BdBitacoras { get; set; } = null!;
        public virtual DbSet<BitacoraPrestadore> BitacoraPrestadores { get; set; } = null!;
        public virtual DbSet<Calificacionesemisore> Calificacionesemisores { get; set; } = null!;
        public virtual DbSet<Calificadora> Calificadoras { get; set; } = null!;
        public virtual DbSet<CalificadorasCalificacione> CalificadorasCalificaciones { get; set; } = null!;
        public virtual DbSet<Calificadorasalt2> Calificadorasalt2s { get; set; } = null!;
        public virtual DbSet<Cataforesentidade> Cataforesentidades { get; set; } = null!;
        public virtual DbSet<Catclasificacionessectoriale> Catclasificacionessectoriales { get; set; } = null!;
        public virtual DbSet<Cattipoparticipante> Cattipoparticipantes { get; set; } = null!;
        public virtual DbSet<Cattipoprestadorservicio> Cattipoprestadorservicios { get; set; } = null!;
        public virtual DbSet<Comisionessobresaldoafore> Comisionessobresaldoafores { get; set; } = null!;
        public virtual DbSet<Comitevaluacion> Comitevaluacions { get; set; } = null!;
        public virtual DbSet<Contacto> Contactos { get; set; } = null!;
        public virtual DbSet<Custodio> Custodios { get; set; } = null!;
        public virtual DbSet<CustodiosCalificadora> CustodiosCalificadoras { get; set; } = null!;
        public virtual DbSet<CustodiosSeries> CustodiosSeries { get; set; } = null!;
        public virtual DbSet<Depositario> Depositarios { get; set; } = null!;
        public virtual DbSet<DetalleContraparte> DetalleContrapartes { get; set; } = null!;
        public virtual DbSet<DetalleCustodium> DetalleCustodia { get; set; } = null!;
        public virtual DbSet<Distribuidore> Distribuidores { get; set; } = null!;
        public virtual DbSet<Domicilio> Domicilios { get; set; } = null!;
        public virtual DbSet<Emisore> Emisores { get; set; } = null!;
        public virtual DbSet<Entidade> Entidades { get; set; } = null!;
        public virtual DbSet<Entidadesregulatoria> Entidadesregulatorias { get; set; } = null!;
        public virtual DbSet<Fondo> Fondos { get; set; } = null!;
        public virtual DbSet<Historicoparticipante> Historicoparticipantes { get; set; } = null!;
        public virtual DbSet<Horizonte> Horizontes { get; set; } = null!;
        public virtual DbSet<Operadora> Operadoras { get; set; } = null!;
        public virtual DbSet<Participante> Participantes { get; set; } = null!;
        public virtual DbSet<Pasot> Pasots { get; set; } = null!;
        public virtual DbSet<Prestadore> Prestadores { get; set; } = null!;
        public virtual DbSet<Promotoresindependiente> Promotoresindependientes { get; set; } = null!;
        public virtual DbSet<Prospecto> Prospectos { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Proveedoresprecio> Proveedoresprecios { get; set; } = null!;
        public virtual DbSet<Series> Series { get; set; } = null!;
        public virtual DbSet<Seriesiefore> Seriesiefores { get; set; } = null!;
        public virtual DbSet<Siefore> Siefores { get; set; } = null!;
        public virtual DbSet<Sociosliquidadore> Sociosliquidadores { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Tiposcalificacion> Tiposcalificacions { get; set; } = null!;
        public virtual DbSet<Tiposemisor> Tiposemisors { get; set; } = null!;
        public virtual DbSet<Tiposentidad> Tiposentidads { get; set; } = null!;
        public virtual DbSet<Tiposfondo> Tiposfondos { get; set; } = null!;
        public virtual DbSet<Tiposmercado> Tiposmercados { get; set; } = null!;
        public virtual DbSet<Tiposociedadesinversion> Tiposociedadesinversions { get; set; } = null!;
        public virtual DbSet<Tiposoperacion> Tiposoperacions { get; set; } = null!;
        public virtual DbSet<Valuadora> Valuadoras { get; set; } = null!;
        public virtual DbSet<Valuadorasempleado> Valuadorasempleados { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm");

            modelBuilder.Entity<Afore>(entity =>
            {
                entity.HasKey(e => e.Idafore)
                    .HasName("afores_pk");

                entity.ToTable("afores");

                entity.Property(e => e.Idafore)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idafore");

                entity.Property(e => e.Claveconsar)
                    .HasMaxLength(255)
                    .HasColumnName("claveconsar");

                entity.Property(e => e.Clavecorta)
                    .HasMaxLength(255)
                    .HasColumnName("clavecorta");

                entity.Property(e => e.Claveentidad).HasColumnName("claveentidad");

                entity.Property(e => e.Descripcionentidad)
                    .HasMaxLength(100)
                    .HasColumnName("descripcionentidad");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechaautorizacionoficio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacionoficio");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Numerooficioautorizacion)
                    .HasMaxLength(255)
                    .HasColumnName("numerooficioautorizacion");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdaforeNavigation)
                    .WithOne(p => p.Afore)
                    .HasForeignKey<Afore>(d => d.Idafore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("participantes_fk");
            });

            modelBuilder.Entity<Aseguradora>(entity =>
            {
                entity.HasKey(e => e.Idaseguradora)
                    .HasName("aseguradoras_pk");

                entity.ToTable("aseguradoras");

                entity.Property(e => e.Idaseguradora)
                    .ValueGeneratedNever()
                    .HasColumnName("idaseguradora");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdaseguradoraNavigation)
                    .WithOne(p => p.Aseguradora)
                    .HasForeignKey<Aseguradora>(d => d.Idaseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("participantes_fk");
            });

            modelBuilder.Entity<Autorizacionesestado>(entity =>
            {
                entity.HasKey(e => e.Idautorizacionestado)
                    .HasName("autorizacionesestado_pk");

                entity.ToTable("autorizacionesestado");

                entity.Property(e => e.Idautorizacionestado).HasColumnName("idautorizacionestado");

                entity.Property(e => e.Fechaalta)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaalta");

                entity.Property(e => e.Fechaejecución)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaejecución");

                entity.Property(e => e.Idtipoparticipacion).HasColumnName("idtipoparticipacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.Supervisorid).HasColumnName("supervisorid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");

                entity.Property(e => e.Usuarioid).HasColumnName("usuarioid");
            });

            modelBuilder.Entity<BdBitacora>(entity =>
            {
                entity.HasKey(e => e.IdBdBitacoras)
                    .HasName("bd_bitacoras_pk");

                entity.ToTable("bd_bitacoras");

                entity.Property(e => e.IdBdBitacoras).HasColumnName("id_bd_bitacoras");

                entity.Property(e => e.Ambiente)
                    .HasMaxLength(100)
                    .HasColumnName("ambiente");

                entity.Property(e => e.BaseDatos)
                    .HasMaxLength(100)
                    .HasColumnName("base_datos");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.NombreTabla)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_tabla");

                entity.Property(e => e.Registros).HasColumnName("registros");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<BitacoraPrestadore>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraPrestadores)
                    .HasName("bitacora_prestadores_pky");

                entity.ToTable("bitacora_prestadores");

                entity.Property(e => e.IdBitacoraPrestadores).HasColumnName("id_bitacora_prestadores");

                entity.Property(e => e.Contenido)
                    .HasMaxLength(255)
                    .HasColumnName("contenido");

                entity.Property(e => e.EstatusRegistro).HasColumnName("estatus_registro");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdControl).HasColumnName("id_control");

                entity.Property(e => e.IdTipoAccion).HasColumnName("id_tipo_accion");

                entity.Property(e => e.NombreTabla)
                    .HasMaxLength(255)
                    .HasColumnName("nombre_tabla");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(255)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Calificacionesemisore>(entity =>
            {
                entity.HasKey(e => e.Idcalificacionemisor)
                    .HasName("calificacionesemisor_pk");

                entity.ToTable("calificacionesemisores");

                entity.Property(e => e.Idcalificacionemisor).HasColumnName("idcalificacionemisor");

                entity.Property(e => e.Calificacion)
                    .HasColumnType("character varying")
                    .HasColumnName("calificacion");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Idemisor).HasColumnName("idemisor");

                entity.Property(e => e.Nombrecalificadora)
                    .HasColumnType("character varying")
                    .HasColumnName("nombrecalificadora");

                entity.HasOne(d => d.IdemisorNavigation)
                    .WithMany(p => p.Calificacionesemisores)
                    .HasForeignKey(d => d.Idemisor)
                    .HasConstraintName("calificacionesemisor_fk");
            });

            modelBuilder.Entity<Calificadora>(entity =>
            {
                entity.HasKey(e => e.Idcalificadora)
                    .HasName("idx_eec2478f5069877c");

                entity.ToTable("calificadoras");

                entity.Property(e => e.Idcalificadora)
                    .ValueGeneratedNever()
                    .HasColumnName("idcalificadora");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");
            });

            modelBuilder.Entity<CalificadorasCalificacione>(entity =>
            {
                entity.HasKey(e => e.IdCalificadoraCalificacion)
                    .HasName("calificaciones_pk");

                entity.ToTable("calificadoras_calificaciones");

                entity.Property(e => e.IdCalificadoraCalificacion)
                    .HasColumnName("id_calificadora_calificacion")
                    .HasDefaultValueSql("nextval('calificaciones_idcalificacion_seq'::regclass)");

                entity.Property(e => e.CalificacionEscalaGlobal)
                    .HasColumnType("character varying")
                    .HasColumnName("calificacion_escala_global");

                entity.Property(e => e.CalificacionEscalaNacional)
                    .HasColumnType("character varying")
                    .HasColumnName("calificacion_escala_nacional");

                entity.Property(e => e.EstatusModificacion).HasColumnName("estatus_modificacion");

                entity.Property(e => e.EstatusRegistro).HasColumnName("estatus_registro");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdCalificacionHomologada).HasColumnName("id_calificacion_homologada");

                entity.Property(e => e.IdCalificadora).HasColumnName("id_calificadora");

                entity.Property(e => e.IdCnbv).HasColumnName("id_cnbv");

                entity.Property(e => e.IdHorizonte).HasColumnName("id_horizonte");

                entity.Property(e => e.Idoperadora).HasColumnName("idoperadora");

                entity.HasOne(d => d.IdCalificadoraNavigation)
                    .WithMany(p => p.CalificadorasCalificaciones)
                    .HasForeignKey(d => d.IdCalificadora)
                    .HasConstraintName("calificadoras_fk");
            });

            modelBuilder.Entity<Calificadorasalt2>(entity =>
            {
                entity.HasKey(e => e.IdCalificadora)
                    .HasName("calificadoras_pk");

                entity.ToTable("calificadorasalt2");

                entity.Property(e => e.IdCalificadora)
                    .ValueGeneratedNever()
                    .HasColumnName("id_calificadora");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(255)
                    .HasColumnName("domicilio");

                entity.Property(e => e.EstatusRegistro).HasColumnName("estatus_registro");

                entity.Property(e => e.FechaMidificacion).HasColumnName("fecha_midificacion");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdCasfim)
                    .HasMaxLength(10)
                    .HasColumnName("id_casfim");

                entity.Property(e => e.IdCnbv).HasColumnName("id_cnbv");

                entity.Property(e => e.IdConsar).HasColumnName("id_consar");

                entity.Property(e => e.NombreLargo)
                    .HasMaxLength(255)
                    .HasColumnName("nombre_largo");

                entity.Property(e => e.NombrecCorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrec_corto");

                entity.HasOne(d => d.IdCalificadoraNavigation)
                    .WithOne(p => p.Calificadorasalt2)
                    .HasForeignKey<Calificadorasalt2>(d => d.IdCalificadora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("participantes_fk");
            });

            modelBuilder.Entity<Cataforesentidade>(entity =>
            {
                entity.HasKey(e => e.Idaforesentidad)
                    .HasName("cataforesentidades_pk");

                entity.ToTable("cataforesentidades");

                entity.Property(e => e.Idaforesentidad).HasColumnName("idaforesentidad");

                entity.Property(e => e.Idafore).HasColumnName("idafore");

                entity.Property(e => e.Identidad).HasColumnName("identidad");
            });

            modelBuilder.Entity<Catclasificacionessectoriale>(entity =>
            {
                entity.HasKey(e => e.Idclasificacionsectorial)
                    .HasName("catclasificacionessectoriales_pk");

                entity.ToTable("catclasificacionessectoriales");

                entity.Property(e => e.Idclasificacionsectorial).HasColumnName("idclasificacionsectorial");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("character varying")
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Cattipoparticipante>(entity =>
            {
                entity.HasKey(e => e.Idcattipoparticipante)
                    .HasName("cattipoparticipantes_pk");

                entity.ToTable("cattipoparticipantes");

                entity.Property(e => e.Idcattipoparticipante)
                    .ValueGeneratedNever()
                    .HasColumnName("idcattipoparticipante");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Facultad)
                    .HasMaxLength(255)
                    .HasColumnName("facultad");
            });

            modelBuilder.Entity<Cattipoprestadorservicio>(entity =>
            {
                entity.HasKey(e => e.Idcatprestadorservicio)
                    .HasName("cattipoprestadorservicios_pk");

                entity.ToTable("cattipoprestadorservicios");

                entity.Property(e => e.Idcatprestadorservicio)
                    .ValueGeneratedNever()
                    .HasColumnName("idcatprestadorservicio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Comisionessobresaldoafore>(entity =>
            {
                entity.HasKey(e => e.Idcomisionsaldoafore)
                    .HasName("comisionessobresaldoafore_pk");

                entity.ToTable("comisionessobresaldoafore");

                entity.Property(e => e.Idcomisionsaldoafore).HasColumnName("idcomisionsaldoafore");

                entity.Property(e => e.Anio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("anio");

                entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");

                entity.Property(e => e.Porcentajecomision)
                    .HasPrecision(19, 2)
                    .HasColumnName("porcentajecomision");

                entity.Property(e => e.Sieforeid).HasColumnName("sieforeid");

                entity.HasOne(d => d.Siefore)
                    .WithMany(p => p.Comisionessobresaldoafores)
                    .HasForeignKey(d => d.Sieforeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_5430230a4dd318ec");
            });

            modelBuilder.Entity<Comitevaluacion>(entity =>
            {
                entity.ToTable("comitevaluacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Firmante1)
                    .HasMaxLength(255)
                    .HasColumnName("firmante1");

                entity.Property(e => e.Firmante2)
                    .HasMaxLength(255)
                    .HasColumnName("firmante2");

                entity.Property(e => e.Firmante3)
                    .HasMaxLength(255)
                    .HasColumnName("firmante3");
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.Idcontacto)
                    .HasName("contactos_pk");

                entity.ToTable("contactos");

                entity.Property(e => e.Idcontacto).HasColumnName("idcontacto");

                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .HasColumnName("correo");

                entity.Property(e => e.Idparticipante).HasColumnName("idparticipante");

                entity.Property(e => e.Idtipoparticipacion).HasColumnName("idtipoparticipacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(255)
                    .HasColumnName("puesto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdparticipanteNavigation)
                    .WithMany(p => p.Contactos)
                    .HasForeignKey(d => d.Idparticipante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_d63fd360edf56bf7");
            });

            modelBuilder.Entity<Custodio>(entity =>
            {
                entity.HasKey(e => e.IdCustodios)
                    .HasName("custodios_pky");

                entity.ToTable("custodios");

                entity.Property(e => e.IdCustodios).HasColumnName("id_custodios");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(255)
                    .HasColumnName("domicilio");

                entity.Property(e => e.EstatusRegistro).HasColumnName("estatus_registro");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdCasfim)
                    .HasMaxLength(10)
                    .HasColumnName("id_casfim");

                entity.Property(e => e.IdConsar).HasColumnName("id_consar");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombre_corto");

                entity.Property(e => e.NombreLargo)
                    .HasMaxLength(255)
                    .HasColumnName("nombre_largo");
            });

            modelBuilder.Entity<CustodiosCalificadora>(entity =>
            {
                entity.HasKey(e => e.IdCustodiosCalificadoras)
                    .HasName("custodios_calificadoras_pky");

                entity.ToTable("custodios_calificadoras");

                entity.Property(e => e.IdCustodiosCalificadoras).HasColumnName("id_custodios_calificadoras");

                entity.Property(e => e.EstatusRegistro).HasColumnName("estatus_registro");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdCalificacionHomologada).HasColumnName("id_calificacion_homologada");

                entity.Property(e => e.IdCustodios).HasColumnName("id_custodios");

                entity.HasOne(d => d.IdCustodiosNavigation)
                    .WithMany(p => p.CustodiosCalificadoras)
                    .HasForeignKey(d => d.IdCustodios)
                    .HasConstraintName("custodios_calificadoras_fk");
            });

            modelBuilder.Entity<CustodiosSeries>(entity =>
            {
                entity.HasKey(e => e.IdCustodiosSeries)
                    .HasName("custodios_series_pky");

                entity.ToTable("custodios_series");

                entity.Property(e => e.IdCustodiosSeries).HasColumnName("id_custodios_series");

                entity.Property(e => e.CuentaCustodio)
                    .HasMaxLength(255)
                    .HasColumnName("cuenta_custodio");

                entity.Property(e => e.EstatusRegistro).HasColumnName("estatus_registro");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdControl).HasColumnName("id_control");

                entity.Property(e => e.IdCustodios).HasColumnName("id_custodios");

                entity.Property(e => e.IdSerie).HasColumnName("id_serie");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombre_corto");

                entity.HasOne(d => d.IdCustodiosNavigation)
                    .WithMany(p => p.CustodiosSeries)
                    .HasForeignKey(d => d.IdCustodios)
                    .HasConstraintName("custodios_series_fk");
            });

            modelBuilder.Entity<Depositario>(entity =>
            {
                entity.HasKey(e => e.Iddepositario)
                    .HasName("depositarios_pk");

                entity.ToTable("depositarios");

                entity.Property(e => e.Iddepositario)
                    .ValueGeneratedNever()
                    .HasColumnName("iddepositario");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IddepositarioNavigation)
                    .WithOne(p => p.Depositario)
                    .HasForeignKey<Depositario>(d => d.Iddepositario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_7ec58acf0dd7d92e");
            });

            modelBuilder.Entity<DetalleContraparte>(entity =>
            {
                entity.HasKey(e => e.Iddetallecontraparte)
                    .HasName("detalle_contrapartes_pkey");

                entity.ToTable("detalle_contrapartes");

                entity.Property(e => e.Iddetallecontraparte).HasColumnName("iddetallecontraparte");

                entity.Property(e => e.Contrato).HasColumnName("contrato");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Foliofront).HasColumnName("foliofront");

                entity.Property(e => e.Idprestador).HasColumnName("idprestador");

                entity.Property(e => e.Idsiefore).HasColumnName("idsiefore");

                entity.Property(e => e.Nombrecorto).HasColumnName("nombrecorto");
            });

            modelBuilder.Entity<DetalleCustodium>(entity =>
            {
                entity.HasKey(e => e.Iddetallecustodia)
                    .HasName("detalle_custodia_pkey");

                entity.ToTable("detalle_custodia");

                entity.Property(e => e.Iddetallecustodia).HasColumnName("iddetallecustodia");

                entity.Property(e => e.Cuentaindeval).HasColumnName("cuentaindeval");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Idprestador).HasColumnName("idprestador");

                entity.Property(e => e.Idsiefore).HasColumnName("idsiefore");

                entity.Property(e => e.Nombrecorto).HasColumnName("nombrecorto");

                entity.Property(e => e.Serie).HasColumnName("serie");
            });

            modelBuilder.Entity<Distribuidore>(entity =>
            {
                entity.HasKey(e => e.Iddistribuidor)
                    .HasName("distribuidores_pk");

                entity.ToTable("distribuidores");

                entity.Property(e => e.Iddistribuidor)
                    .ValueGeneratedNever()
                    .HasColumnName("iddistribuidor");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IddistribuidorNavigation)
                    .WithOne(p => p.Distribuidore)
                    .HasForeignKey<Distribuidore>(d => d.Iddistribuidor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_53a79942e44aa683");
            });

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.HasKey(e => e.Iddomicilio)
                    .HasName("domicilios_pk");

                entity.ToTable("domicilios");

                entity.Property(e => e.Iddomicilio)
                    .ValueGeneratedNever()
                    .HasColumnName("iddomicilio");

                entity.Property(e => e.Calle)
                    .HasMaxLength(255)
                    .HasColumnName("calle");

                entity.Property(e => e.Codigopostal)
                    .HasMaxLength(255)
                    .HasColumnName("codigopostal");

                entity.Property(e => e.Colonia)
                    .HasMaxLength(255)
                    .HasColumnName("colonia");

                entity.Property(e => e.Estado)
                    .HasMaxLength(255)
                    .HasColumnName("estado");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(255)
                    .HasColumnName("municipio");

                entity.Property(e => e.Numeroexterior)
                    .HasMaxLength(255)
                    .HasColumnName("numeroexterior");

                entity.Property(e => e.Numerointerior)
                    .HasMaxLength(255)
                    .HasColumnName("numerointerior");

                entity.Property(e => e.Pais)
                    .HasMaxLength(255)
                    .HasColumnName("pais");

                entity.HasOne(d => d.IddomicilioNavigation)
                    .WithOne(p => p.Domicilio)
                    .HasForeignKey<Domicilio>(d => d.Iddomicilio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_db327dfd45ae6d12");
            });

            modelBuilder.Entity<Emisore>(entity =>
            {
                entity.HasKey(e => e.Idemisor)
                    .HasName("emisores_pk");

                entity.ToTable("emisores");

                entity.Property(e => e.Idemisor).HasColumnName("idemisor");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Idclasificacionsectorial).HasColumnName("idclasificacionsectorial");

                entity.Property(e => e.Idtipomercado).HasColumnName("idtipomercado");

                entity.Property(e => e.NombreLargo)
                    .HasColumnType("character varying")
                    .HasColumnName("nombre_largo");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdclasificacionsectorialNavigation)
                    .WithMany(p => p.Emisores)
                    .HasForeignKey(d => d.Idclasificacionsectorial)
                    .HasConstraintName("emisores_fk");

                entity.HasOne(d => d.IdtipomercadoNavigation)
                    .WithMany(p => p.Emisores)
                    .HasForeignKey(d => d.Idtipomercado)
                    .HasConstraintName("emisores_fk_1");
            });

            modelBuilder.Entity<Entidade>(entity =>
            {
                entity.HasKey(e => e.Claveentidad)
                    .HasName("entidades_pk");

                entity.ToTable("entidades");

                entity.Property(e => e.Claveentidad)
                    .ValueGeneratedNever()
                    .HasColumnName("claveentidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Entidadesregulatoria>(entity =>
            {
                entity.HasKey(e => e.Identidadregulatoria)
                    .HasName("entidadesregulatorias_pk");

                entity.ToTable("entidadesregulatorias");

                entity.Property(e => e.Identidadregulatoria)
                    .ValueGeneratedNever()
                    .HasColumnName("identidadregulatoria");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdentidadregulatoriaNavigation)
                    .WithOne(p => p.Entidadesregulatoria)
                    .HasForeignKey<Entidadesregulatoria>(d => d.Identidadregulatoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_41e6b51e7576d727");
            });

            modelBuilder.Entity<Fondo>(entity =>
            {
                entity.HasKey(e => e.Idfondo)
                    .HasName("fondos_pk");

                entity.ToTable("fondos");

                entity.HasIndex(e => e.Clavepizarra, "idx_4d2d1752db923aff")
                    .IsUnique();

                entity.Property(e => e.Idfondo)
                    .ValueGeneratedNever()
                    .HasColumnName("idfondo");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Calificadoraid).HasColumnName("calificadoraid");

                entity.Property(e => e.Clavecasfim)
                    .HasMaxLength(255)
                    .HasColumnName("clavecasfim");

                entity.Property(e => e.Clavecorta)
                    .HasMaxLength(255)
                    .HasColumnName("clavecorta");

                entity.Property(e => e.Clavepizarra)
                    .HasMaxLength(255)
                    .HasColumnName("clavepizarra");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(255)
                    .HasColumnName("comentarios");

                entity.Property(e => e.Comienzaoperarhoy).HasColumnName("comienzaoperarhoy");

                entity.Property(e => e.Custodiovaloresid).HasColumnName("custodiovaloresid");

                entity.Property(e => e.Emisorid).HasColumnName("emisorid");

                entity.Property(e => e.Esemisor).HasColumnName("esemisor");

                entity.Property(e => e.Estatusfondo)
                    .HasMaxLength(255)
                    .HasColumnName("estatusfondo");

                entity.Property(e => e.Fechaalta)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaalta");

                entity.Property(e => e.Fechaautorizacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacion");

                entity.Property(e => e.Fechaautorizacionoficio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacionoficio");

                entity.Property(e => e.Fechacambio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambio");

                entity.Property(e => e.Fechainioperacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechainioperacion");

                entity.Property(e => e.Idhorizonte).HasColumnName("idhorizonte");

                entity.Property(e => e.Idprospecto).HasColumnName("idprospecto");

                entity.Property(e => e.Idtipofondo).HasColumnName("idtipofondo");

                entity.Property(e => e.Idtipomercado).HasColumnName("idtipomercado");

                entity.Property(e => e.Idtipooperacion).HasColumnName("idtipooperacion");

                entity.Property(e => e.Necesitacapitalbancos).HasColumnName("necesitacapitalbancos");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Nombredirector)
                    .HasMaxLength(255)
                    .HasColumnName("nombredirector");

                entity.Property(e => e.Nooficioautorizacion)
                    .HasMaxLength(255)
                    .HasColumnName("nooficioautorizacion");

                entity.Property(e => e.Objetivodeinversion)
                    .HasMaxLength(255)
                    .HasColumnName("objetivodeinversion");

                entity.Property(e => e.Operadoraid).HasColumnName("operadoraid");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(255)
                    .HasColumnName("rfc");

                entity.Property(e => e.Tipodecambio)
                    .HasMaxLength(255)
                    .HasColumnName("tipodecambio");

                entity.Property(e => e.Valuadoraid).HasColumnName("valuadoraid");

                entity.HasOne(d => d.IdhorizonteNavigation)
                    .WithMany(p => p.Fondos)
                    .HasForeignKey(d => d.Idhorizonte)
                    .HasConstraintName("horizontes_fk");

                entity.HasOne(d => d.IdprospectoNavigation)
                    .WithMany(p => p.Fondos)
                    .HasForeignKey(d => d.Idprospecto)
                    .HasConstraintName("fondos_fk");

                entity.HasOne(d => d.IdtipofondoNavigation)
                    .WithMany(p => p.Fondos)
                    .HasForeignKey(d => d.Idtipofondo)
                    .HasConstraintName("tiposfondos_fk");

                entity.HasOne(d => d.IdtipomercadoNavigation)
                    .WithMany(p => p.Fondos)
                    .HasForeignKey(d => d.Idtipomercado)
                    .HasConstraintName("tiposmercado_fk");
            });

            modelBuilder.Entity<Historicoparticipante>(entity =>
            {
                entity.HasKey(e => e.Idhistoricoparticipante)
                    .HasName("historicoparticipantes_pk");

                entity.ToTable("historicoparticipantes");

                entity.Property(e => e.Idhistoricoparticipante).HasColumnName("idhistoricoparticipante");

                entity.Property(e => e.Fecharegistro)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fecharegistro");

                entity.Property(e => e.Fechaversion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaversion");

                entity.Property(e => e.Historico).HasColumnName("historico");

                entity.Property(e => e.Idparticipante).HasColumnName("idparticipante");
            });

            modelBuilder.Entity<Horizonte>(entity =>
            {
                entity.HasKey(e => e.Idhorizonte)
                    .HasName("horizontes_pk");

                entity.ToTable("horizontes");

                entity.Property(e => e.Idhorizonte)
                    .ValueGeneratedNever()
                    .HasColumnName("idhorizonte");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Operadora>(entity =>
            {
                entity.HasKey(e => e.Idoperadora)
                    .HasName("operadoras_pk");

                entity.ToTable("operadoras");

                entity.Property(e => e.Idoperadora)
                    .ValueGeneratedNever()
                    .HasColumnName("idoperadora");

                entity.Property(e => e.Clavecasfim)
                    .HasMaxLength(255)
                    .HasColumnName("clavecasfim");

                entity.Property(e => e.Clavecnbv)
                    .HasMaxLength(255)
                    .HasColumnName("clavecnbv");

                entity.Property(e => e.Clavecorta)
                    .HasMaxLength(255)
                    .HasColumnName("clavecorta");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechaautorizacionoficio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacionoficio");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Numerooficioautorizacion)
                    .HasMaxLength(255)
                    .HasColumnName("numerooficioautorizacion");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdoperadoraNavigation)
                    .WithOne(p => p.Operadora)
                    .HasForeignKey<Operadora>(d => d.Idoperadora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_a73e334788626179");
            });

            modelBuilder.Entity<Participante>(entity =>
            {
                entity.HasKey(e => e.Idparticipante)
                    .HasName("participantes_pk");

                entity.ToTable("participantes");

                entity.HasIndex(e => e.Razonsocial, "idx_2ffac546f04dafc6")
                    .IsUnique();

                entity.Property(e => e.Idparticipante).HasColumnName("idparticipante");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fechaalta)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaalta");

                entity.Property(e => e.Fechacambio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambio");

                entity.Property(e => e.Fechaestatus)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatus");

                entity.Property(e => e.Paginainternet)
                    .HasMaxLength(255)
                    .HasColumnName("paginainternet");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(255)
                    .HasColumnName("razonsocial");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(255)
                    .HasColumnName("rfc");

                entity.HasMany(d => d.Idtipoparticipacions)
                    .WithMany(p => p.Idparticipantes)
                    .UsingEntity<Dictionary<string, object>>(
                        "Participacione",
                        l => l.HasOne<Cattipoparticipante>().WithMany().HasForeignKey("Idtipoparticipacion").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_70b401176f280c2d"),
                        r => r.HasOne<Participante>().WithMany().HasForeignKey("Idparticipante").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_2c358f0d68da3b29"),
                        j =>
                        {
                            j.HasKey("Idparticipante", "Idtipoparticipacion").HasName("participaciones_pk");

                            j.ToTable("participaciones");

                            j.IndexerProperty<long>("Idparticipante").HasColumnName("idparticipante");

                            j.IndexerProperty<long>("Idtipoparticipacion").HasColumnName("idtipoparticipacion");
                        });
            });

            modelBuilder.Entity<Pasot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pasot");

                entity.Property(e => e.Accionesemitidasnuevo)
                    .HasPrecision(19, 2)
                    .HasColumnName("accionesemitidasnuevo");

                entity.Property(e => e.Capitalautorizadonuevo)
                    .HasPrecision(19, 2)
                    .HasColumnName("capitalautorizadonuevo");

                entity.Property(e => e.Clave)
                    .HasMaxLength(255)
                    .HasColumnName("clave");

                entity.Property(e => e.Descripciontipoinversionista)
                    .HasMaxLength(255)
                    .HasColumnName("descripciontipoinversionista");

                entity.Property(e => e.Diarecepcion)
                    .HasPrecision(19, 2)
                    .HasColumnName("diarecepcion");

                entity.Property(e => e.Fecharecepcion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fecharecepcion");

                entity.Property(e => e.Idfondo).HasColumnName("idfondo");

                entity.Property(e => e.Idliquidacioncompra).HasColumnName("idliquidacioncompra");

                entity.Property(e => e.Idliquidacionentradas).HasColumnName("idliquidacionentradas");

                entity.Property(e => e.Idliquidacionsalidas).HasColumnName("idliquidacionsalidas");

                entity.Property(e => e.Idliquidacionventa).HasColumnName("idliquidacionventa");

                entity.Property(e => e.Idserie)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idserie");

                entity.Property(e => e.Idtipoinversionista).HasColumnName("idtipoinversionista");

                entity.Property(e => e.Ispensionados).HasColumnName("ispensionados");

                entity.Property(e => e.Isretenerderivados).HasColumnName("isretenerderivados");

                entity.Property(e => e.Isretenerdividendos).HasColumnName("isretenerdividendos");

                entity.Property(e => e.Liquidacioncompra)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacioncompra");

                entity.Property(e => e.Liquidacionentradas)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacionentradas");

                entity.Property(e => e.Liquidacionsalidas)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacionsalidas");

                entity.Property(e => e.Liquidacionventa)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacionventa");

                entity.Property(e => e.Montomaximodepositochequera)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximodepositochequera");

                entity.Property(e => e.Montomaximoprestamovalores)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximoprestamovalores");

                entity.Property(e => e.Montomaximoreportos)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximoreportos");

                entity.Property(e => e.Montomaximovaloresdeuda)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresdeuda");

                entity.Property(e => e.Montomaximovaloresgub)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresgub");

                entity.Property(e => e.Montomaximovaloresrenta)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresrenta");

                entity.Property(e => e.Montomaximovaloresvencimiento)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresvencimiento");

                entity.Property(e => e.Montominimodepositochequera)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimodepositochequera");

                entity.Property(e => e.Montominimoinversion)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimoinversion");

                entity.Property(e => e.Montominimoprestamovalores)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimoprestamovalores");

                entity.Property(e => e.Montominimoreportos)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimoreportos");

                entity.Property(e => e.Montominimovaloresdeuda)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresdeuda");

                entity.Property(e => e.Montominimovaloresgub)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresgub");

                entity.Property(e => e.Montominimovaloresrenta)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresrenta");

                entity.Property(e => e.Montominimovaloresvencimiento)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresvencimiento");

                entity.Property(e => e.Plazominimo)
                    .HasPrecision(19, 2)
                    .HasColumnName("plazominimo");

                entity.Property(e => e.Porcadministracion)
                    .HasPrecision(19, 2)
                    .HasColumnName("porcadministracion");

                entity.Property(e => e.Precioinicio)
                    .HasPrecision(19, 2)
                    .HasColumnName("precioinicio");

                entity.Property(e => e.Serie)
                    .HasMaxLength(255)
                    .HasColumnName("serie");

                entity.Property(e => e.Tipoisr)
                    .HasMaxLength(255)
                    .HasColumnName("tipoisr");

                entity.Property(e => e.Valornominal)
                    .HasMaxLength(255)
                    .HasColumnName("valornominal");
            });

            modelBuilder.Entity<Prestadore>(entity =>
            {
                entity.HasKey(e => e.Idprestador)
                    .HasName("prestadores_pk");

                entity.ToTable("prestadores");

                entity.Property(e => e.Idprestador).HasColumnName("idprestador");

                entity.Property(e => e.Descsubtipoentidad)
                    .HasMaxLength(100)
                    .HasColumnName("descsubtipoentidad");

                entity.Property(e => e.Idcatprestadorservicio).HasColumnName("idcatprestadorservicio");

                entity.Property(e => e.Idcattipoparticipante).HasColumnName("idcattipoparticipante");

                entity.Property(e => e.Idparticipante).HasColumnName("idparticipante");

                entity.Property(e => e.Idregulatorio)
                    .HasMaxLength(6)
                    .HasColumnName("idregulatorio");

                entity.Property(e => e.Idsubtipoentidad)
                    .HasMaxLength(20)
                    .HasColumnName("idsubtipoentidad");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(30)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Nombrelargo)
                    .HasMaxLength(100)
                    .HasColumnName("nombrelargo");

                entity.Property(e => e.Nombreregulatorio)
                    .HasMaxLength(200)
                    .HasColumnName("nombreregulatorio");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdcatprestadorservicioNavigation)
                    .WithMany(p => p.Prestadores)
                    .HasForeignKey(d => d.Idcatprestadorservicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_0fdeb131ec7aa788");

                entity.HasOne(d => d.IdcattipoparticipanteNavigation)
                    .WithMany(p => p.Prestadores)
                    .HasForeignKey(d => d.Idcattipoparticipante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_77dae494ab8ca792");

                entity.HasOne(d => d.IdparticipanteNavigation)
                    .WithMany(p => p.Prestadores)
                    .HasForeignKey(d => d.Idparticipante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_3ed48479ca560bf0");
            });

            modelBuilder.Entity<Promotoresindependiente>(entity =>
            {
                entity.HasKey(e => e.Idpromotorindependiente)
                    .HasName("promotoresindependientes_pk");

                entity.ToTable("promotoresindependientes");

                entity.Property(e => e.Idpromotorindependiente)
                    .ValueGeneratedNever()
                    .HasColumnName("idpromotorindependiente");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdpromotorindependienteNavigation)
                    .WithOne(p => p.Promotoresindependiente)
                    .HasForeignKey<Promotoresindependiente>(d => d.Idpromotorindependiente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_95ea43d9155fc330");
            });

            modelBuilder.Entity<Prospecto>(entity =>
            {
                entity.HasKey(e => e.Idprospecto)
                    .HasName("prospectos_pk");

                entity.ToTable("prospectos");

                entity.Property(e => e.Idprospecto)
                    .ValueGeneratedNever()
                    .HasColumnName("idprospecto");

                entity.Property(e => e.Activobasevar)
                    .HasMaxLength(300)
                    .HasColumnName("activobasevar");

                entity.Property(e => e.Fechaautorizacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacion");

                entity.Property(e => e.Idproveedorprecios).HasColumnName("idproveedorprecios");

                entity.Property(e => e.IndiceReferencia)
                    .HasMaxLength(300)
                    .HasColumnName("indice_referencia");

                entity.Property(e => e.Ismercadocapital).HasColumnName("ismercadocapital");

                entity.Property(e => e.Ismercadodeuda).HasColumnName("ismercadodeuda");

                entity.Property(e => e.Porcentajecomisionservicios)
                    .HasPrecision(19, 2)
                    .HasColumnName("porcentajecomisionservicios");

                entity.Property(e => e.Tiposociedad)
                    .HasMaxLength(255)
                    .HasColumnName("tiposociedad");

                entity.Property(e => e.Varestablecidopromedio)
                    .HasPrecision(19, 2)
                    .HasColumnName("varestablecidopromedio");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.Idproveedor)
                    .HasName("proveedores_pk");

                entity.ToTable("proveedores");

                entity.Property(e => e.Idproveedor)
                    .ValueGeneratedNever()
                    .HasColumnName("idproveedor");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdproveedorNavigation)
                    .WithOne(p => p.Proveedore)
                    .HasForeignKey<Proveedore>(d => d.Idproveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_1569b636ef930d9d");
            });

            modelBuilder.Entity<Proveedoresprecio>(entity =>
            {
                entity.HasKey(e => e.Idproveedorprecios)
                    .HasName("proveedoresprecio_pk");

                entity.ToTable("proveedoresprecio");

                entity.Property(e => e.Idproveedorprecios)
                    .ValueGeneratedNever()
                    .HasColumnName("idproveedorprecios");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdproveedorpreciosNavigation)
                    .WithOne(p => p.Proveedoresprecio)
                    .HasForeignKey<Proveedoresprecio>(d => d.Idproveedorprecios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_876b8cf9ad30ac6d");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasKey(e => e.Idserie)
                    .HasName("series_pk");

                entity.ToTable("series");

                entity.Property(e => e.Idserie).HasColumnName("idserie");

                entity.Property(e => e.Accionesemitidasnuevo)
                    .HasPrecision(19, 2)
                    .HasColumnName("accionesemitidasnuevo");

                entity.Property(e => e.Borradologico).HasColumnName("borradologico");

                entity.Property(e => e.Capitalautorizadonuevo)
                    .HasPrecision(19, 2)
                    .HasColumnName("capitalautorizadonuevo");

                entity.Property(e => e.Clave)
                    .HasMaxLength(255)
                    .HasColumnName("clave");

                entity.Property(e => e.Comisiondistribucion)
                    .HasPrecision(19, 2)
                    .HasColumnName("comisiondistribucion");

                entity.Property(e => e.Descripciontipoinversionista)
                    .HasMaxLength(255)
                    .HasColumnName("descripciontipoinversionista");

                entity.Property(e => e.Diarecepcion)
                    .HasPrecision(19, 2)
                    .HasColumnName("diarecepcion");

                entity.Property(e => e.Fecharecepcion)
                    .HasMaxLength(100)
                    .HasColumnName("fecharecepcion");

                entity.Property(e => e.Idfondo).HasColumnName("idfondo");

                entity.Property(e => e.Idliquidacioncompra).HasColumnName("idliquidacioncompra");

                entity.Property(e => e.Idliquidacionentradas).HasColumnName("idliquidacionentradas");

                entity.Property(e => e.Idliquidacionsalidas).HasColumnName("idliquidacionsalidas");

                entity.Property(e => e.Idliquidacionventa).HasColumnName("idliquidacionventa");

                entity.Property(e => e.Idtipoinversionista).HasColumnName("idtipoinversionista");

                entity.Property(e => e.Idtipovalor)
                    .HasMaxLength(4)
                    .HasColumnName("idtipovalor");

                entity.Property(e => e.Ispensionados).HasColumnName("ispensionados");

                entity.Property(e => e.Isretenerderivados).HasColumnName("isretenerderivados");

                entity.Property(e => e.Isretenerdividendos).HasColumnName("isretenerdividendos");

                entity.Property(e => e.Liquidacioncompra)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacioncompra");

                entity.Property(e => e.Liquidacionentradas)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacionentradas");

                entity.Property(e => e.Liquidacionsalidas)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacionsalidas");

                entity.Property(e => e.Liquidacionventa)
                    .HasMaxLength(255)
                    .HasColumnName("liquidacionventa");

                entity.Property(e => e.Montomaximodepositochequera)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximodepositochequera");

                entity.Property(e => e.Montomaximoprestamovalores)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximoprestamovalores");

                entity.Property(e => e.Montomaximoreportos)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximoreportos");

                entity.Property(e => e.Montomaximovaloresdeuda)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresdeuda");

                entity.Property(e => e.Montomaximovaloresgub)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresgub");

                entity.Property(e => e.Montomaximovaloresrenta)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresrenta");

                entity.Property(e => e.Montomaximovaloresvencimiento)
                    .HasPrecision(19, 2)
                    .HasColumnName("montomaximovaloresvencimiento");

                entity.Property(e => e.Montominimodepositochequera)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimodepositochequera");

                entity.Property(e => e.Montominimoinversion)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimoinversion");

                entity.Property(e => e.Montominimoprestamovalores)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimoprestamovalores");

                entity.Property(e => e.Montominimoreportos)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimoreportos");

                entity.Property(e => e.Montominimovaloresdeuda)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresdeuda");

                entity.Property(e => e.Montominimovaloresgub)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresgub");

                entity.Property(e => e.Montominimovaloresrenta)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresrenta");

                entity.Property(e => e.Montominimovaloresvencimiento)
                    .HasPrecision(19, 2)
                    .HasColumnName("montominimovaloresvencimiento");

                entity.Property(e => e.Plazominimo).HasColumnName("plazominimo");

                entity.Property(e => e.Porcadministracion)
                    .HasPrecision(19, 2)
                    .HasColumnName("porcadministracion");

                entity.Property(e => e.Precioinicio)
                    .HasPrecision(19, 2)
                    .HasColumnName("precioinicio");

                entity.Property(e => e.Serie)
                    .HasMaxLength(255)
                    .HasColumnName("serie");

                entity.Property(e => e.Tipoisr)
                    .HasMaxLength(255)
                    .HasColumnName("tipoisr");

                entity.Property(e => e.Valornominal)
                    .HasMaxLength(255)
                    .HasColumnName("valornominal");

                entity.HasOne(d => d.IdfondoNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.Idfondo)
                    .HasConstraintName("fk_5441b367e30d826d");
            });

            modelBuilder.Entity<Seriesiefore>(entity =>
            {
                entity.HasKey(e => e.Idseriesiefore)
                    .HasName("seriesiefores_pk");

                entity.ToTable("seriesiefores");

                entity.Property(e => e.Idseriesiefore).HasColumnName("idseriesiefore");

                entity.Property(e => e.Accionestrabajo)
                    .HasPrecision(19, 2)
                    .HasColumnName("accionestrabajo");

                entity.Property(e => e.Borradologico).HasColumnName("borradologico");

                entity.Property(e => e.Capitalfijosinderec)
                    .HasPrecision(19, 2)
                    .HasColumnName("capitalfijosinderec");

                entity.Property(e => e.Comision)
                    .HasPrecision(19, 2)
                    .HasColumnName("comision");

                entity.Property(e => e.Idsiefore).HasColumnName("idsiefore");

                entity.Property(e => e.Idtiposerie).HasColumnName("idtiposerie");

                entity.Property(e => e.Idtipovalor)
                    .HasMaxLength(4)
                    .HasColumnName("idtipovalor");

                entity.Property(e => e.Reservaespecial)
                    .HasPrecision(19, 2)
                    .HasColumnName("reservaespecial");

                entity.Property(e => e.Seriesiefore1)
                    .HasMaxLength(10)
                    .HasColumnName("seriesiefore");

                entity.Property(e => e.Valornominal)
                    .HasPrecision(19, 6)
                    .HasColumnName("valornominal");

                entity.HasOne(d => d.IdsieforeNavigation)
                    .WithMany(p => p.Seriesiefores)
                    .HasForeignKey(d => d.Idsiefore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_4917db65f8439eb0");
            });

            modelBuilder.Entity<Siefore>(entity =>
            {
                entity.HasKey(e => e.Idsiefore)
                    .HasName("siefores_pk");

                entity.ToTable("siefores");

                entity.Property(e => e.Idsiefore).HasColumnName("idsiefore");

                entity.Property(e => e.Accionesemitidas)
                    .HasPrecision(19, 2)
                    .HasColumnName("accionesemitidas");

                entity.Property(e => e.Activacion).HasColumnName("activacion");

                entity.Property(e => e.Archivodoc).HasColumnName("archivodoc");

                entity.Property(e => e.Archivonombre)
                    .HasMaxLength(350)
                    .HasColumnName("archivonombre");

                entity.Property(e => e.Calificadoraid).HasColumnName("calificadoraid");

                entity.Property(e => e.Capitalsocialautorizado)
                    .HasPrecision(19, 2)
                    .HasColumnName("capitalsocialautorizado");

                entity.Property(e => e.Clavecorta)
                    .HasMaxLength(255)
                    .HasColumnName("clavecorta");

                entity.Property(e => e.Clavepizarra)
                    .HasMaxLength(255)
                    .HasColumnName("clavepizarra");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(255)
                    .HasColumnName("comentarios");

                entity.Property(e => e.Custodiovaloresid).HasColumnName("custodiovaloresid");

                entity.Property(e => e.Descripcionsociedadinversion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcionsociedadinversion");

                entity.Property(e => e.Descripcionsubtipoentidad)
                    .HasMaxLength(150)
                    .HasColumnName("descripcionsubtipoentidad");

                entity.Property(e => e.Descripciontipoentidad)
                    .HasColumnType("character varying")
                    .HasColumnName("descripciontipoentidad");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(255)
                    .HasColumnName("estatus");

                entity.Property(e => e.Fechaalta)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaalta");

                entity.Property(e => e.Fechaautorizacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacion");

                entity.Property(e => e.Fechaautorizacionoficio)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaautorizacionoficio");

                entity.Property(e => e.Fechainiciooperaciones)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechainiciooperaciones");

                entity.Property(e => e.Fechamodificacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechamodificacion");

                entity.Property(e => e.Idafore).HasColumnName("idafore");

                entity.Property(e => e.Iddivisaoperaciones).HasColumnName("iddivisaoperaciones");

                entity.Property(e => e.Idsubtipoentidad)
                    .HasMaxLength(10)
                    .HasColumnName("idsubtipoentidad");

                entity.Property(e => e.Idtipoentidad).HasColumnName("idtipoentidad");

                entity.Property(e => e.Idtipomercado).HasColumnName("idtipomercado");

                entity.Property(e => e.Idtipooperacion).HasColumnName("idtipooperacion");

                entity.Property(e => e.Idtiposociedadinversion).HasColumnName("idtiposociedadinversion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("nombre");

                entity.Property(e => e.Nooficioautorizacion)
                    .HasMaxLength(255)
                    .HasColumnName("nooficioautorizacion");

                entity.Property(e => e.Padreid).HasColumnName("padreid");

                entity.Property(e => e.Proveedorpreciosid).HasColumnName("proveedorpreciosid");

                entity.Property(e => e.Rfc)
                    .HasMaxLength(255)
                    .HasColumnName("rfc");

                entity.Property(e => e.Tipodecambio)
                    .HasMaxLength(255)
                    .HasColumnName("tipodecambio");

                entity.Property(e => e.Valornominalaccion)
                    .HasPrecision(19, 2)
                    .HasColumnName("valornominalaccion");

                entity.Property(e => e.Valuadoraid).HasColumnName("valuadoraid");

                entity.HasOne(d => d.IdaforeNavigation)
                    .WithMany(p => p.Siefores)
                    .HasForeignKey(d => d.Idafore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_77ccc32f31dd9e7d");

                entity.HasOne(d => d.IdtipomercadoNavigation)
                    .WithMany(p => p.Siefores)
                    .HasForeignKey(d => d.Idtipomercado)
                    .HasConstraintName("fk_430ce955d46a0ec3");

                entity.HasOne(d => d.IdtipooperacionNavigation)
                    .WithMany(p => p.Siefores)
                    .HasForeignKey(d => d.Idtipooperacion)
                    .HasConstraintName("fk_38bd2337f818abad");
            });

            modelBuilder.Entity<Sociosliquidadore>(entity =>
            {
                entity.HasKey(e => e.Idsocioliquidador)
                    .HasName("sociosliquidadores_pk");

                entity.ToTable("sociosliquidadores");

                entity.Property(e => e.Idsocioliquidador)
                    .ValueGeneratedNever()
                    .HasColumnName("idsocioliquidador");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdsocioliquidadorNavigation)
                    .WithOne(p => p.Sociosliquidadore)
                    .HasForeignKey<Sociosliquidadore>(d => d.Idsocioliquidador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_b586b1106905e344");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Info)
                    .HasColumnType("json")
                    .HasColumnName("info");
            });

            modelBuilder.Entity<Tiposcalificacion>(entity =>
            {
                entity.HasKey(e => e.Idtipocalificacion)
                    .HasName("tiposcalificacion_pk");

                entity.ToTable("tiposcalificacion");

                entity.Property(e => e.Idtipocalificacion)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipocalificacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Tiposemisor>(entity =>
            {
                entity.HasKey(e => e.Idtipoemisor)
                    .HasName("tiposemisor_pk");

                entity.ToTable("tiposemisor");

                entity.Property(e => e.Idtipoemisor)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipoemisor");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Tiposentidad>(entity =>
            {
                entity.HasKey(e => e.Idtipoentidad)
                    .HasName("tiposentidad_pk");

                entity.ToTable("tiposentidad");

                entity.Property(e => e.Idtipoentidad)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipoentidad");

                entity.Property(e => e.Abreviacion)
                    .HasMaxLength(255)
                    .HasColumnName("abreviacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Tiposfondo>(entity =>
            {
                entity.HasKey(e => e.Idtipofondo)
                    .HasName("tiposfondo_pk");

                entity.ToTable("tiposfondo");

                entity.Property(e => e.Idtipofondo)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipofondo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Tiposmercado>(entity =>
            {
                entity.HasKey(e => e.Idtipomercado)
                    .HasName("tiposmercado_pk");

                entity.ToTable("tiposmercado");

                entity.Property(e => e.Idtipomercado).HasColumnName("idtipomercado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Tiposociedadesinversion>(entity =>
            {
                entity.HasKey(e => e.Idtiposociedadinversion)
                    .HasName("tiposociedadesinversion_pk");

                entity.ToTable("tiposociedadesinversion");

                entity.Property(e => e.Idtiposociedadinversion)
                    .ValueGeneratedNever()
                    .HasColumnName("idtiposociedadinversion");

                entity.Property(e => e.Claveentidad).HasColumnName("claveentidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(255)
                    .HasColumnName("razonsocial");

                entity.Property(e => e.Subtipoentidad).HasColumnName("subtipoentidad");

                entity.Property(e => e.Tipoentidad).HasColumnName("tipoentidad");
            });

            modelBuilder.Entity<Tiposoperacion>(entity =>
            {
                entity.HasKey(e => e.Idtipooperacion)
                    .HasName("tiposoperacion_pk");

                entity.ToTable("tiposoperacion");

                entity.Property(e => e.Idtipooperacion)
                    .ValueGeneratedNever()
                    .HasColumnName("idtipooperacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Valuadora>(entity =>
            {
                entity.HasKey(e => e.Idvaluadora)
                    .HasName("valuadoras_pk");

                entity.ToTable("valuadoras");

                entity.Property(e => e.Idvaluadora)
                    .ValueGeneratedNever()
                    .HasColumnName("idvaluadora");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdvaluadoraNavigation)
                    .WithOne(p => p.Valuadora)
                    .HasForeignKey<Valuadora>(d => d.Idvaluadora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_3eb54e4acb64f7de");
            });

            modelBuilder.Entity<Valuadorasempleado>(entity =>
            {
                entity.HasKey(e => e.Idvaluadoraempleados)
                    .HasName("valuadorasempleados_pk");

                entity.ToTable("valuadorasempleados");

                entity.Property(e => e.Idvaluadoraempleados)
                    .ValueGeneratedNever()
                    .HasColumnName("idvaluadoraempleados");

                entity.Property(e => e.Estatusparticipacion)
                    .HasMaxLength(255)
                    .HasColumnName("estatusparticipacion");

                entity.Property(e => e.Fechaaltaparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaaltaparticipacion");

                entity.Property(e => e.Fechacambioparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechacambioparticipacion");

                entity.Property(e => e.Fechaestatusparticipacion)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("fechaestatusparticipacion");

                entity.Property(e => e.Nombrecorto)
                    .HasMaxLength(255)
                    .HasColumnName("nombrecorto");

                entity.Property(e => e.Responsableinformacion)
                    .HasMaxLength(255)
                    .HasColumnName("responsableinformacion");

                entity.HasOne(d => d.IdvaluadoraempleadosNavigation)
                    .WithOne(p => p.Valuadorasempleado)
                    .HasForeignKey<Valuadorasempleado>(d => d.Idvaluadoraempleados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_391b1189bb236eef");
            });

            modelBuilder.HasSequence("afores_idafore_seq").HasMin(317);

            modelBuilder.HasSequence("autorizacionesestado_idautorizacionestado_seq").HasMin(874);

            modelBuilder.HasSequence("contactos_idcontacto_seq").HasMin(900);

            modelBuilder.HasSequence("hibernate_sequence");

            modelBuilder.HasSequence("idprospect").HasMax(999999);

            modelBuilder.HasSequence("participantes_idparticipante_seq").HasMin(316);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
