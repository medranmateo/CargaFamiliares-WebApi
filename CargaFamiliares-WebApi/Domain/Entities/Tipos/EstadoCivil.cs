using System.ComponentModel.DataAnnotations.Schema;

namespace CargaFamiliares_WebApi.Domain.Entities.Tipos
{
    [Table("ESTADO_CIVIL")]
    public class EstadoCivil
    {
        [Column("EST_CODIGO")]
        public int Codigo { get; set; }
        [Column("EST_DESCRI")]
        public string Descripcion { get; set; } = string.Empty;

    }
}
