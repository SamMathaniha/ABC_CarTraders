namespace CarTraders
{
    partial class FrmLoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPage));
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtbxNIC = new TextBox();
            txtbxPwd = new TextBox();
            ChbxShowPwd = new CheckBox();
            panel1 = new Panel();
            button3 = new Button();
            label3 = new Label();
            RegisterPage = new Label();
            LbForgotPwd = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(181, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(347, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(181, 156);
            label1.Name = "label1";
            label1.Size = new Size(70, 33);
            label1.TabIndex = 2;
            label1.Text = "NIC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 261);
            label2.Name = "label2";
            label2.Size = new Size(148, 33);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtbxNIC
            // 
            txtbxNIC.Font = new Font("Segoe UI", 12F);
            txtbxNIC.Location = new Point(181, 201);
            txtbxNIC.Multiline = true;
            txtbxNIC.Name = "txtbxNIC";
            txtbxNIC.Size = new Size(347, 33);
            txtbxNIC.TabIndex = 4;
            // 
            // txtbxPwd
            // 
            txtbxPwd.Font = new Font("Segoe UI", 12F);
            txtbxPwd.Location = new Point(181, 308);
            txtbxPwd.Multiline = true;
            txtbxPwd.Name = "txtbxPwd";
            txtbxPwd.PasswordChar = '*';
            txtbxPwd.Size = new Size(347, 33);
            txtbxPwd.TabIndex = 5;
            // 
            // ChbxShowPwd
            // 
            ChbxShowPwd.AutoSize = true;
            ChbxShowPwd.Cursor = Cursors.Hand;
            ChbxShowPwd.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChbxShowPwd.ForeColor = Color.White;
            ChbxShowPwd.Location = new Point(181, 358);
            ChbxShowPwd.Name = "ChbxShowPwd";
            ChbxShowPwd.Size = new Size(161, 24);
            ChbxShowPwd.TabIndex = 7;
            ChbxShowPwd.Text = "Show Password";
            ChbxShowPwd.UseVisualStyleBackColor = true;
            ChbxShowPwd.CheckedChanged += ChbxShowPwd_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 105);
            panel1.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(649, 13);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(57, 47);
            button3.TabIndex = 104;
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(183, 21);
            label3.Name = "label3";
            label3.Size = new Size(325, 65);
            label3.TabIndex = 0;
            label3.Text = "USER LOGIN";
            // 
            // RegisterPage
            // 
            RegisterPage.AutoSize = true;
            RegisterPage.BackColor = Color.Transparent;
            RegisterPage.Cursor = Cursors.Hand;
            RegisterPage.Font = new Font("Rockwell", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            RegisterPage.ForeColor = Color.FromArgb(128, 255, 255);
            RegisterPage.Location = new Point(207, 515);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Size = new Size(286, 22);
            RegisterPage.TabIndex = 9;
            RegisterPage.Text = "Don't Have an Account? SignUP";
            RegisterPage.Click += RegisterPage_Click;
            RegisterPage.MouseClick += label4_Click;
            // 
            // LbForgotPwd
            // 
            LbForgotPwd.AutoSize = true;
            LbForgotPwd.BackColor = Color.Transparent;
            LbForgotPwd.Cursor = Cursors.Hand;
            LbForgotPwd.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbForgotPwd.ForeColor = Color.Blue;
            LbForgotPwd.Location = new Point(367, 358);
            LbForgotPwd.Name = "LbForgotPwd";
            LbForgotPwd.Size = new Size(161, 20);
            LbForgotPwd.TabIndex = 6;
            LbForgotPwd.Text = "Forgot Password?";
            LbForgotPwd.Click += LbForgotPwd_Click;
            // 
            // FrmLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(716, 591);
            Controls.Add(RegisterPage);
            Controls.Add(panel1);
            Controls.Add(ChbxShowPwd);
            Controls.Add(LbForgotPwd);
            Controls.Add(txtbxPwd);
            Controls.Add(txtbxNIC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtbxNIC;
        private TextBox txtbxPwd;
        private CheckBox ChbxShowPwd;
        private Panel panel1;
        private Label label3;
        private Label RegisterPage;
        private Label LbForgotPwd;
        private Button button3;
    }
}
