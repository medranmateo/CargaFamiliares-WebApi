using CargaFamiliares_WebApi.Domain.Entities.Tipos;

namespace CargaFamiliares_WebApi.Application.Interfaces.IRepositories
{
    public interface ITiposDescripcionRepository
    {
        public Task<IEnumerable<Documento>> ObtenerTiposDocumento();

        public Task<IEnumerable<Escolaridad>> ObtenerTipoEscolaridad();

        public Task<IEnumerable<Parentesco>> ObtenerTipoParentesco();

        public Task<IEnumerable<TipoSexo>> ObtenerTipoSexo();

        public Task<IEnumerable<Ocupacion>> ObtenerOcupaciones();

        public Task<IEnumerable<EstadoCivil>> ObtenerEstadosCiviles();
    }
}
