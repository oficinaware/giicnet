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
    public partial class TabClasse
    {
        public  TABCLASSE GetByKey(String key)
        {
           ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABCLASSE obj = (from c in ctx.TABCLASSE where c.CLASSE== key select c).FirstOrDefault();
                //var lambda = ctx.TABFAM.FirstOrDefault(x => x.FAMILIA == key);

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

        public TABCLASSE ProcessarVazios(TABCLASSE obj)
        {
            Type type = typeof(TABCLASSE);
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
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                //v ar obj = (from c in ctx.CNDENT select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.TABCLASSE select c).ToList();
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

        public ResultList Insert(TABCLASSE tab)
        {
            tab = ProcessarVazios(tab);
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try 
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABCLASSE obj = GetByKey(tab.CLASSE);
                if (obj == null)
                ctx.TABCLASSE.Add(tab);
                IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                if (!msg.Any() )
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

        public ResultList Update(TABCLASSE tab)
        {
            tab = ProcessarVazios(tab);
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
           try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
               
                TABCLASSE obj = GetByKey(tab.CLASSE);
                if (obj != null)
                {
                    obj = tab;
                
                    IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> msg = ctx.GetValidationErrors();
                    //update fields
                    if (!msg.Any())
                    {
                        ctx.TABCLASSE.Attach(obj);
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
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABCLASSE obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.TABCLASSE.Attach(obj);
                    ctx.TABCLASSE.Remove(obj);
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
                r.Erros = "Não encontra Registo...";
                return r;
            }
            catch (Exception ex)
            {
                r.Erros = ex.Message;
                return r;
            }
        }

        public ResultList Valida(TABCLASSE tab) 
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
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