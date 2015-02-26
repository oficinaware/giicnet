using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Data.Entity;
using System.Reflection;

namespace GiicNetBus.Base
{
    public class Estacoes
    {
        public estacoes GetByKey(String key)
        {
            Boolean ok = false;
            string msg = "";
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.estacoes where c.estacao == key select c).FirstOrDefault();
                //var lambda = ctx.TABFAM.FirstOrDefault(x => x.FAMILIA == key);

                if (obj != null)
                {
                    ok = true;
                    return obj;
                }
                return null;
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
                return null;
            }
        }

       

        public ResultList GetAll(Int32 pag, Int32 itemsByPag)
        {
            var r = new ResultList();
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                //var obj = (from c in ctx.estacoes select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.estacoes select c).ToList();
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
                r.Erros= ex.Message;
                return r;
            }
        }

        public ResultList Insert(estacoes source)
        {
            ResultList r = new ResultList();
            estacoes tab = source.ProcessEmpty();
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                estacoes obj = GetByKey(tab.estacao);
                if (obj == null)
                {
                    ResultList rval = Valida(tab);
                    if (rval.Status == false)
                    {
                        return rval;
                    }
                    
                    ctx.estacoes.Add(tab);
                   IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg =
                        ctx.GetValidationErrors();
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

        public ResultList Update(estacoes source)
        {
            estacoes tab = source.ProcessEmpty();
            ResultList r = new ResultList();
            
           try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
               
                estacoes obj = GetByKey(tab.estacao);
                if (obj != null)
                {
                    ResultList rval = Valida(tab);
                    if (rval.Status == false)
                    {
                        return rval;
                    }
                   IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    if (!msg.Any())
                    {
                        ctx.estacoes.Attach(tab);
                        ctx.Entry(obj).State = EntityState.Modified;
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
                    else
                    {
                        r.Erros = (from c in msg select c).FirstOrDefault().ToString();
                        return r;
                    }
                }
                r.Erros = "Não encontra o Registo...";
                return r;
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

            string msg = "";
            Boolean ok = false;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                estacoes obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.estacoes.Attach(obj);
                    ctx.estacoes.Remove(obj);
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
                else
                {
                    r.Status = false;
                    r.Erros = "Key value is null!";
                    return r;
                }
            }
            catch (Exception ex)
            {
                r.Status = false;
                r.Erros = ex.Message;
                return r;
            }
        }

        public ResultList Valida(estacoes estacao)
        {
            ResultList r = new ResultList();
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                if ((estacao.descricao ?? "") == "") 
                {
                    r.Erros = "Descricao é Obrigatória...";
                    return r;
                }
                r.Status = true;
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = "Erro " + ex.Message.ToString();
                return r;
            }
        }
    }
}