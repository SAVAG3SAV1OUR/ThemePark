namespace JungleKingdomThemePark_System
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lsbOutput = new System.Windows.Forms.ListBox();
            this.btnRides = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnDuty = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 108);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAIN MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(752, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 677);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.lsbOutput);
            this.pnlButtons.Controls.Add(this.btnRides);
            this.pnlButtons.Controls.Add(this.btnSell);
            this.pnlButtons.Controls.Add(this.btnRequest);
            this.pnlButtons.Controls.Add(this.btnStaff);
            this.pnlButtons.Controls.Add(this.btnDuty);
            this.pnlButtons.Controls.Add(this.btnVisitors);
            this.pnlButtons.Location = new System.Drawing.Point(126, 130);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(583, 629);
            this.pnlButtons.TabIndex = 6;
            // 
            // lsbOutput
            // 
            this.lsbOutput.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOutput.FormattingEnabled = true;
            this.lsbOutput.ItemHeight = 22;
            this.lsbOutput.Location = new System.Drawing.Point(-2, -2);
            this.lsbOutput.Name = "lsbOutput";
            this.lsbOutput.ScrollAlwaysVisible = true;
            this.lsbOutput.Size = new System.Drawing.Size(583, 642);
            this.lsbOutput.TabIndex = 10;
            // 
            // btnRides
            // 
            this.btnRides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRides.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRides.Location = new System.Drawing.Point(25, 131);
            this.btnRides.Name = "btnRides";
            this.btnRides.Size = new System.Drawing.Size(528, 53);
            this.btnRides.TabIndex = 5;
            this.btnRides.Text = "MAINTAIN RIDES";
            this.btnRides.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRides.UseVisualStyleBackColor = true;
            this.btnRides.Click += new System.EventHandler(this.btnRides_Click);
            // 
            // btnSell
            // 
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Location = new System.Drawing.Point(25, 526);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(528, 53);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "SELL TICKETS";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(25, 431);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(528, 53);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "REQUEST REPORTS";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(19, 234);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(528, 53);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "MAINTAIN STAFF";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnDuty
            // 
            this.btnDuty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuty.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuty.Location = new System.Drawing.Point(25, 338);
            this.btnDuty.Name = "btnDuty";
            this.btnDuty.Size = new System.Drawing.Size(528, 53);
            this.btnDuty.TabIndex = 1;
            this.btnDuty.Text = "MAINTAIN STAFF ON DUTY";
            this.btnDuty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuty.UseVisualStyleBackColor = true;
            this.btnDuty.Click += new System.EventHandler(this.btnDuty_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitors.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.Location = new System.Drawing.Point(19, 30);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(528, 53);
            this.btnVisitors.TabIndex = 0;
            this.btnVisitors.Text = "MAINTAIN VISITORS";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisitors.UseVisualStyleBackColor = true;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // pbHelp
            // 
            this.pbHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHelp.BackgroundImage")));
            this.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelp.Location = new System.Drawing.Point(12, 9);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(100, 100);
            this.pbHelp.TabIndex = 7;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(118, 36);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(113, 45);
            this.lblHelp.TabIndex = 8;
            this.lblHelp.Text = "HELP?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1, 810);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(142, 40);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(306, 80);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(172, 44);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1446, 850);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnRides;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnDuty;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListBox lsbOutput;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}