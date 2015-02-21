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

        public TABPAG ProcessarVazios(TABPAG obj)
        {
            Type type = typeof(TABPAG);
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

        public ResultList Insert(TABPAG tab)
        {
            tab = ProcessarVazios(tab);
            var r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                var ctx = new DataGiicNetEntities();
                TABPAG obj = GetByKey(tab.CNDPAG);
                if (obj == null) ctx.TABPAG.Add(tab);
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
            catch (Exception ex)
            {
                r.Erros = ex.Message;
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
            catch (Exception ex)
            {
                r.Erros = ex.Message.ToString() + " Details: " + ex.InnerException;
                return r;
            }
            finally
            {
                ctx.Dispose();
            }
            //tab = ProcessarVazios(tab);
            //var r = new ResultList();
            //r.Status = false;
            //r.Erros = "";
            //r.Lista = null;
            //try
            //{
            //    var ctx = new DataGiicNetEntities();

            //    var obj = GetByKey(tab.CNDPAG);
            //    if (obj != null)
            //    {
            //        obj = tab;
            //        IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
            //        //update fields
            //        if (!msg.Any())
            //        {
            //            ctx.SaveChanges();
            //            r.Status = true;
            //            return r;
            //        }
            //        {
            //            r.Erros = (from c in msg select c).FirstOrDefault().ToString();
            //            return r;
            //        }

            //    }
            //    r.Erros = "Não encontra o Registo...";
            //    return r;
            //}
            //catch (Exception ex)
            //{
            //    r.Erros = ex.Message.ToString();
            //    return r;
            //}
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