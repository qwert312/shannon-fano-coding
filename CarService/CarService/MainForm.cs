using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CarService
{
    public partial class MainForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
            LoadTableNames();
        }

        private void LoadTableNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    DataTable table = connection.GetSchema("Tables", new string[] { null, null, null, "BASE TABLE" });

                    foreach (DataRow row in table.Rows)
                    {
                        if (row[2].ToString() != "sysdiagrams")
                        {
                            string tableName = row[2].ToString();
                            comboBoxTables.Items.Add(tableName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке таблиц: " + ex.Message);
                }
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [{comboBoxTables.SelectedItem.ToString()}]", connection);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dataTable.Columns["ID"].ReadOnly = true;

                    dataGridViewTable.DataSource = dataTable;

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void buttonDeleteRows_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTable.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridViewTable.Rows.RemoveAt(row.Index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите строки для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка при удалении строк: " + ex.Message);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectedTable = comboBoxTables.SelectedItem.ToString();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [{selectedTable}]", connection);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable dataTable = (DataTable)dataGridViewTable.DataSource;

                    dataAdapter.Update(dataTable);

                    MessageBox.Show("Таблица базы данных была обновлена");

                    dataTable.Clear();

                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }



        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void buttonFindOrderByID_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [Order] WHERE ID = {textBoxID.Text}";

            DataGridViewForm findOrderForm = new DataGridViewForm(connectionString, query);
            findOrderForm.Show();
        }

        private void buttonFindOrderDetailsByOrderID_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM [OrderDetails] WHERE OrderID = {textBoxID.Text}";

            DataGridViewForm findOrderDetailsForm = new DataGridViewForm(connectionString, query);
            findOrderDetailsForm.Show();
        }

        private void buttonReportServiceProvisionByCarBrand_Click(object sender, EventArgs e)
        {
            string query = "SELECT Brand as CarBrand, COUNT(*) as CarsCount  " +
                "FROM [Car] c " +
                "JOIN [Order] o ON o.CarID = c.ID " +
                "JOIN [OrderDetails] od ON o.ID = od.OrderID " +
                "GROUP BY c.Brand";

            ChartForm serviceProvisionByCarBarnd = new ChartForm(connectionString, query, "CarsCount", "CarBrand", "Кол-во услуг по машинам бренда", "Бренд", 
                SeriesChartType.Pie);
            serviceProvisionByCarBarnd.Show();
        }

        private void buttonReportIncomeFromOrdersByYear_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Order]";

            ChartForm profitFromOrdersByYear = new ChartForm(connectionString, query, "TotalPrice", "CompletionDate", "Доход с заказа (руб.)", "Дата завершения заказа", 
                SeriesChartType.Point);
            profitFromOrdersByYear.Show();
        }

        private void buttonReportTechniciansProductivityForYear_Click(object sender, EventArgs e)
        {
            //выведем и ID и имя, потому что у некоторых техников может повторяться комбинация имени и фамилии
            string query = "SELECT CONCAT(t.ID, '| ', t.FirstName, ' ', t.LastName) as TechnicianIDAndName, COUNT(*) as OrderDetailsCount  " +
                "FROM [Technician] t " +
                "JOIN [OrderDetails] od ON t.ID = od.TechnicianID " +
                "JOIN [Order] o ON o.id = od.OrderID " +
                $"WHERE YEAR(o.CompletionDate) = {maskedTextBoxYear.Text} " +
                "GROUP BY t.ID, t.FirstName, t.LastName;";

            ChartForm techniciansProductivityForYear = new ChartForm(connectionString, query, "OrderDetailsCount", "TechnicianIDAndName", 
                $"Кол-во выполненных работ по заказам (за {maskedTextBoxYear.Text} год)", "ID и имя Техника", SeriesChartType.Column);
            techniciansProductivityForYear.Show();
        }

        private void buttonReportMostPopularServicesOfTheYear_Click(object sender, EventArgs e)
        {
            string query = "SELECT CONCAT(s.ID, '| ', s.[Name]) as ServiceIDAndName, COUNT(*) as [Count] " +
                "FROM [Service] s " +
                "JOIN [OrderDetails] od ON s.ID = od.ServiceID " +
                "JOIN [Order] o ON o.id = od.OrderID " +
                $"WHERE YEAR(o.CompletionDate) = {maskedTextBoxYear.Text} " +
                "GROUP BY s.ID, s.[Name];";

            ChartForm mostPopularServicesOfTheYear = new ChartForm(connectionString, query, "Count", "ServiceIDAndName", 
                $"Сколько раз была оказана услуга (за {maskedTextBoxYear.Text} год)", "ID и название Услуги", SeriesChartType.Column);
            mostPopularServicesOfTheYear.Show();    
        }

        private void buttonReportSumIncomeByYear_Click(object sender, EventArgs e)
        {
            string query = "SELECT YEAR(CompletionDate) as Year, SUM(TotalPrice) as TotalIncome " +
                "FROM [Order] o " +
                "GROUP BY YEAR(o.CompletionDate);";

            ChartForm sumProfitByYears = new ChartForm(connectionString, query, "TotalIncome", "Year", "Суммарный доход (руб.)", "Год", SeriesChartType.Column);
            sumProfitByYears.Show();    
        }

        private void buttonMostPopularServicesOfAllTime_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Name] as ServiceName, COUNT (*) as [Count] " +
                "FROM [Service] s " +
                "JOIN [OrderDetails] od ON od.ServiceID = s.ID " +
                "GROUP BY s.Name;";

            ChartForm mostPopularServicesOfAllTime = new ChartForm(connectionString, query, "Count", "ServiceName", "Сколько раз была оказана услуга", "Услуга", 
                SeriesChartType.Column);
            mostPopularServicesOfAllTime.Show();
        }

        private void buttonReportIncomeFromOrdersForYear_Click(object sender, EventArgs e)
        {
            string query = "SELECT CompletionDate as OrderCompletionDate, TotalPrice as TotalPriceForOrder " +
                "FROM [Order] o " +
                $"WHERE YEAR(o.CompletionDate) = {maskedTextBoxYear.Text} ";

            ChartForm incomeFromOrdersForYear = new ChartForm(connectionString, query, "TotalPriceForOrder", "OrderCompletionDate", 
                $"Доход по заказам за {maskedTextBoxYear.Text} год (руб.)", "Дата", SeriesChartType.Point);
            incomeFromOrdersForYear.Show();
        }

        private void tabPage_Click(object sender, EventArgs e)
        {
            dataGridViewTable.ClearSelection();
            ActiveControl = null;

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridViewTable.ClearSelection();
            ActiveControl = null;

        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            dataGridViewTable.ClearSelection();
            ActiveControl = null;
        }
    }
}
