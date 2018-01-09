using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCottonFix
{
    public class ModelAcesso : BaseClass<ACESSO>
    {
        public override bool Salvar(bool Insert, ACESSO objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    if (Insert)
                    {
                        var acesso = (from m in db.ACESSO where m.USUARIO == objeto.USUARIO select m).FirstOrDefault();
                        if (acesso == null)
                        {
                            db.ACESSO.Add(objeto);
                        }
                    }
                    else
                    {
                        db.ACESSO.Attach(objeto);
                    }
                        return (db.SaveChanges() > 0);
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Excluir(ACESSO objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    var acesso = (from m in db.ACESSO where m.USUARIO == objeto.USUARIO select m).FirstOrDefault();
                    if (acesso != null)
                    {
                        db.ACESSO.Remove(acesso);
                    } 
                    return (db.SaveChanges() > 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
