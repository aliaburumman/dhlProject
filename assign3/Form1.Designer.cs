namespace assign3
{
    partial class Form1
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
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.textBoxConsname2 = new System.Windows.Forms.TextBox();
            this.textBoxConsname1 = new System.Windows.Forms.TextBox();
            this.comboBoxDest = new System.Windows.Forms.ComboBox();
            this.labelconsname2 = new System.Windows.Forms.Label();
            this.labelconsname1 = new System.Windows.Forms.Label();
            this.labeldest = new System.Windows.Forms.Label();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.labelgm = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.Box = new System.Windows.Forms.RadioButton();
            this.Envelope = new System.Windows.Forms.RadioButton();
            this.textBoxshippername = new System.Windows.Forms.TextBox();
            this.textBoxref = new System.Windows.Forms.TextBox();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelweight = new System.Windows.Forms.Label();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelshipname = new System.Windows.Forms.Label();
            this.labelref = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newShippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxConsname2);
            this.groupBoxDetails.Controls.Add(this.textBoxConsname1);
            this.groupBoxDetails.Controls.Add(this.comboBoxDest);
            this.groupBoxDetails.Controls.Add(this.labelconsname2);
            this.groupBoxDetails.Controls.Add(this.labelconsname1);
            this.groupBoxDetails.Controls.Add(this.labeldest);
            this.groupBoxDetails.Location = new System.Drawing.Point(260, 338);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(481, 171);
            this.groupBoxDetails.TabIndex = 26;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Consinee Details";
            this.groupBoxDetails.Enter += new System.EventHandler(this.groupBoxDetails_Enter);
            // 
            // textBoxConsname2
            // 
            this.textBoxConsname2.Location = new System.Drawing.Point(206, 129);
            this.textBoxConsname2.Name = "textBoxConsname2";
            this.textBoxConsname2.Size = new System.Drawing.Size(200, 26);
            this.textBoxConsname2.TabIndex = 10;
            // 
            // textBoxConsname1
            // 
            this.textBoxConsname1.Location = new System.Drawing.Point(206, 93);
            this.textBoxConsname1.Name = "textBoxConsname1";
            this.textBoxConsname1.Size = new System.Drawing.Size(200, 26);
            this.textBoxConsname1.TabIndex = 9;
            // 
            // comboBoxDest
            // 
            this.comboBoxDest.FormattingEnabled = true;
            this.comboBoxDest.Location = new System.Drawing.Point(206, 48);
            this.comboBoxDest.Name = "comboBoxDest";
            this.comboBoxDest.Size = new System.Drawing.Size(200, 28);
            this.comboBoxDest.TabIndex = 8;
            // 
            // labelconsname2
            // 
            this.labelconsname2.AutoSize = true;
            this.labelconsname2.Location = new System.Drawing.Point(22, 135);
            this.labelconsname2.Name = "labelconsname2";
            this.labelconsname2.Size = new System.Drawing.Size(131, 20);
            this.labelconsname2.TabIndex = 7;
            this.labelconsname2.Text = "Consignee Name";
            // 
            // labelconsname1
            // 
            this.labelconsname1.AutoSize = true;
            this.labelconsname1.Location = new System.Drawing.Point(22, 93);
            this.labelconsname1.Name = "labelconsname1";
            this.labelconsname1.Size = new System.Drawing.Size(131, 20);
            this.labelconsname1.TabIndex = 6;
            this.labelconsname1.Text = "Consignee Name";
            // 
            // labeldest
            // 
            this.labeldest.AutoSize = true;
            this.labeldest.Location = new System.Drawing.Point(22, 51);
            this.labeldest.Name = "labeldest";
            this.labeldest.Size = new System.Drawing.Size(159, 20);
            this.labeldest.TabIndex = 5;
            this.labeldest.Text = "Destination (Country)";
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(420, 213);
            this.textBoxaddress.Multiline = true;
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(223, 104);
            this.textBoxaddress.TabIndex = 25;
            this.textBoxaddress.TextChanged += new System.EventHandler(this.textBoxaddress_TextChanged);
            // 
            // labelgm
            // 
            this.labelgm.AutoSize = true;
            this.labelgm.Location = new System.Drawing.Point(536, 160);
            this.labelgm.Name = "labelgm";
            this.labelgm.Size = new System.Drawing.Size(31, 20);
            this.labelgm.TabIndex = 24;
            this.labelgm.Text = "gm";
            this.labelgm.Click += new System.EventHandler(this.labelgm_Click);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(400, 160);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(120, 26);
            this.Weight.TabIndex = 23;
            this.Weight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // Box
            // 
            this.Box.AutoSize = true;
            this.Box.Checked = true;
            this.Box.Location = new System.Drawing.Point(506, 119);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(61, 24);
            this.Box.TabIndex = 22;
            this.Box.TabStop = true;
            this.Box.Text = "Box";
            this.Box.UseVisualStyleBackColor = true;
            this.Box.CheckedChanged += new System.EventHandler(this.Box_CheckedChanged);
            // 
            // Envelope
            // 
            this.Envelope.AutoSize = true;
            this.Envelope.Location = new System.Drawing.Point(400, 119);
            this.Envelope.Name = "Envelope";
            this.Envelope.Size = new System.Drawing.Size(100, 24);
            this.Envelope.TabIndex = 21;
            this.Envelope.Text = "Envelope";
            this.Envelope.UseVisualStyleBackColor = true;
            this.Envelope.CheckedChanged += new System.EventHandler(this.Envelope_CheckedChanged);
            // 
            // textBoxshippername
            // 
            this.textBoxshippername.Location = new System.Drawing.Point(400, 69);
            this.textBoxshippername.Name = "textBoxshippername";
            this.textBoxshippername.Size = new System.Drawing.Size(243, 26);
            this.textBoxshippername.TabIndex = 20;
            this.textBoxshippername.TextChanged += new System.EventHandler(this.textBoxshippername_TextChanged);
            // 
            // textBoxref
            // 
            this.textBoxref.Location = new System.Drawing.Point(400, 23);
            this.textBoxref.Name = "textBoxref";
            this.textBoxref.Size = new System.Drawing.Size(156, 26);
            this.textBoxref.TabIndex = 19;
            this.textBoxref.TextChanged += new System.EventHandler(this.textBoxref_TextChanged);
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(253, 213);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(127, 20);
            this.labeladdress.TabIndex = 18;
            this.labeladdress.Text = "Shipper Address";
            this.labeladdress.Click += new System.EventHandler(this.labeladdress_Click);
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(253, 162);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(125, 20);
            this.labelweight.TabIndex = 17;
            this.labelweight.Text = "Package Weight";
            this.labelweight.Click += new System.EventHandler(this.labelweight_Click);
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(255, 121);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(109, 20);
            this.labeltype.TabIndex = 16;
            this.labeltype.Text = "Package Type";
            this.labeltype.Click += new System.EventHandler(this.labeltype_Click);
            // 
            // labelshipname
            // 
            this.labelshipname.AutoSize = true;
            this.labelshipname.Location = new System.Drawing.Point(255, 75);
            this.labelshipname.Name = "labelshipname";
            this.labelshipname.Size = new System.Drawing.Size(110, 20);
            this.labelshipname.TabIndex = 15;
            this.labelshipname.Text = "Shipper Name";
            this.labelshipname.Click += new System.EventHandler(this.labelshipname_Click);
            // 
            // labelref
            // 
            this.labelref.AutoSize = true;
            this.labelref.Location = new System.Drawing.Point(255, 29);
            this.labelref.Name = "labelref";
            this.labelref.Size = new System.Drawing.Size(97, 20);
            this.labelref.TabIndex = 14;
            this.labelref.Text = "Ref. number";
            this.labelref.Click += new System.EventHandler(this.labelref_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newShippingToolStripMenuItem,
            this.updateExistingToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.searchTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(179, 450);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // newShippingToolStripMenuItem
            // 
            this.newShippingToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newShippingToolStripMenuItem.Name = "newShippingToolStripMenuItem";
            this.newShippingToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.newShippingToolStripMenuItem.Text = "New Shipping";
            this.newShippingToolStripMenuItem.Click += new System.EventHandler(this.newShippingToolStripMenuItem_Click);
            // 
            // updateExistingToolStripMenuItem
            // 
            this.updateExistingToolStripMenuItem.Name = "updateExistingToolStripMenuItem";
            this.updateExistingToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.updateExistingToolStripMenuItem.Text = "Update Existing";
            this.updateExistingToolStripMenuItem.Click += new System.EventHandler(this.updateExistingToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(162, 31);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.labelgm);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Envelope);
            this.Controls.Add(this.textBoxshippername);
            this.Controls.Add(this.textBoxref);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelweight);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.labelshipname);
            this.Controls.Add(this.labelref);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox textBoxConsname2;
        private System.Windows.Forms.TextBox textBoxConsname1;
        private System.Windows.Forms.ComboBox comboBoxDest;
        private System.Windows.Forms.Label labelconsname2;
        private System.Windows.Forms.Label labelconsname1;
        private System.Windows.Forms.Label labeldest;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.Label labelgm;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.RadioButton Box;
        private System.Windows.Forms.RadioButton Envelope;
        private System.Windows.Forms.TextBox textBoxshippername;
        private System.Windows.Forms.TextBox textBoxref;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelweight;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labelshipname;
        private System.Windows.Forms.Label labelref;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newShippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
    }
}

