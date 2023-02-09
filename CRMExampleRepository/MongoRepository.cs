namespace CRMExampleRepository
{
    public class MongoRepository
    {
        /// <summary>String de conexao</summary>
        public string ConnectionURI { get; set; } = null;
        /// <summary>Data base</summary>
        public string DataBaseName { get; set; } = null;
        /// <summary>CollectionName</summary>
        public string CollectionName { get; set; } = null;
    }
}