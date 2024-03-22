namespace CarTraders
{
    partial class AdminManageReportGenaratingDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageReportGenaratingDashBoard));
            label1 = new Label();
            button3 = new Button();
            BtnDelete = new Button();
            Payment = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 200);
            label1.Name = "label1";
            label1.Size = new Size(319, 43);
            label1.TabIndex = 60;
            label1.Text = "Genarate Report";
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1035, 22);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(140, 47);
            button3.TabIndex = 77;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Maroon;
            BtnDelete.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.ForeColor = Color.GhostWhite;
            BtnDelete.Location = new Point(810, 333);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(313, 82);
            BtnDelete.TabIndex = 84;
            BtnDelete.Text = "Users";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Payment
            // 
            Payment.BackColor = Color.Maroon;
            Payment.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Payment.ForeColor = Color.GhostWhite;
            Payment.Location = new Point(68, 333);
            Payment.Name = "Payment";
            Payment.Size = new Size(313, 82);
            Payment.TabIndex = 85;
            Payment.Text = "Payment";
            Payment.UseVisualStyleBackColor = false;
            Payment.Click += Payment_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.GhostWhite;
            button2.Location = new Point(444, 333);
            button2.Name = "button2";
            button2.Size = new Size(313, 82);
            button2.TabIndex = 86;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.GhostWhite;
            button4.Location = new Point(605, 493);
            button4.Name = "button4";
            button4.Size = new Size(313, 82);
            button4.TabIndex = 87;
            button4.Text = "Car Parts";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.GhostWhite;
            button5.Location = new Point(228, 493);
            button5.Name = "button5";
            button5.Size = new Size(313, 82);
            button5.TabIndex = 88;
            button5.Text = "Cars";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Monotype Corsiva", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(327, 64);
            label2.Name = "label2";
            label2.Size = new Size(527, 74);
            label2.TabIndex = 89;
            label2.Text = "ABC CAR TRADERS";
            // 
            // AdminManageReportGenaratingDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1206, 734);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(Payment);
            Controls.Add(BtnDelete);
            Controls.Add(button3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageReportGenaratingDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageReportGenaratingDashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button BtnDelete;
        private Button Payment;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label2;
    }
}