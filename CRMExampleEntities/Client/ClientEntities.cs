using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CRMExampleEntities.Client
{
    public class ClientEntities
    {
        /// <summary>Chave de identificação</summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        /// <summary>Cpf do cliente</summary>
        [BsonElement("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [BsonElement("dtInclusao")]
        public DateTime Datainclusao { get; set; } = DateTime.Now;

        [BsonElement("DataNascimento")]
        public DateTime DtNascimento { get; set; }

    }
}