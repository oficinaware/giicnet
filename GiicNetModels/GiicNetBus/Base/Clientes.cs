using System.Collections;
using System.Data;
using System.Data.SqlClient;
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
    public class Clientes : BaseRepository
    {
        public Clientes(DbContext context)
            : base(context)
        {
        }


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
            var result = new OperationResult<List<CLIENTES>>();
            DataGiicNetEntities ctx = new DataGiicNetEntities();

            try
            {
                //v ar obj = (from c in ctx.CNDENT select c).Skip(pag * itemsByPag).Take(itemsByPag).ToList();
                List<CLIENTES> obj = (from c in ctx.CLIENTES select c).ToList();
                if (obj.Count > 0)
                {
                    result.AddResult(obj);

                    result.Type = ResultType.OK;

                    return result;
                }

                result.Type = ResultType.Warning;
                result.AddMessage(ResultType.Warning, "Não existem registos...");

                return result;
            }
            catch (Exception ex)
            {
                result.Type = ResultType.Error;
                result.AddMessage(ResultType.Error, ex.Message + " Details: " + ex.InnerException);

                return result;
            }
            finally
            {
                ctx.Dispose();
            }
        }

        public DataTable BrowseDT()
        {
            DataTable dTClientes = new DataTable();
            //string cn = "Data Source=server\\sql2008dev;Initial Catalog=DataGiicNet;Persist Security Info=True;User ID=sa;Password=sa;MultipleActiveResultSets=true";
            //SqlConnection sX = new SqlConnection(cn);

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            using (SqlCommand command = new SqlCommand("SELECT * FROM CLIENTES_BR", Connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                dTClientes.Load(dataReader);

                dataReader.Close();
                dataReader.Dispose();
            }




            //if(Connection.State == ConnectionState.Closed) 
            //    Connection.Open();
            //            SqlCommand sCmd = new SqlCommand("SELECT * FROM CLIENTES_BR", Connection);
            //SqlDataReader sDR = sCmd.ExecuteReader();
            //dTClientes.Load(sDR);

            //sDR.Close();
            //sDR.Dispose();

            //Connection.Close();
            //Connection.Dispose();

            return dTClientes;
        }

        public DataTable BrowseTable(List<EntittyParamFilter> filters)
        {
            DataTable dTClientes = new DataTable();

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }


            var query = "SELECT * FROM CLIENTES_BR cc";
            if (filters.Count > 0)
            {
                query = string.Format("{0} {1}", query, "where");

                for (var i = 0; i < filters.Count; i++)
                {
                    var item = filters[i];
                    if (item.Value == null) break;
                    var parameter = new SqlParameter();
                    ClientParamFilter param = (ClientParamFilter)item.Param;
                    #region switch
                    switch (param)
                    {
                        case ClientParamFilter.Cliente:
                            parameter.ParameterName = "@CLIENTE";
                            parameter.DbType = DbType.String;
                            parameter.Value = item.Value + "%";

                            query = i > 0 ?
                                string.Format(" and {0} {1} ", query, "cc.CLIENTE LIKE @CLIENTE") : string.Format(" {0} {1} ", query, "cc.CLIENTE LIKE @CLIENTE");

                            break;
                        case ClientParamFilter.Nome:
                            parameter.ParameterName = "@NOME";
                            parameter.DbType = DbType.String;
                            parameter.Value = "%" + item.Value + "%";

                            query = i > 0 ?
                              string.Format(" and {0} {1} ", query, "cc.NOME LIKE @NOME") : string.Format(" {0} {1} ", query, "cc.NOME LIKE @NOME");
                            break;
                        case ClientParamFilter.NomeAbv:
                            parameter.ParameterName = "@NOMEABR";
                            parameter.DbType = DbType.String;
                            parameter.Value = "%" + item.Value + "%";

                            query = i > 0 ?
                             string.Format(" and {0} {1} ", query, "cc.NOMEABR LIKE @NOMEABR") : string.Format(" {0} {1} ", query, "cc.NOMEABR LIKE @NOMEABR");
                            break;
                        case ClientParamFilter.Classe:
                            parameter.ParameterName = "@CLASSE";
                            parameter.DbType = DbType.String;
                            parameter.Value = item.Value;

                            query = i > 0 ?
                                string.Format(" and {0} {1} ", query, "cc.CLASSE = @CLASSE") : string.Format(" {0} {1} ", query, "cc.CLASSE = @CLASSE");
                            break;
                        case ClientParamFilter.Pais:
                            parameter.ParameterName = "@PAIS";
                            parameter.DbType = DbType.String;
                            parameter.Value = item.Value;

                            query = i > 0 ?
                                string.Format(" and {0} {1} ", query, "cc.PAIS = @PAIS") : string.Format(" {0} {1} ", query, "cc.PAIS = @PAIS");
                            break;
                        case ClientParamFilter.NRCont:
                            parameter.ParameterName = "@NRCONT";
                            parameter.DbType = DbType.String;
                            parameter.Value = item.Value;

                            query = i > 0 ?
                               string.Format(" and {0} {1} ", query, "cc.NRCONT = @NRCONT") : string.Format(" {0} {1} ", query, "cc.NRCONT = @NRCONT");
                            break;
                        case ClientParamFilter.CodCTB:
                            parameter.ParameterName = "@COD_CTB";
                            parameter.DbType = DbType.String;
                            parameter.Value = item.Value;
                            query = i > 0 ?
                        string.Format(" and {0} {1} ", query, "cc.COD_CTB = @COD_CTB") : string.Format(" {0} {1} ", query, "cc.COD_CTB = @COD_CTB");
                            break;
                        default:
                            break;
                    }
                    #endregion

                }


            }

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                dTClientes.Load(dataReader);

                dataReader.Close();
                dataReader.Dispose();
            }
            return dTClientes;
        }

        public DataTable BrowseDT(List<SqlParameter> paramfiltro)
        // Exemplo de Uso da função
        //
        //        List<SqlParameter> sp = new List<SqlParameter>()
        //{
        //    new SqlParameter() {ParameterName = "@CmpyCode", SqlDbType = SqlDbType.NVarChar, Value= CV.Global.CMPYCODE},
        //    new SqlParameter() {ParameterName = "@Code", SqlDbType = SqlDbType.NVarChar, Value = codeName},
        //    new SqlParameter() {ParameterName = "@DisplayCode", SqlDbType = SqlDbType.NVarChar, Value = codeName + "-"},
        //    new SqlParameter() {ParameterName = "@TotalDigit", SqlDbType = SqlDbType.Int, Value = CV.Global.PARAMTOTALDIGIT }
        {
            DataTable dTClientes = new DataTable();
            string cn = "Data Source=server\\sql2008dev;Initial Catalog=DataGiicNet;Persist Security Info=True;User ID=sa;Password=sa;MultipleActiveResultSets=true";
            SqlConnection sX = new SqlConnection(cn);
            if (sX.State == ConnectionState.Closed) sX.Open();

            //SqlCommand sCmd = new SqlCommand("SELECT * FROM CLIENTES_BR WHERE (NOME LIKE @NOME OR @NOME = '') AND (PAIS = @PAIS OR @PAIS = ''), sX);
            SqlCommand sCmd = new SqlCommand();

            sCmd.Connection = sX;
            sCmd.CommandText = "SELECT * FROM CLIENTES_BR WHERE (NOME LIKE @NOME OR @NOME = '') AND (PAIS = @PAIS OR @PAIS = '')";
            sCmd.Parameters.AddRange(paramfiltro.ToArray());

            SqlDataReader sDR = sCmd.ExecuteReader();
            dTClientes.Load(sDR);

            sDR.Close();
            sDR.Dispose();

            sX.Close();
            sX.Dispose();

            return dTClientes;
        }

        public OperationResult<List<CLIENTES_BR>> Browse()
        {
            var result = new OperationResult<List<CLIENTES_BR>>();
            //ResultList r = new ResultList();
            //r.Status = false;
            //r.Erros = "";
            //r.Lista = null;
            //Boolean ok = false;
            //string msg = "";
            try
            {
                DataGiicNetEntities ctx = new DataGiicNetEntities();
                var obj = (from c in ctx.CLIENTES_BR select c).ToList();
                if (obj.Count > 0)
                {

                    result.AddResult(obj);

                    result.Type = ResultType.OK;

                    return result;
                    //r.Status = true;
                    //r.Lista = obj;
                    //return r;
                }
                result.Type = ResultType.Warning;
                result.AddMessage(ResultType.Warning, "Não existem registos...");

                return result;

                //r.Status = true;
                //r.Erros = "Não Existem Registos...";
                //return r;
            }
            catch (Exception ex)
            {
                result.Type = ResultType.Error;
                result.AddMessage(ResultType.Error, ex.Message + " Details: " + ex.InnerException);

                return result;

                //r.Status = false;
                //r.Erros = ex.Message + " Details: " + ex.InnerException;
                //return r;
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

    public enum ClientParamFilter
    {
        Cliente = 0,
        Nome = 1,
        NomeAbv = 2,
        Classe = 3,
        Pais = 4,
        NRCont = 5,
        CodCTB = 6
    }

    public class EntittyParamFilter
    {
        public int Param { get; set; }
        public string Value { get; set; }
    }
}