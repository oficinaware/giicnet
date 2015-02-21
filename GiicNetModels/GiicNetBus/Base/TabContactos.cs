using System;
using System.Collections.Generic;
using System.Linq;
using GiicNetModels;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Entity;

namespace GiicNetBus.Base
{
    class TabContactos
    {
        public TABCONTACTOS GetByKey(Guid key)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABCONTACTOS obj = (from c in ctx.TABCONTACTOS where c.NR_REG == key select c).FirstOrDefault();
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

        //public TABCONTACTOS ProcessarVazios(TABCONTACTOS obj)
        //{
        //    Type type = typeof(TABCONTACTOS);
        //    PropertyInfo[] properties = type.GetProperties();
        //    foreach (PropertyInfo property in properties)
        //    {
        //        try
        //        {
        //            string tipoP = property.PropertyType.ToString();
        //            switch (tipoP)
        //            {
        //                case "System.String":
        //                    if (property.GetValue(obj).ToString() == "") property.SetValue(obj, null);
        //                    break;
        //                case "System.DateTime":
        //                    if (property.GetValue(obj).ToString().Contains("0001")) property.SetValue(obj, null);
        //                    break;
        //                case "System.Short":
        //                    break;
        //                case "System.Decimal":
        //                    if (Convert.ToDecimal(property.GetValue(obj)) == 0) property.SetValue(obj, null);
        //                    break;
        //                case "System.Int":
        //                    if ((int)(property.GetValue(obj)) == 0) property.SetValue(obj, null);
        //                    break;
        //                case "System.Bool":
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        catch (Exception) { }
        //    }
        //    return obj;
        //}

        public ResultList GetAll(Int32 pag, Int32 itemsByPag)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABCONTACTOS select c).ToList();
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

        public ResultList Insert(TABCONTACTOS source)
        {
            //tab = ProcessarVazios(tab);
             TABCONTACTOS tab = source.ProcessEmpty();
            var r = new ResultList();
            //r.Status = false;
            //r.Erros = "";
            //r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                //var ctx = new DataGiicNetEntities();
                TABCONTACTOS obj = GetByKey(tab.NR_REG);
                if (obj == null)
                {
                    ctx.TABCONTACTOS.Add(tab);
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

        public ResultList Update(TABCONTACTOS source)
        {
            TABCONTACTOS tab = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                ctx.TABCONTACTOS.Attach(tab);
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

        public ResultList Delete(Guid key)
        {
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                Boolean ok = false;
                TABCONTACTOS obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.TABCONTACTOS.Attach(obj);
                    ctx.TABCONTACTOS.Remove(obj);
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

        public ResultList Valida(TABCONTACTOS tab)
        {
            var r = new ResultList();
            //r.Status = false;
            //r.Erros = "";
            //r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                if (((tab.TERCEIRO ?? "") == "") || ((tab.CLIENTE ?? "") == ""))
                {
                    r.Erros = "Código da Entidade é Obrigatório...";
                    return r;
                }
               
                if ((tab.NOME ?? "") == "")
                {
                    r.Erros = "Nome é Obrigatório...";
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
   
