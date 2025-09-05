using CargaFamiliares_WebApi.Application.Interfaces.IRepositories;
using CargaFamiliares_WebApi.Application.Interfaces.IServices;
using CargaFamiliares_WebApi.Domain.Entities.Tipos;

namespace CargaFamiliares_WebApi.Application.Services
{
    public class TiposDescripcionService : ITiposDescripcionService
    {
        private readonly ITiposDescripcionRepository _tiposDescripcionRepository;
        public TiposDescripcionService(ITiposDescripcionRepository tiposDescripcionRepository)
        {
            _tiposDescripcionRepository = tiposDescripcionRepository;
        }

        public async Task<Agrupados> ObtenerTiposAgrupados()
        {
            var dto = new Agrupados
            {
                Documentos = await _tiposDescripcionRepository.ObtenerTiposDocumento(),
                Escolaridades = await _tiposDescripcionRepository.ObtenerTipoEscolaridad(),
                Parentescos = await _tiposDescripcionRepository.ObtenerTipoParentesco(),
                Ocupaciones = await _tiposDescripcionRepository.ObtenerOcupaciones(),
                EstadosCiviles = await _tiposDescripcionRepository.ObtenerEstadosCiviles()
            };

            return dto;
        }

        public async Task<IEnumerable<Escolaridad>> ObtenerTipoEscolaridad()
        {
            var escolaridades = await _tiposDescripcionRepository.ObtenerTipoEscolaridad();
            return escolaridades;
        }

        public async Task<IEnumerable<Parentesco>> ObtenerTipoParentesco()
        {
            var parentescos = await _tiposDescripcionRepository.ObtenerTipoParentesco();
            return parentescos;
        }


        public async Task<IEnumerable<Documento>> ObtenerTiposDocumento()
        {
            var documentos = await _tiposDescripcionRepository.ObtenerTiposDocumento();
            return documentos;
        }

        public async Task<IEnumerable<TipoSexo>> ObtenerTipoSexo()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ocupacion>> ObtenerOcupaciones()
        {
            var ocupaciones = await _tiposDescripcionRepository.ObtenerOcupaciones();
            return ocupaciones;
        }

        public async Task<IEnumerable<EstadoCivil>> ObtenerEstadosCiviles()
        {
            var estadosCiviles = await _tiposDescripcionRepository.ObtenerEstadosCiviles();
            return estadosCiviles;
        }
    }
}
