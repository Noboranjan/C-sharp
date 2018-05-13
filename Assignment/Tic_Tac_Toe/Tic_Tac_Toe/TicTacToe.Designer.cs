namespace Tic_Tac_Toe
{
    partial class TicTacToe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.NGBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Xwin = new System.Windows.Forms.Label();
            this.Owin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(30, 93);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(75, 61);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(30, 248);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(75, 61);
            this.A20.TabIndex = 1;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(30, 171);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(75, 61);
            this.A10.TabIndex = 2;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(124, 171);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(75, 61);
            this.A11.TabIndex = 5;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(124, 248);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(75, 61);
            this.A21.TabIndex = 4;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(124, 93);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(75, 61);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(214, 171);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(75, 61);
            this.A12.TabIndex = 8;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(214, 248);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(75, 61);
            this.A22.TabIndex = 7;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClicked);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(214, 93);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(75, 61);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NGBtn
            // 
            this.NGBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGBtn.Location = new System.Drawing.Point(30, 346);
            this.NGBtn.Name = "NGBtn";
            this.NGBtn.Size = new System.Drawing.Size(75, 28);
            this.NGBtn.TabIndex = 9;
            this.NGBtn.Text = "New Game";
            this.NGBtn.UseVisualStyleBackColor = true;
            this.NGBtn.Click += new System.EventHandler(this.NewGamebtn);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(124, 346);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 28);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetbtnClicked);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(214, 346);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 28);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.Exitbtn);
            // 
            // Xwin
            // 
            this.Xwin.AutoSize = true;
            this.Xwin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xwin.Location = new System.Drawing.Point(49, 43);
            this.Xwin.Name = "Xwin";
            this.Xwin.Size = new System.Drawing.Size(0, 15);
            this.Xwin.TabIndex = 12;
            // 
            // Owin
            // 
            this.Owin.AutoSize = true;
            this.Owin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owin.Location = new System.Drawing.Point(134, 43);
            this.Owin.Name = "Owin";
            this.Owin.Size = new System.Drawing.Size(0, 15);
            this.Owin.TabIndex = 13;
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draws.Location = new System.Drawing.Point(229, 43);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(0, 15);
            this.Draws.TabIndex = 14;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 397);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.Owin);
            this.Controls.Add(this.Xwin);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.NGBtn);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A00);
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button NGBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Xwin;
        private System.Windows.Forms.Label Owin;
        private System.Windows.Forms.Label Draws;
    }
}

