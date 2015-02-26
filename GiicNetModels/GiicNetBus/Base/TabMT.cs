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
    public class TabMT
    {
        public TABMT GetByKey(String key)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABMT obj = (from c in ctx.TABMT where c.CODMT == key select c).FirstOrDefault();
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
                var obj = (from c in ctx.TABMT select c).ToList();
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

        public ResultList Insert(TABMT source)
        {
            TABMT tab = source.ProcessEmpty(); 
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                //var ctx = new DataGiicNetEntities();
                TABMT obj = GetByKey(tab.CODMT);
                if (obj == null)
                {
                    ResultList rval = Valida(tab);
                    if (rval.Status == false)
                    {
                        return rval;
                    }

                    ctx.TABMT.Add(tab);
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
                r.Erros = "Registo já Existe...";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public ResultList Update(TABMT source)
        {
            TABMT tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {

                ResultList rval = Valida(tab);
                if (rval.Status == false)
                {
                    return rval;
                }
                
                
                ctx.TABMT.Attach(tab);
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
            var ctx = new DataGiicNetEntities();
            try
            {
                Boolean ok = false;
                TABMT obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.TABMT.Attach(obj);
                    ctx.TABMT.Remove(obj);
                    if (ctx.SaveChanges() > 0)
                    {
                        r.Status = true;
                        return r;
                    }
                    r.Status = false;
                    r.Erros = "No records were deleted in update process!";
                    return r;
                }
                r.Status = false;
                r.Erros = "Registo não existe...";
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

        public ResultList Valida(TABMT tab)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                if ((tab.CODMT ?? "") == "")
                {
                    r.Erros = "Código é Obrigatório...";
                    return r;
                }
               
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
