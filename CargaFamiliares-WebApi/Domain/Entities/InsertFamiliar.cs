using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities
{
    public class InsertFamiliar
    {
        [Column("TIP_TIPDOC")]
        public string TipoDocumento { get; set; } = string.Empty;

        [Column("PER_NRODOC")]
        public string NumeroDocumento { get; set; } = string.Empty;

        [Column("MAT_TIP_TIPDOC")]
        public string TitularTipoDocumento { get; set; } = string.Empty;

        [Column("MAT_PER_NRODOC")]
        public string TitularNumeroDocumento { get; set; } = string.Empty;

        [Column("ESC_CODIGO")]
        public int EstadoCivilCodigo { get; set; } = 0;

        [Column("PAR_CODIGO")]
        public int ParentescoCodigo { get; set; } = 0;

        [Column("FAM_ACARGO")]
        public int FAM_ACARGO { get; set; } = 0;

        [Column("FAM_INCAPA")]
        public int Discapacidad { get; set; } = 0;

        [Column("FAM_CONVIV")]
        public int FAM_CONVIV { get; set; } = 0;

        [Column("FAM_RECPRO")]
        public int FAM_RECPRO { get; set; } = 0;

        [Column("FAM_ORDEN")]
        public int FAM_ORDEN { get; set; } = 0;
    }
}
