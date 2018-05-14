namespace BookShopApplication
{
    partial class Login
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.idTBox = new System.Windows.Forms.TextBox();
            this.passTBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(302, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(233, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fuler Dokan";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(178, 119);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "User ID";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(178, 164);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Password";
            // 
            // idTBox
            // 
            this.idTBox.Location = new System.Drawing.Point(285, 111);
            this.idTBox.Name = "idTBox";
            this.idTBox.Size = new System.Drawing.Size(100, 20);
            this.idTBox.TabIndex = 3;
            // 
            // passTBox
            // 
            this.passTBox.Location = new System.Drawing.Point(285, 157);
            this.passTBox.Name = "passTBox";
            this.passTBox.Size = new System.Drawing.Size(100, 20);
            this.passTBox.TabIndex = 4;
            this.passTBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(214, 208);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtnClicked);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(319, 208);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtnClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 365);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTBox);
            this.Controls.Add(this.idTBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Login";
            this.Text = "BookShop Management System - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox idTBox;
        private System.Windows.Forms.TextBox passTBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

