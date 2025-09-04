using CargaFamiliares_WebApi.Application.Interfaces.IRepositories;
using CargaFamiliares_WebApi.Data;
using CargaFamiliares_WebApi.Domain.DTO;
using CargaFamiliares_WebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CargaFamiliares_WebApi.Application.Repositories
{
    public class FamiliaresRepository : IFamiliaresRepository
    {
        private readonly AppDbContext _context;

        public FamiliaresRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> ActualizarPersona(ActualizarPersona per)
        {
            var sql = "EXEC SP_ACTUALIZA_PERSONA @TIP_TIPDOC ={0}, @PER_NRODOC ={1}, @EST_CODIGO ={2}, @SEX_CODIGO ={3}, " +
                "@OBR_CODIGO ={4}, @PER_FECNAC ={5}, @PER_TIOBSO ={6}, @OCU_CODIGO ={7}";

            return await _context.Database.ExecuteSqlRawAsync(sql, per.TipoDocumento, per.NumeroDocumento, per.EstadoCivilCodigo,
                per.SexoCodigo, per.ObraSocialCodigo, per.FechaNacimiento, per.TIOBSO, per.Ocupacion);
        }

        public async Task<IEnumerable<BuscoFamiliar>> BuscarFamiliares(string tipoDoc, string nroDoc)
        {
            var familires = await _context.BuscoFamiliar
                .FromSqlInterpolated($"EXEC SP_BuscoFamiliares {tipoDoc}, {nroDoc}")
                .ToListAsync();

            return familires;
        }

        public async Task<int> CrearFamiliar(InsertFamiliar fam)
        {
            var sql = "EXEC SP_INSERTOFAMILIAR @TIP_TIPDOC ={0}, @PER_NRODOC ={1}, @MAT_TIP_TIPDOC ={2},  " +
                "@MAT_PER_NRODOC ={3}, @ESC_CODIGO ={4}, @PAR_CODIGO ={5}, @FAM_ACARGO ={6}, @FAM_INCAPA ={7}, " +
                " @FAM_CONVIV ={8}, @FAM_RECPRO ={9}, @FAM_ORDEN  ={10}";

            return await _context.Database.ExecuteSqlRawAsync(sql, fam.TipoDocumento, fam.NumeroDocumento, fam.TitularTipoDocumento,
                fam.TitularNumeroDocumento, fam.EstadoCivilCodigo, fam.ParentescoCodigo, fam.FAM_ACARGO, fam.Discapacidad,
                fam.FAM_CONVIV, fam.FAM_RECPRO, fam.FAM_ORDEN);
        }

        public async Task<int> CrearPersona(InsertPersona pe)
        {
            var sql = "EXEC SP_INSERT_PERSONA @TIP_TIPDOC ={0}, @PER_NRODOC ={1}, @EST_CODIGO ={2}, @SEX_CODIGO ={3}, " +
                "@OBR_CODIGO ={4}, @TPE_CODIGO ={5}, @PER_APELLI ={6}, @PER_NOMBRE ={7}, @PER_FECNAC ={8}, @PER_DARBAJ ={9}, " +
                " @PER_TIOBSO ={10}, @PER_OSOBLI ={11}, @PER_NUPCIA ={12}, @idPersona ={13}";

            return await _context.Database.ExecuteSqlRawAsync(sql, pe.TipoDocumento, pe.NumeroDocumento, pe.EstadoCivilCodigo,
                pe.SexoCodigo, pe.ObraSocialCodigo, pe.TipoPersonaCodigo, pe.Apellido, pe.Nombre, pe.FechaNacimiento,
                pe.Personabaja ?? 0, pe.TIOBSO, pe.PER_OSOBLI, pe.PER_NUPCIA, pe.idPersona! );
        }

        public async Task<FamiliarDTO> ObtenerFamiliarByDoc(string tipoDocumento, string numeroDocumento)
        {
            var familiar = await _context.FamiliarDTO.FirstOrDefaultAsync(f => f.TipoDocumento == tipoDocumento && f.NumeroDocumento == numeroDocumento);
            return familiar;
        }

        public async Task<int> ObtenerIdPersona()
        {
            //var sql = "SELECT MAX(idPersona) FROM PERSONA";
            //var maxId = await _context.Database.SqlQueryRaw<int>(sql).FirstAsync();

            var sql = "SELECT MAX(idPersona) AS IdPersona FROM PERSONA";
            var result = await _context.Set<PersonaIdDto>().FromSqlRaw(sql).ToListAsync();

            var maxId = result.FirstOrDefault()?.IdPersona ?? 0;

            return maxId + 1;
        }

        public async Task<PersonaDTO> ObtenerPersonaByDoc(string tipoDocumento, string numeroDocumento)
        {
            var persona = await _context.PersonaDTO.FirstOrDefaultAsync(p => p.TipoDocumento == tipoDocumento && p.NumeroDocumento == numeroDocumento);
            return persona;
        }

    }
}
