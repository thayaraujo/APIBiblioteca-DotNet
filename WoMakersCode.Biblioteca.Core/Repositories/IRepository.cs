using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoMakersCode.Biblioteca.Core.Repositories
{
    public interface IRepository<T>
    {
        //Esse T é usado quando está trabalhando com genéricos, ou seja, posso passar aqui Livro, Autor, etc.
        Task Inserir(T obj);
        Task Atualizar(T obj);
        //IEnumerable são arrays, listas... o que consegue listar de uma vez
        Task<IEnumerable<T>> ListarTodos();
        Task<T> ListarPorId(int id);
        Task Excluir(int id);
    }
}
