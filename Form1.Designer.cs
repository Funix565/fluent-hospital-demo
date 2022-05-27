
namespace Lab4NHibernateIndividual
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.docGroupBox1 = new System.Windows.Forms.GroupBox();
            this.docDataGridView1 = new System.Windows.Forms.DataGridView();
            this.DoctorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patGroupBox2 = new System.Windows.Forms.GroupBox();
            this.patDataGridView2 = new System.Windows.Forms.DataGridView();
            this.PatientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removePatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultGroupBox3 = new System.Windows.Forms.GroupBox();
            this.consultDataGridView3 = new System.Windows.Forms.DataGridView();
            this.consultContextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addConsultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeConsultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConsultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.docGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docDataGridView1)).BeginInit();
            this.docContextMenuStrip1.SuspendLayout();
            this.patGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patDataGridView2)).BeginInit();
            this.patContextMenuStrip2.SuspendLayout();
            this.consultGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultDataGridView3)).BeginInit();
            this.consultContextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataSourceToolStripMenuItem
            // 
            this.dataSourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.dataSourceToolStripMenuItem.Name = "dataSourceToolStripMenuItem";
            this.dataSourceToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.dataSourceToolStripMenuItem.Text = "Data Source";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.consultGroupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 597);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.docGroupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.patGroupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1024, 290);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 1;
            // 
            // docGroupBox1
            // 
            this.docGroupBox1.Controls.Add(this.docDataGridView1);
            this.docGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.docGroupBox1.Name = "docGroupBox1";
            this.docGroupBox1.Size = new System.Drawing.Size(363, 290);
            this.docGroupBox1.TabIndex = 0;
            this.docGroupBox1.TabStop = false;
            this.docGroupBox1.Text = "Doctors";
            // 
            // docDataGridView1
            // 
            this.docDataGridView1.AllowUserToAddRows = false;
            this.docDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.docDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorNameColumn,
            this.JobTitleColumn});
            this.docDataGridView1.ContextMenuStrip = this.docContextMenuStrip1;
            this.docDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docDataGridView1.Location = new System.Drawing.Point(3, 18);
            this.docDataGridView1.MultiSelect = false;
            this.docDataGridView1.Name = "docDataGridView1";
            this.docDataGridView1.ReadOnly = true;
            this.docDataGridView1.RowHeadersVisible = false;
            this.docDataGridView1.RowHeadersWidth = 51;
            this.docDataGridView1.RowTemplate.Height = 24;
            this.docDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.docDataGridView1.Size = new System.Drawing.Size(357, 269);
            this.docDataGridView1.TabIndex = 0;
            this.docDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.docDataGridView1_CellClick);
            // 
            // DoctorNameColumn
            // 
            this.DoctorNameColumn.HeaderText = "Name";
            this.DoctorNameColumn.MinimumWidth = 6;
            this.DoctorNameColumn.Name = "DoctorNameColumn";
            this.DoctorNameColumn.ReadOnly = true;
            // 
            // JobTitleColumn
            // 
            this.JobTitleColumn.HeaderText = "Job title";
            this.JobTitleColumn.MinimumWidth = 6;
            this.JobTitleColumn.Name = "JobTitleColumn";
            this.JobTitleColumn.ReadOnly = true;
            // 
            // docContextMenuStrip1
            // 
            this.docContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.docContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDocToolStripMenuItem,
            this.removeDocToolStripMenuItem,
            this.editDocToolStripMenuItem});
            this.docContextMenuStrip1.Name = "docContextMenuStrip1";
            this.docContextMenuStrip1.Size = new System.Drawing.Size(133, 76);
            // 
            // addDocToolStripMenuItem
            // 
            this.addDocToolStripMenuItem.Name = "addDocToolStripMenuItem";
            this.addDocToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addDocToolStripMenuItem.Text = "Add";
            this.addDocToolStripMenuItem.Click += new System.EventHandler(this.addDocToolStripMenuItem_Click);
            // 
            // removeDocToolStripMenuItem
            // 
            this.removeDocToolStripMenuItem.Name = "removeDocToolStripMenuItem";
            this.removeDocToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeDocToolStripMenuItem.Text = "Remove";
            this.removeDocToolStripMenuItem.Click += new System.EventHandler(this.removeDocToolStripMenuItem_Click);
            // 
            // editDocToolStripMenuItem
            // 
            this.editDocToolStripMenuItem.Name = "editDocToolStripMenuItem";
            this.editDocToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editDocToolStripMenuItem.Text = "Edit";
            this.editDocToolStripMenuItem.Click += new System.EventHandler(this.editDocToolStripMenuItem_Click);
            // 
            // patGroupBox2
            // 
            this.patGroupBox2.Controls.Add(this.patDataGridView2);
            this.patGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.patGroupBox2.Name = "patGroupBox2";
            this.patGroupBox2.Size = new System.Drawing.Size(657, 290);
            this.patGroupBox2.TabIndex = 0;
            this.patGroupBox2.TabStop = false;
            this.patGroupBox2.Text = "Patients";
            // 
            // patDataGridView2
            // 
            this.patDataGridView2.AllowUserToAddRows = false;
            this.patDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientNameColumn,
            this.InsuranceIdColumn,
            this.DiagnosisColumn});
            this.patDataGridView2.ContextMenuStrip = this.patContextMenuStrip2;
            this.patDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patDataGridView2.Location = new System.Drawing.Point(3, 18);
            this.patDataGridView2.MultiSelect = false;
            this.patDataGridView2.Name = "patDataGridView2";
            this.patDataGridView2.ReadOnly = true;
            this.patDataGridView2.RowHeadersVisible = false;
            this.patDataGridView2.RowHeadersWidth = 51;
            this.patDataGridView2.RowTemplate.Height = 24;
            this.patDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patDataGridView2.Size = new System.Drawing.Size(651, 269);
            this.patDataGridView2.TabIndex = 0;
            this.patDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patDataGridView2_CellClick);
            // 
            // PatientNameColumn
            // 
            this.PatientNameColumn.HeaderText = "Name";
            this.PatientNameColumn.MinimumWidth = 6;
            this.PatientNameColumn.Name = "PatientNameColumn";
            this.PatientNameColumn.ReadOnly = true;
            // 
            // InsuranceIdColumn
            // 
            this.InsuranceIdColumn.HeaderText = "Insurance Id";
            this.InsuranceIdColumn.MinimumWidth = 6;
            this.InsuranceIdColumn.Name = "InsuranceIdColumn";
            this.InsuranceIdColumn.ReadOnly = true;
            // 
            // DiagnosisColumn
            // 
            this.DiagnosisColumn.HeaderText = "Diagnosis";
            this.DiagnosisColumn.MinimumWidth = 6;
            this.DiagnosisColumn.Name = "DiagnosisColumn";
            this.DiagnosisColumn.ReadOnly = true;
            // 
            // patContextMenuStrip2
            // 
            this.patContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatToolStripMenuItem1,
            this.removePatToolStripMenuItem,
            this.editPatToolStripMenuItem1});
            this.patContextMenuStrip2.Name = "patContextMenuStrip2";
            this.patContextMenuStrip2.Size = new System.Drawing.Size(133, 76);
            // 
            // addPatToolStripMenuItem1
            // 
            this.addPatToolStripMenuItem1.Name = "addPatToolStripMenuItem1";
            this.addPatToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.addPatToolStripMenuItem1.Text = "Add";
            this.addPatToolStripMenuItem1.Click += new System.EventHandler(this.addPatToolStripMenuItem1_Click);
            // 
            // removePatToolStripMenuItem
            // 
            this.removePatToolStripMenuItem.Name = "removePatToolStripMenuItem";
            this.removePatToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removePatToolStripMenuItem.Text = "Remove";
            this.removePatToolStripMenuItem.Click += new System.EventHandler(this.removePatToolStripMenuItem_Click);
            // 
            // editPatToolStripMenuItem1
            // 
            this.editPatToolStripMenuItem1.Name = "editPatToolStripMenuItem1";
            this.editPatToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.editPatToolStripMenuItem1.Text = "Edit";
            this.editPatToolStripMenuItem1.Click += new System.EventHandler(this.editPatToolStripMenuItem1_Click);
            // 
            // consultGroupBox3
            // 
            this.consultGroupBox3.Controls.Add(this.consultDataGridView3);
            this.consultGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.consultGroupBox3.Name = "consultGroupBox3";
            this.consultGroupBox3.Size = new System.Drawing.Size(1024, 303);
            this.consultGroupBox3.TabIndex = 0;
            this.consultGroupBox3.TabStop = false;
            this.consultGroupBox3.Text = "Consultations";
            // 
            // consultDataGridView3
            // 
            this.consultDataGridView3.AllowUserToAddRows = false;
            this.consultDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consultDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultDataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ConsultDateColumn,
            this.RoomNumColumn});
            this.consultDataGridView3.ContextMenuStrip = this.consultContextMenuStrip3;
            this.consultDataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultDataGridView3.Location = new System.Drawing.Point(3, 18);
            this.consultDataGridView3.MultiSelect = false;
            this.consultDataGridView3.Name = "consultDataGridView3";
            this.consultDataGridView3.ReadOnly = true;
            this.consultDataGridView3.RowHeadersVisible = false;
            this.consultDataGridView3.RowHeadersWidth = 51;
            this.consultDataGridView3.RowTemplate.Height = 24;
            this.consultDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consultDataGridView3.Size = new System.Drawing.Size(1018, 282);
            this.consultDataGridView3.TabIndex = 0;
            // 
            // consultContextMenuStrip3
            // 
            this.consultContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consultContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConsultToolStripMenuItem,
            this.removeConsultToolStripMenuItem,
            this.editConsultToolStripMenuItem});
            this.consultContextMenuStrip3.Name = "consultContextMenuStrip3";
            this.consultContextMenuStrip3.Size = new System.Drawing.Size(133, 76);
            // 
            // addConsultToolStripMenuItem
            // 
            this.addConsultToolStripMenuItem.Name = "addConsultToolStripMenuItem";
            this.addConsultToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addConsultToolStripMenuItem.Text = "Add";
            this.addConsultToolStripMenuItem.Click += new System.EventHandler(this.addConsultToolStripMenuItem_Click);
            // 
            // removeConsultToolStripMenuItem
            // 
            this.removeConsultToolStripMenuItem.Name = "removeConsultToolStripMenuItem";
            this.removeConsultToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.removeConsultToolStripMenuItem.Text = "Remove";
            this.removeConsultToolStripMenuItem.Click += new System.EventHandler(this.removeConsultToolStripMenuItem_Click);
            // 
            // editConsultToolStripMenuItem
            // 
            this.editConsultToolStripMenuItem.Name = "editConsultToolStripMenuItem";
            this.editConsultToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editConsultToolStripMenuItem.Text = "Edit";
            this.editConsultToolStripMenuItem.Click += new System.EventHandler(this.editConsultToolStripMenuItem_Click);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // ConsultDateColumn
            // 
            this.ConsultDateColumn.HeaderText = "Consultation Date";
            this.ConsultDateColumn.MinimumWidth = 6;
            this.ConsultDateColumn.Name = "ConsultDateColumn";
            this.ConsultDateColumn.ReadOnly = true;
            // 
            // RoomNumColumn
            // 
            this.RoomNumColumn.HeaderText = "Room Number";
            this.RoomNumColumn.MinimumWidth = 6;
            this.RoomNumColumn.Name = "RoomNumColumn";
            this.RoomNumColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 625);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.docGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docDataGridView1)).EndInit();
            this.docContextMenuStrip1.ResumeLayout(false);
            this.patGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patDataGridView2)).EndInit();
            this.patContextMenuStrip2.ResumeLayout(false);
            this.consultGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultDataGridView3)).EndInit();
            this.consultContextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox docGroupBox1;
        private System.Windows.Forms.GroupBox patGroupBox2;
        private System.Windows.Forms.DataGridView docDataGridView1;
        private System.Windows.Forms.DataGridView patDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitleColumn;
        private System.Windows.Forms.ContextMenuStrip docContextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip patContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removePatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPatToolStripMenuItem1;
        private System.Windows.Forms.GroupBox consultGroupBox3;
        private System.Windows.Forms.DataGridView consultDataGridView3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ContextMenuStrip consultContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem addConsultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeConsultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConsultToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumColumn;
    }
}

