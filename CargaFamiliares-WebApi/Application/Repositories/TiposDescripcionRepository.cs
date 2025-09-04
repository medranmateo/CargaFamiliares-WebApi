using CargaFamiliares_WebApi.Application.Interfaces.IRepositories;
using CargaFamiliares_WebApi.Data;
using CargaFamiliares_WebApi.Domain.Entities.Tipos;
using Microsoft.EntityFrameworkCore;

namespace CargaFamiliares_WebApi.Application.Repositories
{
    public class TiposDescripcionRepository : ITiposDescripcionRepository
    {
        private readonly AppDbContext _context;

        public TiposDescripcionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ocupacion>> ObtenerOcupaciones()
        {
            var ocupaciones = await _context.Ocupaciones.ToListAsync();
            return ocupaciones;
        }

        public async Task<IEnumerable<Escolaridad>> ObtenerTipoEscolaridad()
        {
            var escolaridades = await _context.Escolaridades.ToListAsync();
            return escolaridades;
        }

        public async Task<IEnumerable<Parentesco>> ObtenerTipoParentesco()
        {
            var parentescos = await _context.Parentescos.ToListAsync();
            return parentescos;
        }

        public async Task<IEnumerable<Documento>> ObtenerTiposDocumento()
        {
            var documentos = await _context.Documentos.ToListAsync();
            return documentos;
        }

        public Task<IEnumerable<TipoSexo>> ObtenerTipoSexo()
        {
            throw new NotImplementedException();
        }
    }
}
