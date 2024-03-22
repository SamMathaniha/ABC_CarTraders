namespace CarTraders
{
    partial class ForgotPasswordUpdatePw
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
            btnUpdateConfirmPw = new Button();
            label1 = new Label();
            label2 = new Label();
            txtbxUpdateNewPw = new TextBox();
            txtbxUpdateConfirmPw = new TextBox();
            btnBack = new Button();
            label4 = new Label();
            txtbxNIC = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateConfirmPw
            // 
            btnUpdateConfirmPw.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdateConfirmPw.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnUpdateConfirmPw.ForeColor = Color.White;
            btnUpdateConfirmPw.Location = new Point(256, 324);
            btnUpdateConfirmPw.Name = "btnUpdateConfirmPw";
            btnUpdateConfirmPw.Size = new Size(291, 46);
            btnUpdateConfirmPw.TabIndex = 6;
            btnUpdateConfirmPw.Text = "Submit";
            btnUpdateConfirmPw.UseVisualStyleBackColor = false;
            btnUpdateConfirmPw.Click += btnUpdateConfirmPw_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 217);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 7;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(147, 266);
            label2.Name = "label2";
            label2.Size = new Size(191, 24);
            label2.TabIndex = 8;
            label2.Text = "Confirm password";
            // 
            // txtbxUpdateNewPw
            // 
            txtbxUpdateNewPw.Location = new Point(342, 214);
            txtbxUpdateNewPw.Name = "txtbxUpdateNewPw";
            txtbxUpdateNewPw.PasswordChar = '*';
            txtbxUpdateNewPw.Size = new Size(293, 27);
            txtbxUpdateNewPw.TabIndex = 9;
            // 
            // txtbxUpdateConfirmPw
            // 
            txtbxUpdateConfirmPw.Location = new Point(342, 266);
            txtbxUpdateConfirmPw.Name = "txtbxUpdateConfirmPw";
            txtbxUpdateConfirmPw.PasswordChar = '*';
            txtbxUpdateConfirmPw.Size = new Size(293, 27);
            txtbxUpdateConfirmPw.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 40);
            btnBack.TabIndex = 11;
            btnBack.Text = "Exit";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(147, 170);
            label4.Name = "label4";
            label4.Size = new Size(50, 24);
            label4.TabIndex = 12;
            label4.Text = "NIC";
            // 
            // txtbxNIC
            // 
            txtbxNIC.Location = new Point(342, 167);
            txtbxNIC.Name = "txtbxNIC";
            txtbxNIC.ReadOnly = true;
            txtbxNIC.Size = new Size(293, 27);
            txtbxNIC.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 109);
            panel1.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(145, 21);
            label7.Name = "label7";
            label7.Size = new Size(501, 65);
            label7.TabIndex = 0;
            label7.Text = "UPDATE PASSWORD";
            // 
            // ForgotPasswordUpdatePw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(txtbxNIC);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(txtbxUpdateConfirmPw);
            Controls.Add(txtbxUpdateNewPw);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateConfirmPw);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordUpdatePw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordUpdatePw";
            Load += ForgotPasswordUpdatePw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdateConfirmPw;
        private Label label1;
        private Label label2;
        private TextBox txtbxUpdateNewPw;
        private TextBox txtbxUpdateConfirmPw;
        private Button btnBack;
        private Label label4;
        private TextBox txtbxNIC;
        private Panel panel1;
        private Label label7;
    }
}