
namespace Lab4NHibernateIndividual
{
    partial class Form5Consultation
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
            this.roomTextBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.roomLabel2 = new System.Windows.Forms.Label();
            this.addButton1 = new System.Windows.Forms.Button();
            this.editButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomTextBox1
            // 
            this.roomTextBox1.Location = new System.Drawing.Point(12, 141);
            this.roomTextBox1.Name = "roomTextBox1";
            this.roomTextBox1.Size = new System.Drawing.Size(278, 22);
            this.roomTextBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 61);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 24, 22, 54, 27, 0);
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Location = new System.Drawing.Point(13, 38);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(45, 17);
            this.dateLabel1.TabIndex = 3;
            this.dateLabel1.Text = "When";
            // 
            // roomLabel2
            // 
            this.roomLabel2.AutoSize = true;
            this.roomLabel2.Location = new System.Drawing.Point(12, 118);
            this.roomLabel2.Name = "roomLabel2";
            this.roomLabel2.Size = new System.Drawing.Size(57, 17);
            this.roomLabel2.TabIndex = 4;
            this.roomLabel2.Text = "Room #";
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(12, 181);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(88, 33);
            this.addButton1.TabIndex = 5;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // editButton2
            // 
            this.editButton2.Location = new System.Drawing.Point(202, 181);
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(88, 33);
            this.editButton2.TabIndex = 6;
            this.editButton2.Text = "Edit";
            this.editButton2.UseVisualStyleBackColor = true;
            this.editButton2.Click += new System.EventHandler(this.editButton2_Click);
            // 
            // Form5Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 238);
            this.Controls.Add(this.editButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.roomLabel2);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.roomTextBox1);
            this.Name = "Form5Consultation";
            this.Text = "Form5Consultation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox roomTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label roomLabel2;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button editButton2;
    }
}