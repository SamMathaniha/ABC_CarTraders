namespace CarTraders
{
    partial class ForgotPassword
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
            label1 = new Label();
            txtbxNICForPw = new TextBox();
            txtbxPhoneNoForPw = new TextBox();
            label2 = new Label();
            btnSubmitForPw = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 200);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 0;
            label1.Text = "NIC";
            // 
            // txtbxNICForPw
            // 
            txtbxNICForPw.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            txtbxNICForPw.Location = new Point(301, 200);
            txtbxNICForPw.Name = "txtbxNICForPw";
            txtbxNICForPw.Size = new Size(310, 31);
            txtbxNICForPw.TabIndex = 1;
            // 
            // txtbxPhoneNoForPw
            // 
            txtbxPhoneNoForPw.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            txtbxPhoneNoForPw.Location = new Point(301, 252);
            txtbxPhoneNoForPw.Name = "txtbxPhoneNoForPw";
            txtbxPhoneNoForPw.Size = new Size(310, 31);
            txtbxPhoneNoForPw.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(132, 255);
            label2.Name = "label2";
            label2.Size = new Size(157, 24);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // btnSubmitForPw
            // 
            btnSubmitForPw.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmitForPw.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnSubmitForPw.ForeColor = Color.White;
            btnSubmitForPw.Location = new Point(216, 321);
            btnSubmitForPw.Name = "btnSubmitForPw";
            btnSubmitForPw.Size = new Size(305, 49);
            btnSubmitForPw.TabIndex = 5;
            btnSubmitForPw.Text = "Submit";
            btnSubmitForPw.UseVisualStyleBackColor = false;
            btnSubmitForPw.Click += btnSubmitForPw_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 418);
            button1.Name = "button1";
            button1.Size = new Size(170, 37);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 109);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(125, 20);
            label7.Name = "label7";
            label7.Size = new Size(502, 65);
            label7.TabIndex = 0;
            label7.Text = "FORGOT PASSWORD";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(777, 476);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSubmitForPw);
            Controls.Add(txtbxPhoneNoForPw);
            Controls.Add(label2);
            Controls.Add(txtbxNICForPw);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbxNICForPw;
        private TextBox txtbxPhoneNoForPw;
        private Label label2;
        private Button btnSubmitForPw;
        private Button button1;
        private Panel panel1;
        private Label label7;
    }
}