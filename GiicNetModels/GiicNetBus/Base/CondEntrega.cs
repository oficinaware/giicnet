﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Reflection;

namespace GiicNetBus.Base
{
    public class CondEntrega
    {
        

        public CNDENT GetByKey(String key)
        {
            Boolean ok = false;
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.CNDENT where c.CODIGO == key select c).FirstOrDefault();
               
                if (obj != null)
                {
                    return obj;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
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
                //v ar obj = (from c in ctx.CNDENT select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.CNDENT select c).ToList();
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

        public ResultList Insert(CNDENT source)
        {
            CNDENT cndent = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try 
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                CNDENT obj = GetByKey(cndent.CODIGO);
                if (obj == null)
                {
                    ResultList rval = Valida(cndent);
                    if (rval.Status == false)
                    {
                        return rval;
                    }
                    ctx.CNDENT.Add(cndent);
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    if (! msg.Any())
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

        public ResultList Update(CNDENT source)
        {
            CNDENT cndent = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                CNDENT obj = GetByKey(cndent.CODIGO);
                if (obj == null)
                {
                    r.Erros = "Registo não Existe...";
                    return r;
                    }
                
                ResultList rval = Valida(cndent);
                if (rval.Status == false)
                {
                    return rval;
                }
                ctx.CNDENT.Attach(cndent);
                ctx.Entry(cndent).State = EntityState.Modified;
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
                r.Erros = ex.Message.ToString();
                return r;
            }
        }

        public ResultList Delete(String key)
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                Boolean ok = false;
                CNDENT obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.CNDENT.Attach(obj);
                    ctx.CNDENT.Remove(obj);
                    if (ctx.SaveChanges() > 0)
                    {
                        r.Status = true;
                        return r;
                    }
                    r.Status = false;
                    r.Erros = "No records were changed in update process!";
                    return r;
                }
                r.Status = false;
                r.Erros = "Key value is null!";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return r;
            }
        }

        public ResultList Valida(CNDENT cndent) 
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
               
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                if ((cndent.DESCRICAO ?? "") == "")
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
