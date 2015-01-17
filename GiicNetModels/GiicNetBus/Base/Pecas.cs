using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Reflection;

namespace GiicNetBus.Base
{
    public class Pecas
    {
        
        public PECAS GetByKey(String key)
        {
            Boolean ok = false;
            string msg = "";
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.PECAS where c.PECA == key select c).FirstOrDefault();
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

        public PECAS ProcessarVazios(PECAS obj)
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

        public List<PECAS> GetAll(Int32 pag, Int32 itemsByPag)
        {
            Boolean ok = false;
            string msg = "";
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                //var obj = (from c in ctx.PECAS select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.PECAS select c).ToList();
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
        
        public Boolean Insert(PECAS pecas)
        {
            pecas = ProcessarVazios(pecas);
            Boolean ok = false;
            string msg = "";
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                PECAS obj = GetByKey(pecas.PECA);
                if (obj == null)
                    ctx.PECAS.Add(pecas);
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

        public Boolean Update(PECAS pecas)
        {
            pecas = ProcessarVazios(pecas);
            Boolean ok = false;
            string msg = "";
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
               
                PECAS obj = GetByKey(pecas.PECA);
                if (obj != null)
                {
                    obj.DESCPECA = pecas.DESCPECA;
                    obj.DESC_INGLES = pecas.DESC_INGLES;
                    obj.DESC_FRANCES = pecas.DESC_FRANCES;
                    obj.DESC_ESPANHOL = pecas.DESC_ESPANHOL;
                    obj.OPERACAO = pecas.OPERACAO;
                    obj.GRUPO = pecas.GRUPO;
                    obj.LIN = pecas.LIN;
                    obj.COL = pecas.COL;
                    obj.POSICAO = pecas.POSICAO;
                    obj.TEMPLATES = pecas.TEMPLATES;
                    //update fields

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

        public Boolean Delete(String key)
        {
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                Boolean ok = false;
                PECAS obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.SaveChanges();
                    ok = true;
                    return ok;
                }
                return ok;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string Valida(PECAS pecas)
        {
            try
            {
                string msg = "";
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                if ((pecas.DESCPECA ?? "") == "")
                {
                    msg = "Descricao é Obrigatória...";
                    return msg;
                }
                if ((pecas.OPERACAO ?? "") == "")
                {
                    msg = "Operação é Obrigatória...";
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
