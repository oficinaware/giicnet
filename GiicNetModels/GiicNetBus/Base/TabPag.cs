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
    public class TabPag
    {
        public TABPAG GetByKey(String key)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABPAG obj = (from c in ctx.TABPAG where c.CNDPAG == key select c).FirstOrDefault();
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

        
        public ResultList GetAll(Int32 pag, Int32 itemsByPag)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABPAG select c).ToList();
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

        public ResultList Insert(TABPAG source)
        {
            TABPAG tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABPAG obj = GetByKey(tab.CNDPAG);
                if (obj == null)
                {
                    ResultList rval = Valida(tab);
                    if (rval.Status == false)
                    {
                        return rval;
                    }
                    ctx.TABPAG.Add(tab);
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    if (!msg.Any())
                    {
                        ctx.SaveChanges();
                        r.Status = true;
                        return r;
                    }
                    {
                        r.Erros = (from c in msg select c).FirstOrDefault().ToString();
                        r.Status = false;
                        return r;
                    }
                }
                r.Erros = "O Registo já existe...";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                r.Status = false;
                return r;
            }
        }

        public ResultList Update(TABPAG source)
        {
            TABPAG tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                 TABPAG obj = GetByKey(tab.CNDPAG);
                if (obj != null)
                {
                    ResultList rval = Valida(tab);
                    if (rval.Status == false)
                    {
                        return rval;
                    }
                    ctx.TABPAG.Attach(tab);
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
                r.Erros = "Não existe Registo...";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message + " Details: " + ex.InnerException;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
           
        }

        public ResultList Delete(String key)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.TABPAG.Remove(obj);
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

        public ResultList Valida(TABPAG tab)
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
