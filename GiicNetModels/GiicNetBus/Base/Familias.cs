using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Data.Entity;
using System.Reflection;

namespace GiicNetBus.Base
{

    public class Familias

    {

        public TABFAM GetByKey(String key)
        {
            try
            {
                Boolean ok = false;
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                //ctx.Configuration.LazyLoadingEnabled = false;
                var obj = (from c in ctx.TABFAM where c.FAMILIA == key select c).FirstOrDefault();
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

        public TABFAM ProcessarVazios(TABFAM obj)
        {
            Type type = typeof(PECAS);
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

        public List<TABFAM> GetAll(Int32 pag, Int32 itemsByPag)
        {
            try
            {
                Boolean ok = false;
                string msg = "";
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                //var obj = (from c in ctx.TABFAM select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.TABFAM select c).ToList();
               if (obj != null)
                {
                    return obj;
                }
                return null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
        }

        public Boolean Insert(TABFAM fam)
        {
            fam = ProcessarVazios(fam);
            Boolean ok = false;
            try
                {
            
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            TABFAM obj = GetByKey(fam.FAMILIA);
            if (obj == null)
            ctx.TABFAM.Add(fam);
            ctx.SaveChanges();
            IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> erros = ctx.GetValidationErrors();
                if (erros.Count() > 0)
                {
                    return false;
                }
             return true;
                }
            catch(Exception)
            {
                return false;
            }
        }

        public Boolean Update(TABFAM tabfam)
        {
            tabfam = ProcessarVazios(tabfam);
            Boolean ok = false;
            string msg = "";
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                
                TABFAM obj = GetByKey(tabfam.FAMILIA);
                if (obj != null)
                {
                    //obj.DESCRICAO = tabfam.DESCRICAO;
                    
                    //update fields
                    ctx.TABFAM.Remove(obj);
                    ctx.TABFAM.Add(tabfam);

                    ctx.SaveChanges();
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> erros = ctx.GetValidationErrors();
                    if (erros.Count() > 0)
                    {
                        msg = (from c in erros select c).FirstOrDefault().ToString();
                        return false;
                    }
                    return true;
                    ok = true;
                    return ok;
                }
                return ok;
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
                return false;
            }
        }

        public Boolean Delete( String key)
        {
            string msg = "";
            Boolean ok = false;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABFAM obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.TABFAM.Remove(obj);
                    ctx.SaveChanges();
                    ok = true;
                    return ok;
                }
                return ok;
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
                return false;
            }
        }

        public string Valida(TABFAM tabfam)
        {
            try
            {
            string msg = "";
             DataGiicNetEntities ctx = new DataGiicNetEntities();
                if ((tabfam.DESCRICAO ?? "") == "") 
                {
                    msg = "Descricao é Obrigatória...";
                    return msg;
                }
                
                return msg;
            }
            catch (Exception)
            {
                return "Erro";
            }
        }
    }
}
