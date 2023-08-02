namespace JungleKingdomThemePark_System
{
    partial class frmDuty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuty));
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsbOutput = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRide = new System.Windows.Forms.TextBox();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.pbRide = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRide = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmID = new System.Windows.Forms.ComboBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jungleKingdomRecordsDataSet = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSet();
            this.sTAFF_ON_DUTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFF_ON_DUTYTableAdapter = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSetTableAdapters.STAFF_ON_DUTYTableAdapter();
            this.tableAdapterManager = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSetTableAdapters.TableAdapterManager();
            this.sTAFF_ON_DUTYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sTAFF_ON_DUTYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFF_ON_DUTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFF_ON_DUTYBindingNavigator)).BeginInit();
            this.sTAFF_ON_DUTYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFF_ON_DUTYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Brown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(144, 199);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(387, 78);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ASSIGN STAFF TO TASK";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 185);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblHelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbHelp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 158);
            this.panel1.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Brown;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(1075, 58);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(344, 53);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(719, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search Date:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(885, 121);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(301, 32);
            this.txbSearch.TabIndex = 24;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Brown;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(1075, 2);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(344, 53);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Return To Main Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(1317, 85);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(113, 45);
            this.lblHelp.TabIndex = 10;
            this.lblHelp.Text = "HELP?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 55F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 135);
            this.label1.TabIndex = 3;
            this.label1.Text = "STAFF ON DUTY";
            // 
            // pbHelp
            // 
            this.pbHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHelp.BackgroundImage")));
            this.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Location = new System.Drawing.Point(1212, 58);
            this.pbHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(100, 100);
            this.pbHelp.TabIndex = 9;
            this.pbHelp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(20, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 128);
            this.panel2.TabIndex = 2;
            // 
            // lsbOutput
            // 
            this.lsbOutput.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.ItemHeight = 22;
            this.lsbOutput.Location = new System.Drawing.Point(687, 153);
            this.lsbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.ScrollAlwaysVisible = true;
            this.lsbOutput.Size = new System.Drawing.Size(766, 708);
            this.lsbOutput.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbRide);
            this.groupBox1.Controls.Add(this.pbID);
            this.groupBox1.Controls.Add(this.btnConfirmAdd);
            this.groupBox1.Controls.Add(this.pbRide);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRide);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbEmID);
            this.groupBox1.Controls.Add(this.txbSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbFirstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(678, 491);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 354);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 42);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 45);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ride";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbRide
            // 
            this.txbRide.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRide.Location = new System.Drawing.Point(272, 298);
            this.txbRide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbRide.Name = "txbRide";
            this.txbRide.Size = new System.Drawing.Size(301, 32);
            this.txbRide.TabIndex = 29;
            // 
            // pbID
            // 
            this.pbID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbID.BackgroundImage")));
            this.pbID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbID.Location = new System.Drawing.Point(397, 62);
            this.pbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(37, 37);
            this.pbID.TabIndex = 28;
            this.pbID.TabStop = false;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.BackColor = System.Drawing.Color.Green;
            this.btnConfirmAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmAdd.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAdd.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAdd.Location = new System.Drawing.Point(5, 433);
            this.btnConfirmAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(272, 53);
            this.btnConfirmAdd.TabIndex = 25;
            this.btnConfirmAdd.Text = "CONFIRM";
            this.btnConfirmAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmAdd.UseVisualStyleBackColor = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // pbRide
            // 
            this.pbRide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRide.BackgroundImage")));
            this.pbRide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRide.Location = new System.Drawing.Point(397, 117);
            this.pbRide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRide.Name = "pbRide";
            this.pbRide.Size = new System.Drawing.Size(37, 37);
            this.pbRide.TabIndex = 24;
            this.pbRide.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 45);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date:";
            // 
            // cmbRide
            // 
            this.cmbRide.FormattingEnabled = true;
            this.cmbRide.Location = new System.Drawing.Point(272, 111);
            this.cmbRide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRide.Name = "cmbRide";
            this.cmbRide.Size = new System.Drawing.Size(120, 43);
            this.cmbRide.TabIndex = 16;
            this.cmbRide.SelectedIndexChanged += new System.EventHandler(this.cmbRide_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ride ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 45);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employee ID:";
            // 
            // cmbEmID
            // 
            this.cmbEmID.FormattingEnabled = true;
            this.cmbEmID.Location = new System.Drawing.Point(272, 57);
            this.cmbEmID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmID.Name = "cmbEmID";
            this.cmbEmID.Size = new System.Drawing.Size(120, 43);
            this.cmbEmID.TabIndex = 12;
            this.cmbEmID.SelectedIndexChanged += new System.EventHandler(this.cmbEmID_SelectedIndexChanged);
            // 
            // txbSurname
            // 
            this.txbSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSurname.Location = new System.Drawing.Point(272, 234);
            this.txbSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(301, 32);
            this.txbSurname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Location = new System.Drawing.Point(272, 177);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(301, 32);
            this.txbFirstName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // jungleKingdomRecordsDataSet
            // 
            this.jungleKingdomRecordsDataSet.DataSetName = "JungleKingdomRecordsDataSet";
            this.jungleKingdomRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFF_ON_DUTYBindingSource
            // 
            this.sTAFF_ON_DUTYBindingSource.DataMember = "STAFF_ON_DUTY";
            this.sTAFF_ON_DUTYBindingSource.DataSource = this.jungleKingdomRecordsDataSet;
            // 
            // sTAFF_ON_DUTYTableAdapter
            // 
            this.sTAFF_ON_DUTYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RIDESTableAdapter = null;
            this.tableAdapterManager.STAFF_ON_DUTYTableAdapter = this.sTAFF_ON_DUTYTableAdapter;
            this.tableAdapterManager.STAFFTableAdapter = null;
            this.tableAdapterManager.SUMMARYTableAdapter = null;
            this.tableAdapterManager.TICKETSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JungleKingdomThemePark_System.JungleKingdomRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORSTableAdapter = null;
            // 
            // sTAFF_ON_DUTYBindingNavigator
            // 
            this.sTAFF_ON_DUTYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sTAFF_ON_DUTYBindingNavigator.BindingSource = this.sTAFF_ON_DUTYBindingSource;
            this.sTAFF_ON_DUTYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sTAFF_ON_DUTYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sTAFF_ON_DUTYBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sTAFF_ON_DUTYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem});
            this.sTAFF_ON_DUTYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sTAFF_ON_DUTYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sTAFF_ON_DUTYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sTAFF_ON_DUTYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sTAFF_ON_DUTYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sTAFF_ON_DUTYBindingNavigator.Name = "sTAFF_ON_DUTYBindingNavigator";
            this.sTAFF_ON_DUTYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sTAFF_ON_DUTYBindingNavigator.Size = new System.Drawing.Size(1454, 27);
            this.sTAFF_ON_DUTYBindingNavigator.TabIndex = 14;
            this.sTAFF_ON_DUTYBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sTAFF_ON_DUTYBindingNavigatorSaveItem
            // 
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sTAFF_ON_DUTYBindingNavigatorSaveItem.Image")));
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem.Name = "sTAFF_ON_DUTYBindingNavigatorSaveItem";
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem.Text = "Save Data";
            this.sTAFF_ON_DUTYBindingNavigatorSaveItem.Click += new System.EventHandler(this.sTAFF_ON_DUTYBindingNavigatorSaveItem_Click);
            // 
            // sTAFF_ON_DUTYDataGridView
            // 
            this.sTAFF_ON_DUTYDataGridView.AutoGenerateColumns = false;
            this.sTAFF_ON_DUTYDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sTAFF_ON_DUTYDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sTAFF_ON_DUTYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTAFF_ON_DUTYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sTAFF_ON_DUTYDataGridView.DataSource = this.sTAFF_ON_DUTYBindingSource;
            this.sTAFF_ON_DUTYDataGridView.Location = new System.Drawing.Point(687, 153);
            this.sTAFF_ON_DUTYDataGridView.Name = "sTAFF_ON_DUTYDataGridView";
            this.sTAFF_ON_DUTYDataGridView.RowHeadersWidth = 51;
            this.sTAFF_ON_DUTYDataGridView.RowTemplate.Height = 24;
            this.sTAFF_ON_DUTYDataGridView.Size = new System.Drawing.Size(769, 226);
            this.sTAFF_ON_DUTYDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Duty_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Duty_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ride_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ride_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_On_Duty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date_On_Duty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(267, 398);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 29);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Search Date:";
            // 
            // frmDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1454, 869);
            this.Controls.Add(this.sTAFF_ON_DUTYDataGridView);
            this.Controls.Add(this.sTAFF_ON_DUTYBindingNavigator);
            this.Controls.Add(this.lsbOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDuty";
            this.Text = "StaffOnDuty";
            this.Load += new System.EventHandler(this.frmDuty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFF_ON_DUTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFF_ON_DUTYBindingNavigator)).EndInit();
            this.sTAFF_ON_DUTYBindingNavigator.ResumeLayout(false);
            this.sTAFF_ON_DUTYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFF_ON_DUTYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbRide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRide;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEmID;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lsbOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRide;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private JungleKingdomRecordsDataSet jungleKingdomRecordsDataSet;
        private System.Windows.Forms.BindingSource sTAFF_ON_DUTYBindingSource;
        private JungleKingdomRecordsDataSetTableAdapters.STAFF_ON_DUTYTableAdapter sTAFF_ON_DUTYTableAdapter;
        private JungleKingdomRecordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sTAFF_ON_DUTYBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sTAFF_ON_DUTYBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sTAFF_ON_DUTYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblDate;
    }
}