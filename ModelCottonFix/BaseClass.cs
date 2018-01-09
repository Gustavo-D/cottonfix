using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCottonFix
{
    public abstract class BaseClass<T> : ICrudBase<T>
    {
        public abstract bool Salvar(bool Insert, T objeto);
       
        public abstract bool Excluir(T objeto);
       
        public virtual T Pesquisar(int codigo)
        {
            return default(T);
        }
        public virtual List<T> PesquisarTodos()
        {
            return new List<T>();
        }
        public virtual List<T> PesquisarTexto(string descricao)
        {
            return new List<T>();
        }
    }
}
