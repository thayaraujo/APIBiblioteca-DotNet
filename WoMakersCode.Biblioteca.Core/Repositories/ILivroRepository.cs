using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoMakersCode.Biblioteca.Core.Entities;

namespace WoMakersCode.Biblioteca.Core.Repositories
{
    public interface ILivroRepository : IRepository<Livro>
    {
        public async Task Atualizar(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Livro> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
