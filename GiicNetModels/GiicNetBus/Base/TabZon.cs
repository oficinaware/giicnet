using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Reflection;
using System.Data.Entity;

namespace GiicNetBus.Base
{
    public class TabZon
    {
        public TABZON GetByKey(String codzon, string codpais)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABZON obj = (from c in ctx.TABZON where c.CODZON == codzon && c.CODPAIS == codpais select c).FirstOrDefault();
                if (obj != null) return obj;
                r.Erros = "Não encontra registo...";
                return null;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return null;
            }
        }

        public ResultList GetByPais(string codpais)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABZON where c.CODPAIS == codpais select c).ToList();
                if (obj.Count > 0)
                {
                    r.Status = true;
                    r.Lista = obj;
                    return r;
                }
                r.Status = true;
                r.Erros = "Não Existem Registos...";
                return r;
            }
            catch (Exception ex)
            {
                r.Status = false;
                r.Erros = ex.Message;
                return r;
            }
        }

        
        public ResultList GetAll(Int32 pag, Int32 itemsByPag)
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABZON select c).ToList();
                if (obj.Count > 0)
                {
                    r.Status = true;
                    r.Lista = obj;
                    return r;
                }
                r.Status = true;
                r.Erros = "Não Existem Registos...";
                return r;
            }
            catch (Exception ex)
            {
                r.Status = false;
                r.Erros = ex.Message;
                return r;
            }
        }

        public ResultList Insert(TABZON source)
        {
            TABZON tab = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {

                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABZON obj = GetByKey(tab.CODZON, tab.CODPAIS);
                if (obj == null)
                {
                    ctx.TABZON.Add(tab);
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    if (!msg.Any())
                    {
                        ctx.SaveChanges();
                        r.Status = true;
                        return r;
                    }
                    {
                        r.Erros = (from c in msg select c).FirstOrDefault().ToString();
                        return r;
                    }
                }
                r.Erros = "Registo já existe...";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return r;
            }

        }

        public ResultList Update(TABZON source)
        {
            TABZON tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();

                var obj = GetByKey(tab.CODPAIS,tab.CODZON);
                if (obj != null)
                {
                    ctx.TABZON.Attach(tab);
                    ctx.Entry(tab).State = EntityState.Modified;
                    if (ctx.SaveChanges() > 0)
                    {
                        r.Status = true;
                        return r;
                    }
                    else
                    {
                        r.Status = false;
                        r.Erros = "No records were changed in update process!";
                        return r;
                    }
                }

                r.Erros = "Registo não existe...";
                return r;


             }
            catch (Exception ex)
            {
                r.Erros = ex.Message.ToString();
                return r;
            }
        }

        public ResultList Delete(string codpais,String codzon)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = GetByKey(codpais,codzon);
                if (obj != null)
                {
                    ctx.TABZON.Attach(obj);
                    ctx.TABZON.Remove(obj);
                    ctx.SaveChanges();
                    r.Status = true;
                    return r;
                }
                r.Erros = "Não encontra Registo...";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return r;
            }
        }

        public ResultList Valida(TABZON tab)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {

                var ctx = new DataGiicNetEntities();
                if ((tab.DESCRICAO ?? "") == "")
                {
                    r.Erros = "Descricao é Obrigatória...";
                    return r;
                }
                r.Status = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return r;
            }
        }
    }
}
