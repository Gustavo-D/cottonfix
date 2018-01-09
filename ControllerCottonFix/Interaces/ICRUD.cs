using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerCottonFix.Interfaces
{
    public interface ICRUD<T> : IDisposable where T : class, new()
    {
        //Cria registro do tipo passado como parâmetro, retornando um objeto
        T Criar(T model);

        //Atualiza registro do tipo passado como parâmetro, retornando true para sucesso e false para falha
        bool Atualizar(T model);

        //Exclui registro(possivel alteração do seu status para inativo) tipo passado como parâmetro, retornando true para sucesso e false para falha
        bool Excluir(T model);

        //Pesquisa o codigo passado como parâmetro, retornando um objeto 
        T PesquisarCodigo(int codigoId);

        //Lista todos registros das tabelas, retornando uma lista de objetos
        Collection<T> Listar();
    }
}
