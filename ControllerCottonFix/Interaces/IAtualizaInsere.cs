using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerCottonFix.Interfaces
{
    public interface IAtualizaInsere<T> : IDisposable where T : class, new()
    {
        T Criar(T model);

        T Atualizar(T model);

        Collection<T> ListaPeloId(int codigoId);
    }
}
