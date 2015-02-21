using System;
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
        
    }
}
