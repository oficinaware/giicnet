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

        public estacoes ProcessarVazios(estacoes obj)
        {
            Type type = typeof(estacoes);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                try
                {
                    string tipoP = property.PropertyType.ToString();
                    switch (tipoP)
                    {
                        case "System.String":
                            if (property.GetValue(obj).ToString() == "") property.SetValue(obj, null);
                            break;
                        case "System.DateTime":
                            if (property.GetValue(obj).ToString().Contains("0001")) property.SetValue(obj, null);
                            break;
                        case "System.Short":
                            break;
                        case "System.Decimal":
                            if (Convert.ToDecimal(property.GetValue(obj)) == 0) property.SetValue(obj, null);
                            break;
                        case "System.Int":
                            if ((int)(property.GetValue(obj)) == 0) property.SetValue(obj, null);
                            break;
                        case "System.Bool":
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception) { }
            }
            return obj;
        }

        public List<estacoes> GetAll(Int32 pag, Int32 itemsByPag)
        {
            Boolean ok = false;
            string msg = "";
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                //var obj = (from c in ctx.estacoes select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.estacoes select c).ToList();
                if (obj != null)
                {
                    return obj;
                }
                return null;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }
        }

        public Boolean Insert(estacoes estacao)
        {
            estacao = ProcessarVazios(estacao);
            Boolean ok = false;
            string msg = "";
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                estacoes obj = GetByKey(estacao.estacao);
                if (obj == null)
                ctx.estacoes.Add(estacao);
                ctx.SaveChanges();
                IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> erros = ctx.GetValidationErrors();
                if (erros.Count() > 0)
                {
                    msg = (from c in erros select c).FirstOrDefault().ToString();
                               return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
                return false;
            }
        }

        public ResultList Update(estacoes estacao)
        {
            estacao = ProcessarVazios(estacao);
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
           try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
               
                estacoes obj = GetByKey(estacao.estacao);
                if (obj != null)
                {
                    obj = estacao;
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    if (!msg.Any())
                    {
                        ctx.estacoes.Attach(ProcessarVazios(obj));
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

        public string Valida(estacoes estacao)
        {
            string msg = "";
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                if ((estacao.descricao ?? "") == "")
                {
                    msg = "Descricao é Obrigatória...";
                    return msg;
                }
                
                return msg;
            }
            catch (Exception ex)
            {
                return "Erro " + ex.Message.ToString();
            }
        }
    }
}