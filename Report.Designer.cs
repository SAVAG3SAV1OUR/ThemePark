namespace JungleKingdomThemePark_System
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsbOutput = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSold = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.jungleKingdomRecordsDataSet = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSet();
            this.jungleKingdomRecordsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDetailed = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSetBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 174);
            this.panel1.TabIndex = 11;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Black;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(1101, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(344, 53);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(14, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 161);
            this.panel2.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(1101, 108);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(344, 53);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Return To Main Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 55F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 135);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPORTS";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Black;
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(272, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(272, 93);
            this.btnSell.TabIndex = 12;
            this.btnSell.Text = "TOP RIDES";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lsbOutput);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(276, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 675);
            this.panel3.TabIndex = 12;
            // 
            // lsbOutput
            // 
            this.lsbOutput.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.ItemHeight = 31;
            this.lsbOutput.Location = new System.Drawing.Point(314, 6);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.Size = new System.Drawing.Size(812, 562);
            this.lsbOutput.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 339);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnSold
            // 
            this.btnSold.BackColor = System.Drawing.Color.Black;
            this.btnSold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSold.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSold.ForeColor = System.Drawing.Color.White;
            this.btnSold.Location = new System.Drawing.Point(-6, 1);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(272, 95);
            this.btnSold.TabIndex = 13;
            this.btnSold.Text = "AMOUNT OF TICKETS SOLD";
            this.btnSold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSold.UseVisualStyleBackColor = false;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Black;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(141, 330);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(259, 53);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "GENERATE REPORT";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // jungleKingdomRecordsDataSet
            // 
            this.jungleKingdomRecordsDataSet.DataSetName = "JungleKingdomRecordsDataSet";
            this.jungleKingdomRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jungleKingdomRecordsDataSetBindingSource
            // 
            this.jungleKingdomRecordsDataSetBindingSource.DataSource = this.jungleKingdomRecordsDataSet;
            this.jungleKingdomRecordsDataSetBindingSource.Position = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.btnDetailed);
            this.panel4.Controls.Add(this.btnSold);
            this.panel4.Controls.Add(this.btnSell);
            this.panel4.Controls.Add(this.btnGenerate);
            this.panel4.Location = new System.Drawing.Point(2, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 666);
            this.panel4.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 28);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 296);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 28);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // btnDetailed
            // 
            this.btnDetailed.BackColor = System.Drawing.Color.Black;
            this.btnDetailed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailed.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailed.ForeColor = System.Drawing.Color.White;
            this.btnDetailed.Location = new System.Drawing.Point(141, 102);
            this.btnDetailed.Name = "btnDetailed";
            this.btnDetailed.Size = new System.Drawing.Size(272, 69);
            this.btnDetailed.TabIndex = 14;
            this.btnDetailed.Text = "DETAILED REPORT";
            this.btnDetailed.UseVisualStyleBackColor = false;
            this.btnDetailed.Click += new System.EventHandler(this.btnDetailed_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1487, 844);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSetBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.BindingSource jungleKingdomRecordsDataSetBindingSource;
        private JungleKingdomRecordsDataSet jungleKingdomRecordsDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnDetailed;
        private System.Windows.Forms.ListBox lsbOutput;
    }
}