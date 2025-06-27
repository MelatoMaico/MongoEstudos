using MongoDB.Bson;

namespace MongoEstudos.Models
{
    public class Aluno
    {
        public ObjectId Id { get; set; } // campo obrigatório para o MongoDb
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }

    }
}
