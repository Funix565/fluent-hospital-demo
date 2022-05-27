
namespace Lab4NHibernateIndividual
{
    partial class Form4Patient
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
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.insuranceTextBox2 = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox3 = new System.Windows.Forms.TextBox();
            this.addButton1 = new System.Windows.Forms.Button();
            this.editButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.insuranceLabel2 = new System.Windows.Forms.Label();
            this.diagnosisLabel3 = new System.Windows.Forms.Label();
            this.avlbComboBox1 = new System.Windows.Forms.ComboBox();
            this.avlbLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(58, 129);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(248, 22);
            this.nameTextBox1.TabIndex = 0;
            // 
            // insuranceTextBox2
            // 
            this.insuranceTextBox2.Location = new System.Drawing.Point(58, 190);
            this.insuranceTextBox2.Name = "insuranceTextBox2";
            this.insuranceTextBox2.Size = new System.Drawing.Size(248, 22);
            this.insuranceTextBox2.TabIndex = 1;
            // 
            // diagnosisTextBox3
            // 
            this.diagnosisTextBox3.Location = new System.Drawing.Point(58, 250);
            this.diagnosisTextBox3.Name = "diagnosisTextBox3";
            this.diagnosisTextBox3.Size = new System.Drawing.Size(248, 22);
            this.diagnosisTextBox3.TabIndex = 2;
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(58, 308);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(89, 34);
            this.addButton1.TabIndex = 3;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // editButton2
            // 
            this.editButton2.Location = new System.Drawing.Point(215, 308);
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(90, 34);
            this.editButton2.TabIndex = 4;
            this.editButton2.Text = "Edit";
            this.editButton2.UseVisualStyleBackColor = true;
            this.editButton2.Click += new System.EventHandler(this.editButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // insuranceLabel2
            // 
            this.insuranceLabel2.AutoSize = true;
            this.insuranceLabel2.Location = new System.Drawing.Point(58, 167);
            this.insuranceLabel2.Name = "insuranceLabel2";
            this.insuranceLabel2.Size = new System.Drawing.Size(85, 17);
            this.insuranceLabel2.TabIndex = 6;
            this.insuranceLabel2.Text = "Insurance Id";
            // 
            // diagnosisLabel3
            // 
            this.diagnosisLabel3.AutoSize = true;
            this.diagnosisLabel3.Location = new System.Drawing.Point(58, 227);
            this.diagnosisLabel3.Name = "diagnosisLabel3";
            this.diagnosisLabel3.Size = new System.Drawing.Size(70, 17);
            this.diagnosisLabel3.TabIndex = 7;
            this.diagnosisLabel3.Text = "Diagnosis";
            // 
            // avlbComboBox1
            // 
            this.avlbComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.avlbComboBox1.FormattingEnabled = true;
            this.avlbComboBox1.Location = new System.Drawing.Point(58, 66);
            this.avlbComboBox1.Name = "avlbComboBox1";
            this.avlbComboBox1.Size = new System.Drawing.Size(248, 24);
            this.avlbComboBox1.TabIndex = 8;
            this.avlbComboBox1.Click += new System.EventHandler(this.avlbComboBox1_Click);
            // 
            // avlbLabel2
            // 
            this.avlbLabel2.AutoSize = true;
            this.avlbLabel2.Location = new System.Drawing.Point(58, 43);
            this.avlbLabel2.Name = "avlbLabel2";
            this.avlbLabel2.Size = new System.Drawing.Size(116, 17);
            this.avlbLabel2.TabIndex = 9;
            this.avlbLabel2.Text = "Choose available";
            // 
            // Form4Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 362);
            this.Controls.Add(this.avlbLabel2);
            this.Controls.Add(this.avlbComboBox1);
            this.Controls.Add(this.diagnosisLabel3);
            this.Controls.Add(this.insuranceLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.diagnosisTextBox3);
            this.Controls.Add(this.insuranceTextBox2);
            this.Controls.Add(this.nameTextBox1);
            this.Name = "Form4Patient";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox insuranceTextBox2;
        private System.Windows.Forms.TextBox diagnosisTextBox3;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button editButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insuranceLabel2;
        private System.Windows.Forms.Label diagnosisLabel3;
        private System.Windows.Forms.ComboBox avlbComboBox1;
        private System.Windows.Forms.Label avlbLabel2;
    }
}