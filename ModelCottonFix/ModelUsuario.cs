using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCottonFix
{
    public class ModelUsuario : BaseClass<USUARIO>
    {
        public override bool Salvar(bool Insert, USUARIO objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    if (Insert)
                    {
                        var usuario = (from m in db.USUARIO where m.ID_USUARIO == objeto.ID_USUARIO select m).FirstOrDefault();
                        if (usuario == null)
                        {
                            db.USUARIO.Add(objeto);
                        }
                    }
                    else
                    {
                        db.USUARIO.Attach(objeto);
                    }
                        return (db.SaveChanges() > 0);                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Excluir(USUARIO objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    var usuario = (from m in db.USUARIO where m.ID_USUARIO == m.ID_USUARIO select m).FirstOrDefault();
                    if (usuario != null)
                    {
                        db.USUARIO.Remove(usuario);
                    }
                    return (db.SaveChanges() > 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override USUARIO Pesquisar(int codigo)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    return (from m in db.USUARIO where m.ID_USUARIO == codigo select m).FirstOrDefault();                     
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override List<USUARIO> PesquisarTodos()
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    return db.USUARIO.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<USUARIO> PesquisarTexto(string descricao)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    return (from m in db.USUARIO where m.PESSOA.NOME.ToUpper().Contains(descricao) select m).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
