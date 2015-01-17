using System;
using System.Collections.Generic;
using GiicNetBus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiicNetBus.Base;
using GiicNetModels;

namespace Testing
{  
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var xxZ = new GiicNetBus.Base.Clientes();
            var resultZ = xxZ.Browse();
            List<CLIENTES_BR> rZ = new List<CLIENTES_BR>();
            rZ = resultZ;


            GiicNetModels.CLIENTES cL = new CLIENTES();
            cL.NOME = "";
            cL.DESCRCB = 0;
            cL.DTINI = Convert.ToDateTime("01-01-0001");

            CLIENTES cLZ = cL.ProcessEmpty();

            Clientes cLO = new Clientes();
            //cLO.ProcessarVazios(cL);

            GiicNetModels.CNDENT exemplo = new CNDENT();
            exemplo.CODIGO = "42";
            exemplo.DESCRICAO = "TESTE1";

            var condEnt = new GiicNetBus.Base.CondEntrega();
            var resCondEnt = condEnt.Delete(exemplo.CODIGO);

            var xx = new GiicNetBus.Base.Estacoes();
            var result = xx.GetAll(1, 10);
            ResultList r = new ResultList();
            r.Status = false;
            r.Lista = result;
            
            r.Erros = "";
            Assert.IsNotNull(result);
        }
         [TestMethod]
        public void TestMethod2()
        {
            Estacoes xx = new Estacoes();
            estacoes est = new estacoes();
            est.estacao = "V23";
            est.descricao = "teste 2";
            est.data1 = null;
            
            string Result = xx.Valida(est);
            Boolean ok = (Result == "");
            Assert.IsTrue(ok);
        }
    }
}
