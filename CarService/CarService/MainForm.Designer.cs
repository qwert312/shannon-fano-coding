namespace CarService
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTablesComboBox = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonDeleteRows = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.buttonMostPopularServicesOfAllTime = new System.Windows.Forms.Button();
            this.buttonReportServiceProvisionByCarBrand = new System.Windows.Forms.Button();
            this.buttonReportIncomeFromOrdersByYear = new System.Windows.Forms.Button();
            this.buttonReportSumIncomeByYear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxFindForms = new System.Windows.Forms.GroupBox();
            this.buttonFindOrderByID = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelSelectedID = new System.Windows.Forms.Label();
            this.buttonFindOrderDetailsByOrderID = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxYearReports = new System.Windows.Forms.GroupBox();
            this.buttonReportIncomeFromOrdersForYear = new System.Windows.Forms.Button();
            this.labelSelectedYear = new System.Windows.Forms.Label();
            this.buttonReportMostPopularServicesOfTheYear = new System.Windows.Forms.Button();
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.buttonReportTechniciansProductivityForYear = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxReports.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxFindForms.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxYearReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 469);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр и изменение таблиц";
            this.tabPage1.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewTable, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 380);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.labelTablesComboBox);
            this.panel1.Controls.Add(this.comboBoxTables);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(254, 33);
            this.panel1.TabIndex = 6;
            // 
            // labelTablesComboBox
            // 
            this.labelTablesComboBox.AutoSize = true;
            this.labelTablesComboBox.Location = new System.Drawing.Point(3, 8);
            this.labelTablesComboBox.Name = "labelTablesComboBox";
            this.labelTablesComboBox.Size = new System.Drawing.Size(111, 13);
            this.labelTablesComboBox.TabIndex = 1;
            this.labelTablesComboBox.Text = "Выбранная таблица:";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.BackColor = System.Drawing.Color.White;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(120, 5);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 2;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.buttonSaveChanges, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteRows, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 333);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(757, 46);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveChanges.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSaveChanges.Location = new System.Drawing.Point(579, 3);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(175, 40);
            this.buttonSaveChanges.TabIndex = 4;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonDeleteRows
            // 
            this.buttonDeleteRows.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDeleteRows.Location = new System.Drawing.Point(3, 3);
            this.buttonDeleteRows.Name = "buttonDeleteRows";
            this.buttonDeleteRows.Size = new System.Drawing.Size(175, 37);
            this.buttonDeleteRows.TabIndex = 3;
            this.buttonDeleteRows.Text = "Удалить выделенные строки";
            this.buttonDeleteRows.UseVisualStyleBackColor = false;
            this.buttonDeleteRows.Click += new System.EventHandler(this.buttonDeleteRows_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(753, 291);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчёты и прочее";
            this.tabPage2.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(824, 421);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.groupBoxReports);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.MinimumSize = new System.Drawing.Size(200, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 419);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReports.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxReports.Controls.Add(this.buttonMostPopularServicesOfAllTime);
            this.groupBoxReports.Controls.Add(this.buttonReportServiceProvisionByCarBrand);
            this.groupBoxReports.Controls.Add(this.buttonReportIncomeFromOrdersByYear);
            this.groupBoxReports.Controls.Add(this.buttonReportSumIncomeByYear);
            this.groupBoxReports.Location = new System.Drawing.Point(6, 13);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(263, 275);
            this.groupBoxReports.TabIndex = 9;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Отчёты (общее)";
            // 
            // buttonMostPopularServicesOfAllTime
            // 
            this.buttonMostPopularServicesOfAllTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMostPopularServicesOfAllTime.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMostPopularServicesOfAllTime.Location = new System.Drawing.Point(9, 187);
            this.buttonMostPopularServicesOfAllTime.Name = "buttonMostPopularServicesOfAllTime";
            this.buttonMostPopularServicesOfAllTime.Size = new System.Drawing.Size(248, 50);
            this.buttonMostPopularServicesOfAllTime.TabIndex = 8;
            this.buttonMostPopularServicesOfAllTime.Text = "Самые популярные услуги за всё время";
            this.buttonMostPopularServicesOfAllTime.UseVisualStyleBackColor = false;
            this.buttonMostPopularServicesOfAllTime.Click += new System.EventHandler(this.buttonMostPopularServicesOfAllTime_Click);
            // 
            // buttonReportServiceProvisionByCarBrand
            // 
            this.buttonReportServiceProvisionByCarBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportServiceProvisionByCarBrand.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReportServiceProvisionByCarBrand.Location = new System.Drawing.Point(9, 19);
            this.buttonReportServiceProvisionByCarBrand.Name = "buttonReportServiceProvisionByCarBrand";
            this.buttonReportServiceProvisionByCarBrand.Size = new System.Drawing.Size(248, 50);
            this.buttonReportServiceProvisionByCarBrand.TabIndex = 2;
            this.buttonReportServiceProvisionByCarBrand.Text = "Соотношение оказаний услуг по маркам автомобилей";
            this.buttonReportServiceProvisionByCarBrand.UseVisualStyleBackColor = false;
            this.buttonReportServiceProvisionByCarBrand.Click += new System.EventHandler(this.buttonReportServiceProvisionByCarBrand_Click);
            // 
            // buttonReportIncomeFromOrdersByYear
            // 
            this.buttonReportIncomeFromOrdersByYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportIncomeFromOrdersByYear.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReportIncomeFromOrdersByYear.Location = new System.Drawing.Point(9, 75);
            this.buttonReportIncomeFromOrdersByYear.Name = "buttonReportIncomeFromOrdersByYear";
            this.buttonReportIncomeFromOrdersByYear.Size = new System.Drawing.Size(248, 50);
            this.buttonReportIncomeFromOrdersByYear.TabIndex = 1;
            this.buttonReportIncomeFromOrdersByYear.Text = "Доходы по заказам за всё время (по годам)";
            this.buttonReportIncomeFromOrdersByYear.UseVisualStyleBackColor = false;
            this.buttonReportIncomeFromOrdersByYear.Click += new System.EventHandler(this.buttonReportIncomeFromOrdersByYear_Click);
            // 
            // buttonReportSumIncomeByYear
            // 
            this.buttonReportSumIncomeByYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportSumIncomeByYear.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReportSumIncomeByYear.Location = new System.Drawing.Point(9, 131);
            this.buttonReportSumIncomeByYear.Name = "buttonReportSumIncomeByYear";
            this.buttonReportSumIncomeByYear.Size = new System.Drawing.Size(248, 50);
            this.buttonReportSumIncomeByYear.TabIndex = 7;
            this.buttonReportSumIncomeByYear.Text = "Суммарные доходы за каждый год";
            this.buttonReportSumIncomeByYear.UseVisualStyleBackColor = false;
            this.buttonReportSumIncomeByYear.Click += new System.EventHandler(this.buttonReportSumIncomeByYear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.groupBoxFindForms);
            this.groupBox3.Location = new System.Drawing.Point(549, 1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.MinimumSize = new System.Drawing.Size(200, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 419);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // groupBoxFindForms
            // 
            this.groupBoxFindForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFindForms.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxFindForms.Controls.Add(this.buttonFindOrderByID);
            this.groupBoxFindForms.Controls.Add(this.textBoxID);
            this.groupBoxFindForms.Controls.Add(this.labelSelectedID);
            this.groupBoxFindForms.Controls.Add(this.buttonFindOrderDetailsByOrderID);
            this.groupBoxFindForms.Location = new System.Drawing.Point(6, 13);
            this.groupBoxFindForms.Name = "groupBoxFindForms";
            this.groupBoxFindForms.Size = new System.Drawing.Size(262, 275);
            this.groupBoxFindForms.TabIndex = 10;
            this.groupBoxFindForms.TabStop = false;
            this.groupBoxFindForms.Text = "Поиск (по ID)";
            // 
            // buttonFindOrderByID
            // 
            this.buttonFindOrderByID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindOrderByID.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFindOrderByID.Location = new System.Drawing.Point(9, 75);
            this.buttonFindOrderByID.Name = "buttonFindOrderByID";
            this.buttonFindOrderByID.Size = new System.Drawing.Size(248, 50);
            this.buttonFindOrderByID.TabIndex = 4;
            this.buttonFindOrderByID.Text = "Найти заказ по ID";
            this.buttonFindOrderByID.UseVisualStyleBackColor = false;
            this.buttonFindOrderByID.Click += new System.EventHandler(this.buttonFindOrderByID_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(33, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // labelSelectedID
            // 
            this.labelSelectedID.AutoSize = true;
            this.labelSelectedID.Location = new System.Drawing.Point(6, 23);
            this.labelSelectedID.Name = "labelSelectedID";
            this.labelSelectedID.Size = new System.Drawing.Size(21, 13);
            this.labelSelectedID.TabIndex = 6;
            this.labelSelectedID.Text = "ID:";
            // 
            // buttonFindOrderDetailsByOrderID
            // 
            this.buttonFindOrderDetailsByOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindOrderDetailsByOrderID.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFindOrderDetailsByOrderID.Location = new System.Drawing.Point(9, 131);
            this.buttonFindOrderDetailsByOrderID.Name = "buttonFindOrderDetailsByOrderID";
            this.buttonFindOrderDetailsByOrderID.Size = new System.Drawing.Size(248, 50);
            this.buttonFindOrderDetailsByOrderID.TabIndex = 5;
            this.buttonFindOrderDetailsByOrderID.Text = "Найти детали заказа по ID заказа";
            this.buttonFindOrderDetailsByOrderID.UseVisualStyleBackColor = false;
            this.buttonFindOrderDetailsByOrderID.Click += new System.EventHandler(this.buttonFindOrderDetailsByOrderID_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.groupBoxYearReports);
            this.groupBox2.Location = new System.Drawing.Point(275, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.MinimumSize = new System.Drawing.Size(200, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 419);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBoxYearReports
            // 
            this.groupBoxYearReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxYearReports.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBoxYearReports.Controls.Add(this.buttonReportIncomeFromOrdersForYear);
            this.groupBoxYearReports.Controls.Add(this.labelSelectedYear);
            this.groupBoxYearReports.Controls.Add(this.buttonReportMostPopularServicesOfTheYear);
            this.groupBoxYearReports.Controls.Add(this.maskedTextBoxYear);
            this.groupBoxYearReports.Controls.Add(this.buttonReportTechniciansProductivityForYear);
            this.groupBoxYearReports.Location = new System.Drawing.Point(6, 13);
            this.groupBoxYearReports.Name = "groupBoxYearReports";
            this.groupBoxYearReports.Size = new System.Drawing.Size(263, 275);
            this.groupBoxYearReports.TabIndex = 11;
            this.groupBoxYearReports.TabStop = false;
            this.groupBoxYearReports.Text = "Отчёты (за год)";
            // 
            // buttonReportIncomeFromOrdersForYear
            // 
            this.buttonReportIncomeFromOrdersForYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportIncomeFromOrdersForYear.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReportIncomeFromOrdersForYear.Location = new System.Drawing.Point(9, 187);
            this.buttonReportIncomeFromOrdersForYear.Name = "buttonReportIncomeFromOrdersForYear";
            this.buttonReportIncomeFromOrdersForYear.Size = new System.Drawing.Size(248, 50);
            this.buttonReportIncomeFromOrdersForYear.TabIndex = 10;
            this.buttonReportIncomeFromOrdersForYear.Text = "Доходы по заказам за выбранный год";
            this.buttonReportIncomeFromOrdersForYear.UseVisualStyleBackColor = false;
            this.buttonReportIncomeFromOrdersForYear.Click += new System.EventHandler(this.buttonReportIncomeFromOrdersForYear_Click);
            // 
            // labelSelectedYear
            // 
            this.labelSelectedYear.AutoSize = true;
            this.labelSelectedYear.Location = new System.Drawing.Point(6, 23);
            this.labelSelectedYear.Name = "labelSelectedYear";
            this.labelSelectedYear.Size = new System.Drawing.Size(28, 13);
            this.labelSelectedYear.TabIndex = 8;
            this.labelSelectedYear.Text = "Год:";
            // 
            // buttonReportMostPopularServicesOfTheYear
            // 
            this.buttonReportMostPopularServicesOfTheYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportMostPopularServicesOfTheYear.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReportMostPopularServicesOfTheYear.Location = new System.Drawing.Point(9, 131);
            this.buttonReportMostPopularServicesOfTheYear.Name = "buttonReportMostPopularServicesOfTheYear";
            this.buttonReportMostPopularServicesOfTheYear.Size = new System.Drawing.Size(248, 50);
            this.buttonReportMostPopularServicesOfTheYear.TabIndex = 6;
            this.buttonReportMostPopularServicesOfTheYear.Text = "Самые популярные услуги за выбранный год";
            this.buttonReportMostPopularServicesOfTheYear.UseVisualStyleBackColor = false;
            this.buttonReportMostPopularServicesOfTheYear.Click += new System.EventHandler(this.buttonReportMostPopularServicesOfTheYear_Click);
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Location = new System.Drawing.Point(39, 20);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxYear.TabIndex = 9;
            this.maskedTextBoxYear.ValidatingType = typeof(int);
            // 
            // buttonReportTechniciansProductivityForYear
            // 
            this.buttonReportTechniciansProductivityForYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportTechniciansProductivityForYear.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReportTechniciansProductivityForYear.Location = new System.Drawing.Point(9, 75);
            this.buttonReportTechniciansProductivityForYear.Name = "buttonReportTechniciansProductivityForYear";
            this.buttonReportTechniciansProductivityForYear.Size = new System.Drawing.Size(248, 50);
            this.buttonReportTechniciansProductivityForYear.TabIndex = 0;
            this.buttonReportTechniciansProductivityForYear.Text = "Продуктивность техников за выбранный год";
            this.buttonReportTechniciansProductivityForYear.UseVisualStyleBackColor = false;
            this.buttonReportTechniciansProductivityForYear.Click += new System.EventHandler(this.buttonReportTechniciansProductivityForYear_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(861, 487);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 335);
            this.Name = "MainForm";
            this.Text = "Приложение для работы с базой данных CarService";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxReports.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxFindForms.ResumeLayout(false);
            this.groupBoxFindForms.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxYearReports.ResumeLayout(false);
            this.groupBoxYearReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonDeleteRows;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label labelTablesComboBox;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonReportTechniciansProductivityForYear;
        private System.Windows.Forms.Button buttonReportIncomeFromOrdersByYear;
        private System.Windows.Forms.Button buttonReportServiceProvisionByCarBrand;
        private System.Windows.Forms.Button buttonFindOrderDetailsByOrderID;
        private System.Windows.Forms.Button buttonFindOrderByID;
        private System.Windows.Forms.Button buttonReportMostPopularServicesOfTheYear;
        private System.Windows.Forms.Button buttonReportSumIncomeByYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYear;
        private System.Windows.Forms.Label labelSelectedYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSelectedID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxFindForms;
        private System.Windows.Forms.GroupBox groupBoxYearReports;
        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.Button buttonMostPopularServicesOfAllTime;
        private System.Windows.Forms.Button buttonReportIncomeFromOrdersForYear;
    }
}

