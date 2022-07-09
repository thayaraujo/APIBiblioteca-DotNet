using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoMakersCode.Biblioteca.Core.Entities;

namespace WoMakersCode.Biblioteca.Core.Repositories
{
    public interface IAutorRepository : IRepository<Autor>
    {
        Task Inserir(Autor obj);
        Task Atualizar(Autor obj);
        //IEnumerable são arrays, listas... o que consegue listar de uma vez
        Task<IEnumerable<Autor>> ListarTodos();
        Task<Autor> ListarPorId(int id);
        Task Excluir(int id);
    }
}
