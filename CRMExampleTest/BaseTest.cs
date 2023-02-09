using CRMExampleEntities.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CRMExampleTest
{
    [TestClass]
    public class BaseTest
    {
        MongoClient _client;
        IMongoDatabase _database;

        [TestInitialize]
        public void Init()
        {
            _client = new MongoClient("mongodb://root:rootpwd@localhost:27017");
            _database = _client.GetDatabase("crm_example");
        }

        [TestMethod]
        public void DeveValidar_ListaDataBaseMongo()
        {
            var dbList = _client.ListDatabaseNames().ToList();
            Assert.IsTrue(dbList.Any());
        }

        [TestMethod]
        public void DeveIncluirRegistroSuccess()
        {
            var pParam = new ClientEntities()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Cpf = "123456789",
                DtNascimento = new DateTime(2000,01,01),
                Datainclusao = DateTime.Now
            };

            var _collection = _database.GetCollection<ClientEntities>("CRMExample");
            _collection.InsertOne(pParam);
            
            Assert.IsTrue(true);
        }
    }
}