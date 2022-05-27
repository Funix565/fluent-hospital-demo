
namespace Lab4NHibernateIndividual
{
    partial class Form3Doctor
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
            this.jobTextBox2 = new System.Windows.Forms.TextBox();
            this.addButton1 = new System.Windows.Forms.Button();
            this.editButton2 = new System.Windows.Forms.Button();
            this.docNameLabel1 = new System.Windows.Forms.Label();
            this.jobLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(48, 66);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(231, 22);
            this.nameTextBox1.TabIndex = 0;
            // 
            // jobTextBox2
            // 
            this.jobTextBox2.Location = new System.Drawing.Point(48, 129);
            this.jobTextBox2.Name = "jobTextBox2";
            this.jobTextBox2.Size = new System.Drawing.Size(231, 22);
            this.jobTextBox2.TabIndex = 1;
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(48, 175);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(88, 32);
            this.addButton1.TabIndex = 2;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // editButton2
            // 
            this.editButton2.Location = new System.Drawing.Point(187, 175);
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(91, 32);
            this.editButton2.TabIndex = 3;
            this.editButton2.Text = "Edit";
            this.editButton2.UseVisualStyleBackColor = true;
            this.editButton2.Click += new System.EventHandler(this.editButton2_Click);
            // 
            // docNameLabel1
            // 
            this.docNameLabel1.AutoSize = true;
            this.docNameLabel1.Location = new System.Drawing.Point(48, 43);
            this.docNameLabel1.Name = "docNameLabel1";
            this.docNameLabel1.Size = new System.Drawing.Size(45, 17);
            this.docNameLabel1.TabIndex = 4;
            this.docNameLabel1.Text = "Name";
            // 
            // jobLabel2
            // 
            this.jobLabel2.AutoSize = true;
            this.jobLabel2.Location = new System.Drawing.Point(48, 106);
            this.jobLabel2.Name = "jobLabel2";
            this.jobLabel2.Size = new System.Drawing.Size(57, 17);
            this.jobLabel2.TabIndex = 5;
            this.jobLabel2.Text = "Job title";
            // 
            // Form3Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 228);
            this.Controls.Add(this.jobLabel2);
            this.Controls.Add(this.docNameLabel1);
            this.Controls.Add(this.editButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.jobTextBox2);
            this.Controls.Add(this.nameTextBox1);
            this.Name = "Form3Doctor";
            this.Text = "Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox jobTextBox2;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button editButton2;
        private System.Windows.Forms.Label docNameLabel1;
        private System.Windows.Forms.Label jobLabel2;
    }
}