using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCottonFix
{
    class ModelVendedor : BaseClass<VENDEDOR>
    {
        public override bool Salvar(bool Insert, VENDEDOR objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    if (Insert)
                    {
                        VENDEDOR cliente = (from m in db.VENDEDOR where m.RAZAO_SOCIAL.ToUpper().Contains(objeto.RAZAO_SOCIAL.ToUpper()) select m).SingleOrDefault();
                        if (cliente == null)
                        {
                            db.VENDEDOR.Add(objeto);
                        }
                    }
                    else
                    {
                        db.VENDEDOR.Attach(objeto);
                    }
                    return (db.SaveChanges() > 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Excluir(VENDEDOR objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {

                    VENDEDOR clienteVendedor = (from m in db.VENDEDOR where m.ID_VENDEDOR == objeto.ID_VENDEDOR select m).FirstOrDefault();
                    if (clienteVendedor != null)
                    {
                        db.VENDEDOR.Remove(clienteVendedor);
                    }
                    return (db.SaveChanges() > 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override VENDEDOR Pesquisar(int codigo)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    return (from m in db.VENDEDOR where m.ID_VENDEDOR == codigo select m).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<VENDEDOR> PesquisarTodos()
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    return db.VENDEDOR.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<VENDEDOR> PesquisarTexto(string descricao)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    return (from m in db.VENDEDOR where m.PESSOA.NOME.ToUpper().Contains(descricao.ToUpper()) select m).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
