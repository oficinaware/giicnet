using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiicNetModels;
using System.Reflection;

namespace GiicNetBus.Base
{
    class Clientes_Crm : BaseRepository
    {
        public Clientes_Crm(DbContext context)
            : base(context)
        {
        }
         public CLIENTES_CRM GetByKey(Guid key)
        {
            Boolean ok = false;
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.CLIENTES_CRM where c.NR_REG == key select c).FirstOrDefault();
                
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

        public CLIENTES_CRM GetByCliente(String key)
        {
            Boolean ok = false;
            try
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.CLIENTES_CRM orderby c.DATA_REG descending where c.CLIENTE == key select c).FirstOrDefault() ;
               
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

        public DataTable GetByClienteDT(string key)
        {
            DataTable dt = new DataTable();
            //String queryString = "SELECT * FROM CLIENTES_CRM WHERE CLIENTE = @CLIENTE ORDER BY DATA_REG DESC";

            // adapter = new SqlDataAdapter(queryString, Connection);

            //DataSet customers = new DataSet();
            //adapter.Fill(customers, "Customers");

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM CLIENTES_CRM WHERE CLIENTE = @CLIENTE ORDER BY DATA_REG DESC", Connection);
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@CLIENTE";
            parameter.SqlDbType = SqlDbType.NVarChar;
            //parameter.Direction = ParameterDirection.Input;
            parameter.Value = key;
            command.Parameters.Add(parameter);
            SqlDataReader dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            dataReader.Dispose();
            command.Dispose();
            return dt;
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
                //v ar obj = (from c in ctx.CLIENTES_CRM select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                var obj = (from c in ctx.CLIENTES_CRM select c).ToList();
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

        public ResultList Insert(CLIENTES_CRM source)
        {
            CLIENTES_CRM tab = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try 
            {
                
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                CLIENTES_CRM obj = GetByKey(tab.NR_REG);
                if (obj == null)
                {
                    ResultList rval = Valida(tab);
                    if (rval.Status == false)
                    {
                        return rval;
                    }
                    ctx.CLIENTES_CRM.Add(tab);
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

        public ResultList Update(CLIENTES_CRM source)
        {
            CLIENTES_CRM tab = source.ProcessEmpty();
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            DataGiicNetEntities ctx = new DataGiicNetEntities();
            try
            {
                CLIENTES_CRM obj = GetByKey(tab.NR_REG);
                if (obj == null)
                {
                    r.Erros = "Registo não Existe...";
                    return r;
                }
                
                ResultList rval = Valida(tab);
                if (rval.Status == false)
                {
                    return rval;
                }
                ctx.CLIENTES_CRM.Attach(tab);
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
                r.Erros = ex.Message.ToString();
                return r;
            }
        }

        public ResultList Delete(Guid key)
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                Boolean ok = false;
                CLIENTES_CRM obj = GetByKey(key);
                if (obj != null)
                {
                    ctx.CLIENTES_CRM.Attach(obj);
                    ctx.CLIENTES_CRM.Remove(obj);
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

        public ResultList Valida(CLIENTES_CRM tab) 
        {
            ResultList r = new ResultList();
            r.Status = false;
            r.Erros = "";
            r.Lista = null;
            try
            {
               
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                if ((tab.CLIENTE ?? "") == "")
                {
                    r.Erros = "Cliente é Obrigatório...";
                    return r;
                }

                if ((tab.RUBRICA ?? "") == "")
                {
                    r.Erros = "Rubrica é Obrigatória...";
                    return r;
                }
                if ((tab.TEXTO ?? "") == "")
                {
                    r.Erros = "Texto é Obrigatóri0...";
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

