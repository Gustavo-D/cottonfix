using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerCottonFix.Interfaces
{
    public interface IPesquisaSimples<T> : IDisposable where T : class, new()
    {
        T PesquisarCodigo(int codigo);

        T PesquisarDescricao(string descricao);

        Collection<T> Listar();
    }
}
