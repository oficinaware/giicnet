using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                //var lambda = ctx.TABFAM.FirstOrDefault(x => x.FAMILIA == key);

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

        //public CNDENT ProcessarVazios(CNDENT cE)
        //{
        //    Type type = typeof(CNDENT);
        //    PropertyInfo[] properties = type.GetProperties();
        //    foreach (PropertyInfo property in properties)
        //    {
        //        try
        //        {
        //            string tipoP = property.PropertyType.ToString();
        //            switch (tipoP)
        //            {
        //                case "System.String":
        //                    if (property.GetValue(cE).ToString() == "") property.SetValue(cE, null);
        //                    break;
        //                case "System.DateTime":
        //                    if (property.GetValue(cE).ToString().Contains("0001")) property.SetValue(cE, null);
        //                    break;
        //                case "System.Short":
        //                    break;
        //                case "System.Decimal":
        //                    if (Convert.ToDecimal(property.GetValue(cE)) == 0) property.SetValue(cE, null);
        //                    break;
        //                case "System.Int":
        //                    if ((int)(property.GetValue(cE)) == 0) property.SetValue(cE, null);
        //                    break;
        //                case "System.Bool":
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        catch (Exception) { }
        //    }
        //    return cE;
        //}

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
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
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
