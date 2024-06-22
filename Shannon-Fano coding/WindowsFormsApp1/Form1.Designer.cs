namespace ShannonFanoProgram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.textBoxFromFile = new System.Windows.Forms.TextBox();
            this.labelFileText = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResultText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(10, 3);
            this.buttonEncode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(158, 27);
            this.buttonEncode.TabIndex = 0;
            this.buttonEncode.Text = "Кодировать файл";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(176, 3);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(159, 27);
            this.buttonDecode.TabIndex = 1;
            this.buttonDecode.Text = "Раскодировать файл";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(5, 5);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(88, 27);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Обзор";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.Location = new System.Drawing.Point(101, 8);
            this.textBoxBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.ReadOnly = true;
            this.textBoxBrowse.Size = new System.Drawing.Size(275, 21);
            this.textBoxBrowse.TabIndex = 3;
            // 
            // textBoxFromFile
            // 
            this.textBoxFromFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFromFile.Location = new System.Drawing.Point(4, 23);
            this.textBoxFromFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFromFile.Multiline = true;
            this.textBoxFromFile.Name = "textBoxFromFile";
            this.textBoxFromFile.ReadOnly = true;
            this.textBoxFromFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFromFile.Size = new System.Drawing.Size(478, 500);
            this.textBoxFromFile.TabIndex = 4;
            // 
            // labelFileText
            // 
            this.labelFileText.AutoSize = true;
            this.labelFileText.Location = new System.Drawing.Point(4, 0);
            this.labelFileText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileText.Name = "labelFileText";
            this.labelFileText.Size = new System.Drawing.Size(148, 15);
            this.labelFileText.TabIndex = 5;
            this.labelFileText.Text = "Текст выбранного файла";
            // 
            // textBoxResultText
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(490, 23);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResultText";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(478, 500);
            this.textBoxResult.TabIndex = 6;
            // 
            // labelResultText
            // 
            this.labelResultText.AutoSize = true;
            this.labelResultText.Location = new System.Drawing.Point(490, 0);
            this.labelResultText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultText.Name = "labelResultText";
            this.labelResultText.Size = new System.Drawing.Size(282, 15);
            this.labelResultText.TabIndex = 7;
            this.labelResultText.Text = "Текст закодированного/декодированного файла";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxResult, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelResultText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFromFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFileText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 526);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickCurrentActivityOnNull);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttonDecode);
            this.flowLayoutPanel1.Controls.Add(this.buttonEncode);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(637, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 38);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Controls.Add(this.textBoxBrowse);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 35);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(979, 45);
            this.tableLayoutPanel2.TabIndex = 11;
            this.tableLayoutPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickCurrentActivityOnNull);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(979, 595);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Кодирование методом Шеннона-Фано";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickCurrentActivityOnNull);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonBrowse;
        internal System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.TextBox textBoxFromFile;
        private System.Windows.Forms.Label labelFileText;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResultText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

