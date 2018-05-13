namespace Fool_Game
{
    partial class Fool_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.Yesbtn = new System.Windows.Forms.Button();
            this.Nobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you a Fool?";
            // 
            // Yesbtn
            // 
            this.Yesbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesbtn.Location = new System.Drawing.Point(138, 295);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(75, 41);
            this.Yesbtn.TabIndex = 1;
            this.Yesbtn.Text = "Yes!";
            this.Yesbtn.UseVisualStyleBackColor = true;
            this.Yesbtn.Click += new System.EventHandler(this.YesbtnClicked);
            // 
            // Nobtn
            // 
            this.Nobtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nobtn.Location = new System.Drawing.Point(255, 295);
            this.Nobtn.Name = "Nobtn";
            this.Nobtn.Size = new System.Drawing.Size(75, 41);
            this.Nobtn.TabIndex = 2;
            this.Nobtn.Text = "No!";
            this.Nobtn.UseVisualStyleBackColor = true;
            this.Nobtn.Click += new System.EventHandler(this.NobtnClicked);
            this.Nobtn.MouseEnter += new System.EventHandler(this.NobtnEntered);
            // 
            // Fool_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Nobtn);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.label1);
            this.Name = "Fool_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fool Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yesbtn;
        private System.Windows.Forms.Button Nobtn;
    }
}

