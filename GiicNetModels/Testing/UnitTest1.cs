using System;
using GiicNetBus.Base;
using GiicNetModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Hasresult()
        {
            var ctx = new DataGiicNetEntities();
            var xx = new GiicNetBus.Base.Clientes(ctx);
            var result = xx.GetClientesBr("90276");

            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void Test_Clone()
        {
            var ctx = new DataGiicNetEntities();
            var repo = new GiicNetBus.Base.TabAge();

            TABAGE client = repo.GetByKey("94");
          
            object clone = client.Clone();

            var _cast = clone as TABAGE;
     

            //Assert.IsInstanceOfType(clone, typeof(TabAge));
            Assert.AreEqual(client.EMAIL, _cast.EMAIL);
            Assert.AreEqual(client.NOME, _cast.NOME);

        }

        [TestMethod]
        public void Test_TABAGE_Update()
        {
            var ctx = new DataGiicNetEntities();
            var repo = new GiicNetBus.Base.TabAge();

            TABAGE client = repo.GetByKey("94");

            object clone = client.Clone();

            var _cast = clone as TABAGE;
            _cast.COMISSAO = (decimal?)12.5;

            var ok = repo.Update(_cast);


            //Assert.IsInstanceOfType(clone, typeof(TabAge));
            Assert.AreEqual(client.EMAIL, _cast.EMAIL);
            Assert.AreEqual(client.NOME, _cast.NOME);

        }
    }
}
