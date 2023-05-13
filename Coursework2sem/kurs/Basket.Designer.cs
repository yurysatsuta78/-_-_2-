namespace kurs
{
    partial class Basket
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
            this.basketList = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Deletefrombasket = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basketList
            // 
            this.basketList.FormattingEnabled = true;
            this.basketList.Location = new System.Drawing.Point(257, 12);
            this.basketList.Name = "basketList";
            this.basketList.Size = new System.Drawing.Size(219, 238);
            this.basketList.TabIndex = 0;
            this.basketList.SelectedIndexChanged += new System.EventHandler(this.basketList_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackButton.Location = new System.Drawing.Point(257, 275);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(219, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Buy.Location = new System.Drawing.Point(257, 304);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(219, 23);
            this.Buy.TabIndex = 2;
            this.Buy.Text = "Оплатить";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(482, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ваш баланс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(563, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(482, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Стоимость товаров в корзине:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(672, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // Deletefrombasket
            // 
            this.Deletefrombasket.BackColor = System.Drawing.Color.LightCoral;
            this.Deletefrombasket.Location = new System.Drawing.Point(18, 12);
            this.Deletefrombasket.Name = "Deletefrombasket";
            this.Deletefrombasket.Size = new System.Drawing.Size(219, 23);
            this.Deletefrombasket.TabIndex = 11;
            this.Deletefrombasket.Text = "Удалить из корзины";
            this.Deletefrombasket.UseVisualStyleBackColor = false;
            this.Deletefrombasket.Click += new System.EventHandler(this.Deletefrombasket_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(482, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Стоимость выбранного товара:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(680, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = " ";
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(18, 42);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(219, 23);
            this.Reload.TabIndex = 14;
            this.Reload.Text = "Обновить";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Deletefrombasket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.basketList);
            this.Name = "Basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Basket_FormClosing);
            this.Load += new System.EventHandler(this.Basket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox basketList;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Deletefrombasket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Reload;
    }
}