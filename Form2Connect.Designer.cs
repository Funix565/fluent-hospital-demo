
namespace Lab4NHibernateIndividual
{
    partial class Form2Connect
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
            this.hostTextBox1 = new System.Windows.Forms.TextBox();
            this.portTextBox2 = new System.Windows.Forms.TextBox();
            this.dbTextBox3 = new System.Windows.Forms.TextBox();
            this.userTextBox4 = new System.Windows.Forms.TextBox();
            this.passwordTextBox5 = new System.Windows.Forms.TextBox();
            this.hostLabel1 = new System.Windows.Forms.Label();
            this.portLabel2 = new System.Windows.Forms.Label();
            this.dbLabel3 = new System.Windows.Forms.Label();
            this.userLabel4 = new System.Windows.Forms.Label();
            this.passwordLabel5 = new System.Windows.Forms.Label();
            this.connectButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostTextBox1
            // 
            this.hostTextBox1.Location = new System.Drawing.Point(83, 71);
            this.hostTextBox1.Name = "hostTextBox1";
            this.hostTextBox1.Size = new System.Drawing.Size(223, 22);
            this.hostTextBox1.TabIndex = 0;
            // 
            // portTextBox2
            // 
            this.portTextBox2.Location = new System.Drawing.Point(83, 134);
            this.portTextBox2.Name = "portTextBox2";
            this.portTextBox2.Size = new System.Drawing.Size(223, 22);
            this.portTextBox2.TabIndex = 1;
            // 
            // dbTextBox3
            // 
            this.dbTextBox3.Location = new System.Drawing.Point(83, 200);
            this.dbTextBox3.Name = "dbTextBox3";
            this.dbTextBox3.Size = new System.Drawing.Size(223, 22);
            this.dbTextBox3.TabIndex = 2;
            // 
            // userTextBox4
            // 
            this.userTextBox4.Location = new System.Drawing.Point(83, 269);
            this.userTextBox4.Name = "userTextBox4";
            this.userTextBox4.Size = new System.Drawing.Size(223, 22);
            this.userTextBox4.TabIndex = 3;
            // 
            // passwordTextBox5
            // 
            this.passwordTextBox5.Location = new System.Drawing.Point(83, 339);
            this.passwordTextBox5.Name = "passwordTextBox5";
            this.passwordTextBox5.PasswordChar = '*';
            this.passwordTextBox5.Size = new System.Drawing.Size(223, 22);
            this.passwordTextBox5.TabIndex = 4;
            // 
            // hostLabel1
            // 
            this.hostLabel1.AutoSize = true;
            this.hostLabel1.Location = new System.Drawing.Point(80, 51);
            this.hostLabel1.Name = "hostLabel1";
            this.hostLabel1.Size = new System.Drawing.Size(37, 17);
            this.hostLabel1.TabIndex = 5;
            this.hostLabel1.Text = "Host";
            // 
            // portLabel2
            // 
            this.portLabel2.AutoSize = true;
            this.portLabel2.Location = new System.Drawing.Point(80, 114);
            this.portLabel2.Name = "portLabel2";
            this.portLabel2.Size = new System.Drawing.Size(34, 17);
            this.portLabel2.TabIndex = 6;
            this.portLabel2.Text = "Port";
            // 
            // dbLabel3
            // 
            this.dbLabel3.AutoSize = true;
            this.dbLabel3.Location = new System.Drawing.Point(83, 177);
            this.dbLabel3.Name = "dbLabel3";
            this.dbLabel3.Size = new System.Drawing.Size(69, 17);
            this.dbLabel3.TabIndex = 7;
            this.dbLabel3.Text = "Database";
            // 
            // userLabel4
            // 
            this.userLabel4.AutoSize = true;
            this.userLabel4.Location = new System.Drawing.Point(83, 246);
            this.userLabel4.Name = "userLabel4";
            this.userLabel4.Size = new System.Drawing.Size(38, 17);
            this.userLabel4.TabIndex = 8;
            this.userLabel4.Text = "User";
            // 
            // passwordLabel5
            // 
            this.passwordLabel5.AutoSize = true;
            this.passwordLabel5.Location = new System.Drawing.Point(83, 316);
            this.passwordLabel5.Name = "passwordLabel5";
            this.passwordLabel5.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel5.TabIndex = 9;
            this.passwordLabel5.Text = "Password";
            // 
            // connectButton1
            // 
            this.connectButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.connectButton1.Location = new System.Drawing.Point(139, 395);
            this.connectButton1.Name = "connectButton1";
            this.connectButton1.Size = new System.Drawing.Size(98, 43);
            this.connectButton1.TabIndex = 10;
            this.connectButton1.Text = "Connect";
            this.connectButton1.UseVisualStyleBackColor = false;
            this.connectButton1.Click += new System.EventHandler(this.connectButton1_Click);
            // 
            // Form2Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.connectButton1);
            this.Controls.Add(this.passwordLabel5);
            this.Controls.Add(this.userLabel4);
            this.Controls.Add(this.dbLabel3);
            this.Controls.Add(this.portLabel2);
            this.Controls.Add(this.hostLabel1);
            this.Controls.Add(this.passwordTextBox5);
            this.Controls.Add(this.userTextBox4);
            this.Controls.Add(this.dbTextBox3);
            this.Controls.Add(this.portTextBox2);
            this.Controls.Add(this.hostTextBox1);
            this.Name = "Form2Connect";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostTextBox1;
        private System.Windows.Forms.TextBox portTextBox2;
        private System.Windows.Forms.TextBox dbTextBox3;
        private System.Windows.Forms.TextBox userTextBox4;
        private System.Windows.Forms.TextBox passwordTextBox5;
        private System.Windows.Forms.Label hostLabel1;
        private System.Windows.Forms.Label portLabel2;
        private System.Windows.Forms.Label dbLabel3;
        private System.Windows.Forms.Label userLabel4;
        private System.Windows.Forms.Label passwordLabel5;
        private System.Windows.Forms.Button connectButton1;
    }
}