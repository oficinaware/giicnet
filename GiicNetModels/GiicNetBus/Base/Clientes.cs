using System.Diagnostics;
using GiicNetModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GiicNetBus.Base
{
    public class Clientes
    {
        public CLIENTES GetByKey(String key)
        {
            Boolean ok = false;
            //DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                using (var ctx = new DataGiicNetEntities())
                {
                    var obj = (from c in ctx.CLIENTES where c.CLIENTE == key select c).FirstOrDefault();

                    if (obj != null)
                    {
                        return obj;
                    }
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                //ctx.Dispose();
            }
        }

        ////public CLIENTES ProcessarVazios(CLIENTES cL)
        //{
        //    Type type = typeof(CLIENTES);
        //    PropertyInfo[] properties = type.GetProperties();
        //    foreach (PropertyInfo property in properties)
        //    {
        //        try
        //        {
        //            string tipoP = property.PropertyType.ToString();
        //            switch (tipoP)
        //            {
        //                case "System.String":
        //                    if (property.GetValue(cL).ToString() == "") property.SetValue(cL, null);
        //                    break;
        //                case "System.DateTime":
        //                    if (property.GetValue(cL).ToString().Contains("0001")) property.SetValue(cL, null);
        //                    break;
        //                case "System.Short":
        //                    break;
        //                case "System.Decimal":
        //                    if (Convert.ToDecimal(property.GetValue(cL)) == 0) property.SetValue(cL, null);
        //                    break;
        //                case "System.Int":
        //                    if ((int)(property.GetValue(cL)) == 0) property.SetValue(cL, null);
        //                    break;
        //                case "System.Bool":
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        catch (Exception) { }
        //    }
        //    return cL;
        //}

        public OperationResult<List<CLIENTES>> GetAll(Int32 pag, Int32 itemsByPag)
        {
            var resullt = new OperationResult<List<CLIENTES>>();
            DataGiicNetEntities ctx = new DataGiicNetEntities();

            try
            {
                //v ar obj = (from c in ctx.CNDENT select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                List<CLIENTES> obj = (from c in ctx.CLIENTES select c).ToList();
                if (obj.Count > 0)
                {
                    resullt.AddResult(obj);

                    resullt.Type= ResultType.OK;

                    return resullt;
                }

                resullt.Type = ResultType.Warning;
                resullt.AddMessage(ResultType.Warning, "Não existem registos...");
              
                return resullt;
            }
            catch (Exception ex)
            {
                resullt.Type = ResultType.Error;
                resullt.AddMessage(ResultType.Error, ex.Message + " Details: " + ex.InnerException);
             
                return resullt;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public OperationResult<CLIENTES_BR> Browse()
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            //Boolean ok = false;
            //string msg = "";
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.CLIENTES_BR select c).ToList();
                if (obj.Count > 0)
                {


                    r.Status = true;
                    r.Lista = obj;
                    return r;
                }
                //return null;
                r.Status = true;
                r.Erros = "Não Existem Registos...";
                return r;
            }
            catch (Exception ex)
            {
                //msg = ex.Message;
                //return null;
                r.Status = false;
                r.Erros = ex.Message + " Details: " + ex.InnerException;
                return r;
            }
        }

        public ResultList Insert(CLIENTES source)
        {
            //cliente = ProcessarVazios(cliente);
            CLIENTES cliente = source.ProcessEmpty();
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            var ctx = new DataGiicNetEntities();
            try
            {
                CLIENTES obj = GetByKey(cliente.CLIENTE);
                if (obj == null) ctx.CLIENTES.Add(obj);
                IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                if (!msg.Any())
                {
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
            catch (Exception ex)
            {
                r.Erros = ex.Message + "Details: " + ex.InnerException;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public ResultList Update(CLIENTES source)
        {
            //cliente = ProcessarVazios(cliente);
            CLIENTES cliente = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                ctx.CLIENTES.Attach(cliente);
                ctx.Entry(cliente).State = EntityState.Modified;
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
                r.Erros = ex.Message.ToString() + " Details: " + ex.InnerException;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public ResultList Delete(String key)
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                Boolean ok = false;
                CLIENTES obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.CLIENTES.Attach(obj);
                    ctx.CLIENTES.Remove(obj);
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
                r.Erros = ex.Message + " Details: " + ex.InnerException;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public ResultList Valida(CLIENTES cliente)
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                if ((cliente.NOME ?? "") == "")
                {
                    r.Erros = "Nome é Obrigatório...";
                    return r;
                }

                r.Status = true;
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

        public CLIENTES_BR GetClientesBr(String key)
        {
            Boolean ok = false;
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                var obj = (from c in ctx.CLIENTES_BR where c.CLIENTE == key select c).FirstOrDefault();

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
            finally
            {
                ctx.Dispose();
            }
        }
    }
}
