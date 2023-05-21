namespace kurs
{
    partial class Registration
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
            this.Surname = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordRep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(135, 106);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(232, 20);
            this.Surname.TabIndex = 2;
            this.Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Surname_KeyPress);
            // 
            // Login
            // 
            this.Login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Login.Location = new System.Drawing.Point(135, 132);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(232, 20);
            this.Login.TabIndex = 3;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(135, 158);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(232, 20);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ваше имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ваша фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пароль";
            // 
            // PasswordRep
            // 
            this.PasswordRep.Location = new System.Drawing.Point(135, 184);
            this.PasswordRep.Name = "PasswordRep";
            this.PasswordRep.Size = new System.Drawing.Size(232, 20);
            this.PasswordRep.TabIndex = 5;
            this.PasswordRep.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = " Повторите пароль";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(204, 229);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(163, 23);
            this.RegButton.TabIndex = 8;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(29, 229);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(163, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Войти";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(117, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "РЕГИСТРАЦИЯ";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(135, 80);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(232, 20);
            this.Name1.TabIndex = 1;
            this.Name1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name1_KeyPress);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 270);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordRep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Surname);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordRep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name1;
    }
}