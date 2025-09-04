using CargaFamiliares_WebApi.Domain.Entities.Tipos;

namespace CargaFamiliares_WebApi.Application.Interfaces.IServices
{
    public interface ITiposDescripcionService
    {
        public Task<IEnumerable<Documento>> ObtenerTiposDocumento();
        public Task<IEnumerable<Escolaridad>> ObtenerTipoEscolaridad();
        public Task<IEnumerable<Parentesco>> ObtenerTipoParentesco();
        public Task<IEnumerable<TipoSexo>> ObtenerTipoSexo();
        public Task<IEnumerable<Ocupacion>> ObtenerOcupaciones();

        public Task<Agrupados> ObtenerTiposAgrupados();
    }
}
