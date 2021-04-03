using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace cad_pessoa_blazor.Entities
{
    public class PessoaService
    {
        private CadPessoaContext _dbContext;
        public PessoaService(CadPessoaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Pessoa>> GetPessoasTaskAsync()
        {
            return await _dbContext.Pessoa.ToListAsync();
        }

        public async Task<Pessoa> AddPessoa(Pessoa pessoa)
        {
            try
            {
                _dbContext.Pessoa.Add(pessoa);
                await _dbContext.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                throw;
            }

            return pessoa;

        }

        public async Task<Pessoa> UpdatePessoa(Pessoa pessoa)
        {
            try
            {
                var pessoaExist = _dbContext.Pessoa.FirstOrDefault(x => x.Id == pessoa.Id);
                if (pessoa != null)
                {
                    _dbContext.Pessoa.Update(pessoa);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (System.Exception)
            {

                throw;
            }

            return pessoa;
        }

        public async Task DeletePessoa(Pessoa pessoa)
        {
            try
            {
                _dbContext.Pessoa.Remove(pessoa);
                await _dbContext.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}