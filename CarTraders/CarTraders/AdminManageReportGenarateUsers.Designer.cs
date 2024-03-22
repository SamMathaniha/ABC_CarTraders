namespace CarTraders
{
    partial class AdminManageReportGenarateUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageReportGenarateUsers));
            label1 = new Label();
            dataGridView = new DataGridView();
            LabelTotalUsers = new Label();
            button5 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(355, 39);
            label1.Name = "label1";
            label1.Size = new Size(121, 46);
            label1.TabIndex = 61;
            label1.Text = "Users";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.LavenderBlush;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(34, 118);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(850, 466);
            dataGridView.TabIndex = 62;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // LabelTotalUsers
            // 
            LabelTotalUsers.AutoSize = true;
            LabelTotalUsers.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            LabelTotalUsers.Location = new Point(34, 622);
            LabelTotalUsers.Name = "LabelTotalUsers";
            LabelTotalUsers.Size = new Size(138, 25);
            LabelTotalUsers.TabIndex = 63;
            LabelTotalUsers.Text = "Total Users :";
            LabelTotalUsers.Click += LabelTotalUsers_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(666, 604);
            button5.Name = "button5";
            button5.Size = new Size(218, 52);
            button5.TabIndex = 64;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(744, 12);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(140, 47);
            button3.TabIndex = 78;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AdminManageReportGenarateUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(906, 746);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(LabelTotalUsers);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageReportGenarateUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageReportGenarateUsers";
            Load += AdminManageReportGenarateUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView;
        private Label LabelTotalUsers;
        private Button button5;
        private Button button3;
    }
}