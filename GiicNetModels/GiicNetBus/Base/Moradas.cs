using System;
using System.Collections.Generic;
using System.Linq;
using GiicNetModels;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OFSInterOp;

namespace GiicNetBus.Base
{
    class Moradas
    {
         public MORADAS GetByKey(string cliente, int itemCli)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                MORADAS obj = (from c in ctx.MORADAS where c.CLIENTE == cliente & c.ITEMCLI == itemCli select c).FirstOrDefault();
                if (obj != null)
                {
                   return obj;
                }
                r.Erros = "Não encontra registo...";
                return null;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return null;
            }
        }


         public ResultList GetByCliente(string cliente)
         {
             var r = new ResultList();
             //r.Status = false;
             //r.Erros = "";
             //r.Lista = null;
             try
             {
                 var ctx = new DataGiicNetEntities();
                 var obj = (from c in ctx.MORADAS where c.CLIENTE == cliente  select c).ToList();
                 if (obj.Count > 0)
                 {
                     r.Status = true;
                     r.Lista = obj;
                     return r;
                 }
                 r.Erros = "Não encontra registo...";
                 return r;
             }
             catch (Exception ex)
             {
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
                var obj = (from c in ctx.MORADAS select c).ToList();
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

        public ResultList Insert(MORADAS source)
        {
            
             MORADAS tab = source.ProcessEmpty();
            var r = new ResultList();
           
            //r.Status = false;
            //r.Erros = "";
            //r.Lista = null;
            var ctx = new DataGiicNetEntities();
            var iofs  = new OFSInterOp.ServicosGcom();
            using (var ctxTransaction = ctx.Database.BeginTransaction())
            
            try
            {
                
                MORADAS obj = GetByKey(tab.CLIENTE,tab.ITEMCLI);
                if (obj == null)
                {
                    int mitemcli = (int)iofs.NOVONR_MORADA();
                    if (mitemcli == 0)
                    {
                        r.Status = false;
                        r.Erros = "Erro ao gerar ItemCli em Moradas...";
                        ctxTransaction.Rollback();
                        return r;
                    }
                    tab.ITEMCLI = mitemcli;
                    ctx.MORADAS.Add(tab);
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    if (!msg.Any())
                    {
                        ctx.SaveChanges();
                        ctxTransaction.Commit();
                        r.Status = true;
                        return r;
                    }
                    {
                        ctxTransaction.Rollback();
                        r.Erros = (from c in msg select c).FirstOrDefault().ToString();
                        return r;
                    }
                  
                }
                ctxTransaction.Rollback();
                r.Erros = "Registo já Existe...";
                return r;
            }
            catch (Exception ex)
            {
                ctxTransaction.Rollback();
                r.Erros = ex.Message;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public ResultList Update(MORADAS source)
        {
            MORADAS tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                ctx.MORADAS.Attach(tab);
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

        public ResultList Delete(string cliente, int itemcli)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                Boolean ok = false;
                MORADAS obj = GetByKey(cliente,itemcli);
                if (obj != null)
                {
                    ctx.MORADAS.Attach(obj);
                    ctx.MORADAS.Remove(obj);
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

        public ResultList Valida(MORADAS tab)
        {
            var r = new ResultList();
            //r.Status = false;
            //r.Erros = "";
            //r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                if ((tab.NOME_MORADA ?? "") == "")
                {
                    r.Erros = "Nome da Morada é Obrigatório...";
                    return r;
                }
               
                if ((tab.MORADA1 ?? "") == "")
                {
                    r.Erros = "Morada é Obrigatório";
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
   
