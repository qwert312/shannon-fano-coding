using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarService
{
    public partial class ChartForm : Form
    {
        private string connectionString;
        private string query;
        private string yColumnName;
        private string xColumnName;
        private string yAxisName;
        private string xAxisName;
        private SeriesChartType seriesChartType;

        public ChartForm(string connection, string query, string yColumnName, string xColumnName, string yAxisName, string xAxisName, SeriesChartType chartType)
        {
            InitializeComponent();
            this.connectionString = connection;
            this.query = query;
            this.yColumnName = yColumnName;
            this.xColumnName = xColumnName;
            this.yAxisName = yAxisName;
            this.xAxisName = xAxisName;
            this.seriesChartType = chartType;   
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BindDataToChart(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void BindDataToChart(DataTable dataTable)
        {
            try
            {
                if (dataTable.Columns.Count < 2)
                {
                    throw new Exception("Недостаточно колонок в таблице");
                }

                Title chartTitle = new Title();
                chartTitle.Text = $"Диаграмма \"{yAxisName} / {xAxisName}\"";
                ChartResults.Titles.Add(chartTitle);


                Series series = new Series(dataTable.TableName)
                {
                    Color = Color.Black,
                    Name = $"[{dataTable.TableName}] {yColumnName}/{xColumnName}",
                    ChartType = seriesChartType
                };
                series.Points.DataBindXY(dataTable.Rows, xColumnName, dataTable.Rows, yColumnName);

                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.BackColor = Color.SeaShell;

                if (new[] { SeriesChartType.Pie }.Contains(seriesChartType))
                {
                    series.IsValueShownAsLabel = true;
                    series.Label = "#VALY";
                    series["PieLabelStyle"] = "Outside";
                    series["PieLineColor"] = "Black";
                    series.LegendText = "#VALX";

                    ChartResults.Legends.Add(new Legend("Legend1") { BackColor = Color.SeaShell });
                    ChartResults.Legends["Legend1"].Docking = Docking.Bottom;
                }
                else if (new[] { SeriesChartType.Column, SeriesChartType.Point }.Contains(seriesChartType))
                {
                    chartArea.AxisY.Title = yAxisName;
                    chartArea.AxisX.Title = xAxisName;
                    chartArea.AxisX.Interval = 1;

                    if (dataTable.Columns[xColumnName].DataType == typeof(DateTime))
                    {
                        chartArea.AxisX.LabelStyle.Format = "MM.yyyy";
                        chartArea.AxisX.IntervalType = DateTimeIntervalType.Months;
                        chartArea.AxisX.Interval = 2;
                    }
                }
                else
                {
                    throw new Exception("Поддерживаются только диаграммы типа Pie, Column и Point!");
                }

                ChartResults.ChartAreas.Add(chartArea);
                ChartResults.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
