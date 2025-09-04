using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities
{
    public class BuscoFamiliar
    {
        [Column("PER_NOMBRE")]
        public string? Nombre { get; set; }
        [Column("PER_APELLI")]
        public string? Apellido { get; set; }
        [Column("TIP_TIPDOC")]
        public string? TipoDocumento { get; set; }
        [Column("PER_NRODOC")]
        public string? NumeroDocumento { get; set; }
        [Column("PER_FECNAC")]
        public DateTime? FechaNacimiento { get; set; }
        [Column("PAR_CODIGO")]
        public int? Parentesco { get; set; }
        //[Column("")]
        //public string? EstadoCivil { get; set; }
        [Column("SEX_CODIGO")]
        public int? Sexo { get; set; }
        [Column("OCU_CODIGO")]
        public int? Profesion { get; set; }
        [Column("FAM_INCAPA")]
        public bool? Discapacidad { get; set; }
        [Column("ESC_CODIGO")]
        public int? Escolaridad { get; set; }
        [Column("OBR_CODIGO")]
        public int? ObraSocialCodigo { get; set; }
        [Column("PER_TIOBSO")]
        public bool? TIOBSO {  get; set; } = false;
        [Column("PER_OSOBLI")]
        public bool? OSOBLI { get; set; }
        [Column("PER_NUPCIA")]
        public int? NUPCIA { get; set; }

        [Column("TPE_CODIGO")]
        public int? TipoPersona { get; set; }
    }
}
