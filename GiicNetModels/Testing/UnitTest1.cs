using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Hasresult()
        {
            var xx = new GiicNetBus.Base.Clientes();
            var result = xx.GetClientesBr("90276");

            Assert.IsNotNull(result);

        }
        
    }
}
