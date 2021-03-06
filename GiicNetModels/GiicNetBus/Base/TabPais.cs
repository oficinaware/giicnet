﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Reflection;
using System.Data.Entity;

namespace GiicNetBus.Base
{
    public class TabPais
    {
        public TABPAIS GetByKey(String key)
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABPAIS obj = (from c in ctx.TABPAIS where c.CODPAIS == key select c).FirstOrDefault();
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

        //public TABPAIS ProcessarVazios(TABPAIS obj)
        //{
        //    Type type = typeof(TABPAIS);
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
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.TABPAIS select c).ToList();
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

        public ResultList Insert(TABPAIS source)
        {
            TABPAIS tab = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {

                DataGiicNetEntities ctx = new DataGiicNetEntities();
                TABPAIS obj = GetByKey(tab.CODPAIS);
                if (obj == null) ctx.TABPAIS.Add(tab);
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

        public ResultList Update(TABPAIS source)
        {
            TABPAIS tab = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;

           DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                ctx.TABPAIS.Attach(tab);
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
                TABPAIS obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.TABPAIS.Remove(obj);
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

        public ResultList Valida(TABPAIS tab)
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
