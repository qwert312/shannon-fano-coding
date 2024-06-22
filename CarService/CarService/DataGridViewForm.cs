using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarService
{
    public partial class DataGridViewForm : Form
    {
        private string connectionString;
        private string query;


        public DataGridViewForm(string connectionString, string query)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.query = query;
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewResults.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
