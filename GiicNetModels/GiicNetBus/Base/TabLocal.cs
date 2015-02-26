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
    public class TabLocal
    {
        public TABLOCAL GetByKey(string codpais, String codzon, string codlocal)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABLOCAL obj = (from c in ctx.TABLOCAL where c.CODZON == codzon && c.CODPAIS == codpais && c.CODLOCAL == codlocal select c).FirstOrDefault();
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

        
        public ResultList GetByPaisZona(string codpais, string codzon)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABLOCAL where c.CODPAIS == codpais && c.CODZON == codzon select c).ToList();
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
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABLOCAL select c).ToList();
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

        public ResultList Insert(TABLOCAL source)
        {
            TABLOCAL tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {

                var ctx = new DataGiicNetEntities();
                TABLOCAL obj = GetByKey(tab.CODPAIS, tab.CODZON, tab.CODLOCAL);
                if (obj == null)
                {
                    ctx.TABLOCAL.Add(tab);
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
        }

        public ResultList Update(TABLOCAL source)
        {
            TABLOCAL tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();

                var obj = GetByKey(tab.CODPAIS,tab.CODZON, tab.CODLOCAL);
                if (obj != null)
                {
                    ctx.TABLOCAL.Attach(tab);
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

        public ResultList Delete(String codpais,String codzon, String codlocal)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = GetByKey(codpais, codzon, codlocal);
                if (obj != null)
                {
                    ctx.TABLOCAL.Attach(obj);
                    ctx.TABLOCAL.Remove(obj);
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

        public ResultList Valida(TABLOCAL tab)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {

                var ctx = new DataGiicNetEntities();
                if ((tab.CODLOCAL ?? "") == "")
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
