using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities
{
    public class InsertPersona
    {

        [Column("TIP_TIPDOC")]
        public string TipoDocumento { get; set; } = string.Empty;
        [Column("PER_NRODOC")]
        public string NumeroDocumento { get; set; } = string.Empty;

        [Column("EST_CODIGO")]
        public int EstadoCivilCodigo { get; set; } = 0;

        [Column("SEX_CODIGO")]
        public int SexoCodigo { get; set; } = 0;

        [Column("OBR_CODIGO")]
        public int ObraSocialCodigo { get; set; } = 0;

        [Column("PER_FECNAC")]
        public DateTime FechaNacimiento { get; set; }

        [Column("PER_TIOBSO")]
        public int TIOBSO { get; set; } = 0;

        [Column("TPE_CODIGO")]
        public int TipoPersona { get; set; } = 0;

        [Column("PER_APELLI")]
        public string Apellido { get; set;} = string.Empty;

        [Column("PER_NOMBRE")]
        public string Nombre { get; set;} = string.Empty;

        [Column("PER_DARBAJ")]
        public int? Personabaja { get; set;}

        [Column("PER_OSOBLI")]
        public int PER_OSOBLI { get; set;} = 0;

        [Column("PER_NUPCIA")]
        public int PER_NUPCIA { get; set;} = 0;

        [Column("idPersona")]
        public int? idPersona { get; set;} = 0;

    }
}
