using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Atividade_12___Trabalho_Final
{
    public partial class Form1 : Form
    {

        Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Carrega os produtos
        private void LoadData()
        {

            db.OpenConnection();
            string query = "SELECT * FROM Produto";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
            db.CloseConnection();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                string nome = dataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();
                decimal preco = Convert.ToDecimal(dataGridView.SelectedRows[0].Cells["Preco"].Value);

                FormCadastro formCadastro = new FormCadastro(id, nome, preco);
                if (formCadastro.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                db.OpenConnection();
                string query = "DELETE FROM Produto WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
        }
    }
}
