using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoMakersCode.Biblioteca.Core.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int IdAutor { get; set; }
        //Autor é uma propriedade de navegação: quando trazer os registros do meu banco consigo trazer os dados da tabela autor vinculados nessa tabela
        public Autor Autor { get; set; }
    }
}
