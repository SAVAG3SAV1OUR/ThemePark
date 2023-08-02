namespace JungleKingdomThemePark_System
{
    partial class frmRides
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRides));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRideID = new System.Windows.Forms.ComboBox();
            this.txbRide = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbOutput = new System.Windows.Forms.ListBox();
            this.jungleKingdomRecordsDataSet = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSet();
            this.rIDESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rIDESTableAdapter = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSetTableAdapters.RIDESTableAdapter();
            this.tableAdapterManager = new JungleKingdomThemePark_System.JungleKingdomRecordsDataSetTableAdapters.TableAdapterManager();
            this.rIDESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rIDESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rIDESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIDESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIDESBindingNavigator)).BeginInit();
            this.rIDESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rIDESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(298, 166);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(272, 53);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE RIDE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(161, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(272, 53);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(20, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 53);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD NEW RIDE";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(3, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 140);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblHelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbHelp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 161);
            this.panel1.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Yellow;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(680, 54);
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
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(664, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search Ride Name:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(892, 113);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(301, 32);
            this.txbSearch.TabIndex = 24;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Yellow;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(1053, 3);
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
            this.lblHelp.ForeColor = System.Drawing.Color.Black;
            this.lblHelp.Location = new System.Drawing.Point(1305, 85);
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(217, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 135);
            this.label1.TabIndex = 3;
            this.label1.Text = "RIDES";
            // 
            // pbHelp
            // 
            this.pbHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHelp.BackgroundImage")));
            this.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Location = new System.Drawing.Point(1199, 58);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 128);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnConfirmDelete);
            this.groupBox1.Controls.Add(this.btnConfirmUpdate);
            this.groupBox1.Controls.Add(this.btnConfirmAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbRideID);
            this.groupBox1.Controls.Add(this.txbRide);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 287);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbName.BackgroundImage")));
            this.pbName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbName.Location = new System.Drawing.Point(596, 142);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(37, 37);
            this.pbName.TabIndex = 32;
            this.pbName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(273, 182);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 29);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Insert ride name";
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.BackColor = System.Drawing.Color.Green;
            this.btnConfirmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDelete.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDelete.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDelete.Location = new System.Drawing.Point(0, 228);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(272, 53);
            this.btnConfirmDelete.TabIndex = 15;
            this.btnConfirmDelete.Text = "CONFIRM";
            this.btnConfirmDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmDelete.UseVisualStyleBackColor = false;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.BackColor = System.Drawing.Color.Green;
            this.btnConfirmUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmUpdate.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmUpdate.ForeColor = System.Drawing.Color.White;
            this.btnConfirmUpdate.Location = new System.Drawing.Point(0, 228);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(272, 53);
            this.btnConfirmUpdate.TabIndex = 14;
            this.btnConfirmUpdate.Text = "CONFIRM";
            this.btnConfirmUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmUpdate.UseVisualStyleBackColor = false;
            this.btnConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.BackColor = System.Drawing.Color.Green;
            this.btnConfirmAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmAdd.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAdd.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAdd.Location = new System.Drawing.Point(0, 228);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(272, 53);
            this.btnConfirmAdd.TabIndex = 11;
            this.btnConfirmAdd.Text = "CONFIRM";
            this.btnConfirmAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmAdd.UseVisualStyleBackColor = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 45);
            this.label6.TabIndex = 13;
            this.label6.Text = "RideID:";
            // 
            // cmbRideID
            // 
            this.cmbRideID.FormattingEnabled = true;
            this.cmbRideID.Location = new System.Drawing.Point(278, 81);
            this.cmbRideID.Name = "cmbRideID";
            this.cmbRideID.Size = new System.Drawing.Size(120, 43);
            this.cmbRideID.TabIndex = 12;
            this.cmbRideID.SelectedIndexChanged += new System.EventHandler(this.cmbRideID_SelectedIndexChanged);
            // 
            // txbRide
            // 
            this.txbRide.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRide.Location = new System.Drawing.Point(278, 147);
            this.txbRide.Name = "txbRide";
            this.txbRide.Size = new System.Drawing.Size(301, 32);
            this.txbRide.TabIndex = 5;
            this.txbRide.TextChanged += new System.EventHandler(this.txbRide_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ride Name:";
            // 
            // lsbOutput
            // 
            this.lsbOutput.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.ItemHeight = 22;
            this.lsbOutput.Location = new System.Drawing.Point(696, 151);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.ScrollAlwaysVisible = true;
            this.lsbOutput.Size = new System.Drawing.Size(763, 620);
            this.lsbOutput.TabIndex = 13;
            // 
            // jungleKingdomRecordsDataSet
            // 
            this.jungleKingdomRecordsDataSet.DataSetName = "JungleKingdomRecordsDataSet";
            this.jungleKingdomRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rIDESBindingSource
            // 
            this.rIDESBindingSource.DataMember = "RIDES";
            this.rIDESBindingSource.DataSource = this.jungleKingdomRecordsDataSet;
            // 
            // rIDESTableAdapter
            // 
            this.rIDESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RIDESTableAdapter = this.rIDESTableAdapter;
            this.tableAdapterManager.STAFF_ON_DUTYTableAdapter = null;
            this.tableAdapterManager.STAFFTableAdapter = null;
            this.tableAdapterManager.SUMMARYTableAdapter = null;
            this.tableAdapterManager.TICKETSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JungleKingdomThemePark_System.JungleKingdomRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITORSTableAdapter = null;
            // 
            // rIDESBindingNavigator
            // 
            this.rIDESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rIDESBindingNavigator.BindingSource = this.rIDESBindingSource;
            this.rIDESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rIDESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rIDESBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rIDESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rIDESBindingNavigatorSaveItem});
            this.rIDESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rIDESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rIDESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rIDESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rIDESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rIDESBindingNavigator.Name = "rIDESBindingNavigator";
            this.rIDESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rIDESBindingNavigator.Size = new System.Drawing.Size(1459, 27);
            this.rIDESBindingNavigator.TabIndex = 14;
            this.rIDESBindingNavigator.Text = "bindingNavigator1";
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
            // rIDESBindingNavigatorSaveItem
            // 
            this.rIDESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rIDESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rIDESBindingNavigatorSaveItem.Image")));
            this.rIDESBindingNavigatorSaveItem.Name = "rIDESBindingNavigatorSaveItem";
            this.rIDESBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.rIDESBindingNavigatorSaveItem.Text = "Save Data";
            this.rIDESBindingNavigatorSaveItem.Click += new System.EventHandler(this.rIDESBindingNavigatorSaveItem_Click);
            // 
            // rIDESDataGridView
            // 
            this.rIDESDataGridView.AutoGenerateColumns = false;
            this.rIDESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rIDESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rIDESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.rIDESDataGridView.DataSource = this.rIDESBindingSource;
            this.rIDESDataGridView.Location = new System.Drawing.Point(700, 166);
            this.rIDESDataGridView.Name = "rIDESDataGridView";
            this.rIDESDataGridView.RowHeadersWidth = 51;
            this.rIDESDataGridView.RowTemplate.Height = 24;
            this.rIDESDataGridView.Size = new System.Drawing.Size(493, 220);
            this.rIDESDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ride_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ride_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ride_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ride_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmRides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1454, 1055);
            this.Controls.Add(this.rIDESDataGridView);
            this.Controls.Add(this.rIDESBindingNavigator);
            this.Controls.Add(this.lsbOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRides";
            this.Text = "Rides";
            this.Load += new System.EventHandler(this.frmRides_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jungleKingdomRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIDESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIDESBindingNavigator)).EndInit();
            this.rIDESBindingNavigator.ResumeLayout(false);
            this.rIDESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rIDESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRideID;
        private System.Windows.Forms.TextBox txbRide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lsbOutput;
        private JungleKingdomRecordsDataSet jungleKingdomRecordsDataSet;
        private System.Windows.Forms.BindingSource rIDESBindingSource;
        private JungleKingdomRecordsDataSetTableAdapters.RIDESTableAdapter rIDESTableAdapter;
        private JungleKingdomRecordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rIDESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rIDESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rIDESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}