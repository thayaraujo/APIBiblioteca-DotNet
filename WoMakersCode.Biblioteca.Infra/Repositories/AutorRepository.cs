using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoMakersCode.Biblioteca.Core.Entities;
using WoMakersCode.Biblioteca.Core.Repositories;

namespace WoMakersCode.Biblioteca.Infra.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        public async Task Atualizar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Autor obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Autor> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Autor>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
