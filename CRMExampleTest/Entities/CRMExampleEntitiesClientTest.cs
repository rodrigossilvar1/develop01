using CRMExampleEntities.Client;

namespace CRMExampleTest.Entities
{
    [TestClass]
    public class CRMExampleEntitiesClientTest
    {
        [TestMethod]
        public void DeveValidarParametrosEntidadeCliente_Success()
        {
            var pEntities = new ClientEntities();
            Assert.AreEqual(pEntities.Id.GetType(), typeof(string));
            Assert.AreEqual(pEntities.Cpf.GetType(), typeof(string));
            Assert.AreEqual(pEntities.Datainclusao.GetType(), typeof(DateTime));
            Assert.AreEqual(pEntities.DtNascimento.GetType(), typeof(DateTime));
        }
    }
}
