using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities
{
    public class ActualizarPersona
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

        [Column("OCU_CODIGO")]
        public int Ocupacion { get; set; } = 0;
    }
}
