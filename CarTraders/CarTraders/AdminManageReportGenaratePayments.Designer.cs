namespace CarTraders
{
    partial class AdminManageReportGenaratePayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageReportGenaratePayments));
            label1 = new Label();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            dataGridView = new DataGridView();
            label3 = new Label();
            button5 = new Button();
            LabelTotalRecords = new Label();
            button3 = new Button();
            label4 = new Label();
            btnLoadBetweenDate = new Button();
            label2 = new Label();
            txtbxTotalAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(39, 130);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "From Date";
            // 
            // dtFrom
            // 
            dtFrom.CalendarFont = new Font("Rockwell", 10.2F, FontStyle.Bold);
            dtFrom.Location = new Point(150, 125);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 2;
            // 
            // dtTo
            // 
            dtTo.CalendarFont = new Font("Rockwell", 10.2F, FontStyle.Bold);
            dtTo.Location = new Point(538, 125);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.LavenderBlush;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(39, 173);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(943, 393);
            dataGridView.TabIndex = 63;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(390, 50);
            label3.Name = "label3";
            label3.Size = new Size(202, 46);
            label3.TabIndex = 64;
            label3.Text = "Payments";
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(764, 572);
            button5.Name = "button5";
            button5.Size = new Size(218, 50);
            button5.TabIndex = 66;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // LabelTotalRecords
            // 
            LabelTotalRecords.AutoSize = true;
            LabelTotalRecords.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            LabelTotalRecords.Location = new Point(39, 584);
            LabelTotalRecords.Name = "LabelTotalRecords";
            LabelTotalRecords.Size = new Size(165, 25);
            LabelTotalRecords.TabIndex = 65;
            LabelTotalRecords.Text = "Total Records :";
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(866, 12);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(140, 47);
            button3.TabIndex = 79;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(440, 130);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 80;
            label4.Text = "To Date";
            // 
            // btnLoadBetweenDate
            // 
            btnLoadBetweenDate.BackColor = Color.FromArgb(0, 192, 0);
            btnLoadBetweenDate.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadBetweenDate.ForeColor = SystemColors.ButtonFace;
            btnLoadBetweenDate.Location = new Point(816, 120);
            btnLoadBetweenDate.Name = "btnLoadBetweenDate";
            btnLoadBetweenDate.Size = new Size(166, 38);
            btnLoadBetweenDate.TabIndex = 81;
            btnLoadBetweenDate.Text = "Load";
            btnLoadBetweenDate.UseVisualStyleBackColor = false;
            btnLoadBetweenDate.Click += btnLoadBetweenDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(273, 633);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 82;
            label2.Text = "Total Amount :";
            // 
            // txtbxTotalAmount
            // 
            txtbxTotalAmount.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbxTotalAmount.Location = new Point(451, 633);
            txtbxTotalAmount.Name = "txtbxTotalAmount";
            txtbxTotalAmount.Size = new Size(225, 27);
            txtbxTotalAmount.TabIndex = 83;
            txtbxTotalAmount.TextChanged += txtbxTotalAmount_TextChanged;
            // 
            // AdminManageReportGenaratePayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 711);
            Controls.Add(txtbxTotalAmount);
            Controls.Add(label2);
            Controls.Add(btnLoadBetweenDate);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(LabelTotalRecords);
            Controls.Add(label3);
            Controls.Add(dataGridView);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageReportGenaratePayments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageReportGenaratePayments";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private DataGridView dataGridView;
        private Label label3;
        private Button button5;
        private Label LabelTotalRecords;
        private Button button3;
        private Label label4;
        private Button btnLoadBetweenDate;
        private Label label2;
        private TextBox txtbxTotalAmount;
    }
}