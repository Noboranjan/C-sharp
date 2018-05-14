namespace BookShopApplication
{
    partial class Home
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.bookGridView = new System.Windows.Forms.DataGridView();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.loadBookBtn = new System.Windows.Forms.Button();
            this.insertBookBtn = new System.Windows.Forms.Button();
            this.updateBookBtn = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.searchBookTBox = new System.Windows.Forms.TextBox();
            this.searchEmpTBox = new System.Windows.Forms.TextBox();
            this.searchEmpBtn = new System.Windows.Forms.Button();
            this.deleteEmpBtn = new System.Windows.Forms.Button();
            this.updateEmpBtn = new System.Windows.Forms.Button();
            this.insertEmpBtn = new System.Windows.Forms.Button();
            this.loadEmpBtn = new System.Windows.Forms.Button();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(77, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(52, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // bookGridView
            // 
            this.bookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGridView.Location = new System.Drawing.Point(388, 13);
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.Size = new System.Drawing.Size(507, 150);
            this.bookGridView.TabIndex = 1;
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(388, 230);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.Size = new System.Drawing.Size(507, 150);
            this.employeeGridView.TabIndex = 2;
            // 
            // loadBookBtn
            // 
            this.loadBookBtn.Location = new System.Drawing.Point(388, 183);
            this.loadBookBtn.Name = "loadBookBtn";
            this.loadBookBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBookBtn.TabIndex = 3;
            this.loadBookBtn.Text = "Load";
            this.loadBookBtn.UseVisualStyleBackColor = true;
            this.loadBookBtn.Click += new System.EventHandler(this.LoadBookBtnClicked);
            // 
            // insertBookBtn
            // 
            this.insertBookBtn.Location = new System.Drawing.Point(469, 183);
            this.insertBookBtn.Name = "insertBookBtn";
            this.insertBookBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBookBtn.TabIndex = 4;
            this.insertBookBtn.Text = "Insert";
            this.insertBookBtn.UseVisualStyleBackColor = true;
            this.insertBookBtn.Click += new System.EventHandler(this.InsertBookBtnClicked);
            // 
            // updateBookBtn
            // 
            this.updateBookBtn.Location = new System.Drawing.Point(550, 183);
            this.updateBookBtn.Name = "updateBookBtn";
            this.updateBookBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBookBtn.TabIndex = 5;
            this.updateBookBtn.Text = "Update";
            this.updateBookBtn.UseVisualStyleBackColor = true;
            this.updateBookBtn.Click += new System.EventHandler(this.UpdateBookBtnClicked);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Location = new System.Drawing.Point(631, 183);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBookBtn.TabIndex = 6;
            this.deleteBookBtn.Text = "Delete";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtnCLicked);
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.Location = new System.Drawing.Point(820, 183);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBookBtn.TabIndex = 7;
            this.searchBookBtn.Text = "Search";
            this.searchBookBtn.UseVisualStyleBackColor = true;
            this.searchBookBtn.Click += new System.EventHandler(this.SearchBookBtnClicked);
            // 
            // searchBookTBox
            // 
            this.searchBookTBox.Location = new System.Drawing.Point(714, 185);
            this.searchBookTBox.Name = "searchBookTBox";
            this.searchBookTBox.Size = new System.Drawing.Size(100, 20);
            this.searchBookTBox.TabIndex = 8;
            // 
            // searchEmpTBox
            // 
            this.searchEmpTBox.Location = new System.Drawing.Point(714, 403);
            this.searchEmpTBox.Name = "searchEmpTBox";
            this.searchEmpTBox.Size = new System.Drawing.Size(100, 20);
            this.searchEmpTBox.TabIndex = 14;
            // 
            // searchEmpBtn
            // 
            this.searchEmpBtn.Location = new System.Drawing.Point(820, 401);
            this.searchEmpBtn.Name = "searchEmpBtn";
            this.searchEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.searchEmpBtn.TabIndex = 13;
            this.searchEmpBtn.Text = "Search";
            this.searchEmpBtn.UseVisualStyleBackColor = true;
            // 
            // deleteEmpBtn
            // 
            this.deleteEmpBtn.Location = new System.Drawing.Point(631, 401);
            this.deleteEmpBtn.Name = "deleteEmpBtn";
            this.deleteEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteEmpBtn.TabIndex = 12;
            this.deleteEmpBtn.Text = "Delete";
            this.deleteEmpBtn.UseVisualStyleBackColor = true;
            // 
            // updateEmpBtn
            // 
            this.updateEmpBtn.Location = new System.Drawing.Point(550, 401);
            this.updateEmpBtn.Name = "updateEmpBtn";
            this.updateEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.updateEmpBtn.TabIndex = 11;
            this.updateEmpBtn.Text = "Update";
            this.updateEmpBtn.UseVisualStyleBackColor = true;
            // 
            // insertEmpBtn
            // 
            this.insertEmpBtn.Location = new System.Drawing.Point(469, 401);
            this.insertEmpBtn.Name = "insertEmpBtn";
            this.insertEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.insertEmpBtn.TabIndex = 10;
            this.insertEmpBtn.Text = "Insert";
            this.insertEmpBtn.UseVisualStyleBackColor = true;
            // 
            // loadEmpBtn
            // 
            this.loadEmpBtn.Location = new System.Drawing.Point(388, 401);
            this.loadEmpBtn.Name = "loadEmpBtn";
            this.loadEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.loadEmpBtn.TabIndex = 9;
            this.loadEmpBtn.Text = "Load";
            this.loadEmpBtn.UseVisualStyleBackColor = true;
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(80, 57);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(133, 23);
            this.changePassBtn.TabIndex = 15;
            this.changePassBtn.Text = "Change Password";
            this.changePassBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(80, 105);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(133, 23);
            this.logoutBtn.TabIndex = 16;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtnClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 297);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 461);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.searchEmpTBox);
            this.Controls.Add(this.searchEmpBtn);
            this.Controls.Add(this.deleteEmpBtn);
            this.Controls.Add(this.updateEmpBtn);
            this.Controls.Add(this.insertEmpBtn);
            this.Controls.Add(this.loadEmpBtn);
            this.Controls.Add(this.searchBookTBox);
            this.Controls.Add(this.searchBookBtn);
            this.Controls.Add(this.deleteBookBtn);
            this.Controls.Add(this.updateBookBtn);
            this.Controls.Add(this.insertBookBtn);
            this.Controls.Add(this.loadBookBtn);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.bookGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridView bookGridView;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Button loadBookBtn;
        private System.Windows.Forms.Button insertBookBtn;
        private System.Windows.Forms.Button updateBookBtn;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button searchBookBtn;
        private System.Windows.Forms.TextBox searchBookTBox;
        private System.Windows.Forms.TextBox searchEmpTBox;
        private System.Windows.Forms.Button searchEmpBtn;
        private System.Windows.Forms.Button deleteEmpBtn;
        private System.Windows.Forms.Button updateEmpBtn;
        private System.Windows.Forms.Button insertEmpBtn;
        private System.Windows.Forms.Button loadEmpBtn;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}