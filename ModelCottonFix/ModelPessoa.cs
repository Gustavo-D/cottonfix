using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCottonFix
{
    public class ModelPessoa : BaseClass<PESSOA>
    {
        public override bool Salvar(bool Insert, PESSOA objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    if (Insert)
                    {
                        var pessoa = (from m in db.PESSOA where m.ID_PESSOA == objeto.ID_PESSOA select m).FirstOrDefault();
                        if (pessoa == null)
                        {
                            db.PESSOA.Add(objeto);
                        }
                    }
                    else
                    {
                        db.PESSOA.Attach(objeto);
                    }
                    return (db.SaveChanges() > 0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Excluir(PESSOA objeto)
        {
            try
            {
                using (ModeloCottonFixBD db = new ModeloCottonFixBD())
                {
                    var pessoa = (from m in db.PESSOA where m.ID_PESSOA == objeto.ID_PESSOA select m).FirstOrDefault();
                    if (pessoa != null)
                    {
                        db.PESSOA.Remove(pessoa);
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
