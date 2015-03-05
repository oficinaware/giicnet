using System;
using ADODB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFSInterOp;

namespace Test_Interop
{
    [TestClass]
    public class Test_ServicosGcom
    {
        private string _connectionString;
        private ADODB.Connection _conn;


        //private ADODB.Connection _conn;
        public ADODB.Connection _connection
        {
            get
            {
                if (_conn == null || _conn.State == 0)
                {
                    _conn = new Connection();
                    _conn.ConnectionString = _connectionString;
                    _conn.Open();
                }
                return _conn;
            }
        }

        public Test_ServicosGcom()
        {
            _connectionString =  "Provider=SQLOLEDB;Data Source=Server\\SQL2008DEV;Initial Catalog=DataGiicNet; User Id=sa;Password=sa";

        }

        [TestMethod]
        public void Test_NOVONR_MORADA()
        {
            var _entity = new ServicosGcom(_connection);

            Result_Op<long> result = _entity.NOVONR_MORADA();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result,typeof(Result_Op<long>));

        }
    }
}
