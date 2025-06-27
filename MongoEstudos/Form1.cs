using MongoDB.Driver;
using MongoEstudos.Models;

namespace MongoEstudos
{
    public partial class Form1 : Form
    {
        private IMongoCollection<Aluno> _colecaoAlunos;
        public Form1()
        {
            InitializeComponent();
            //Conexão com servidor local MongoDb
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("CadastroAlunos");
            _colecaoAlunos = database.GetCollection<Aluno>("alunos");
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno
            {
                Nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                Observacao = txtObservacao.Text
            };
            _colecaoAlunos.InsertOne(aluno);
            MessageBox.Show("Aluno cadastrado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtObservacao.Clear();
        }
    }
}
