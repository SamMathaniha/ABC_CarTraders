namespace CarTraders
{
    partial class AdminManageReportGenarateOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageReportGenarateOrders));
            btnLoadBetweenDate = new Button();
            label4 = new Label();
            btnClose = new Button();
            btnPrint = new Button();
            LabelTotalRecords = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnLoadBetweenDate
            // 
            btnLoadBetweenDate.BackColor = Color.FromArgb(0, 192, 0);
            btnLoadBetweenDate.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadBetweenDate.ForeColor = SystemColors.ButtonFace;
            btnLoadBetweenDate.Location = new Point(828, 148);
            btnLoadBetweenDate.Name = "btnLoadBetweenDate";
            btnLoadBetweenDate.Size = new Size(166, 38);
            btnLoadBetweenDate.TabIndex = 93;
            btnLoadBetweenDate.Text = "Load";
            btnLoadBetweenDate.UseVisualStyleBackColor = false;
            btnLoadBetweenDate.Click += btnLoadBetweenDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(452, 158);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 92;
            label4.Text = "To Date";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(854, 32);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(10, 0, 0, 0);
            btnClose.Size = new Size(140, 47);
            btnClose.TabIndex = 91;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button3_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.RoyalBlue;
            btnPrint.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = SystemColors.ButtonFace;
            btnPrint.Location = new Point(776, 600);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(218, 50);
            btnPrint.TabIndex = 90;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // LabelTotalRecords
            // 
            LabelTotalRecords.AutoSize = true;
            LabelTotalRecords.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            LabelTotalRecords.Location = new Point(51, 612);
            LabelTotalRecords.Name = "LabelTotalRecords";
            LabelTotalRecords.Size = new Size(165, 25);
            LabelTotalRecords.TabIndex = 89;
            LabelTotalRecords.Text = "Total Records :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(404, 62);
            label3.Name = "label3";
            label3.Size = new Size(149, 46);
            label3.TabIndex = 88;
            label3.Text = "Orders";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.LavenderBlush;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(51, 201);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(943, 393);
            dataGridView.TabIndex = 87;
            // 
            // dtTo
            // 
            dtTo.CalendarFont = new Font("Rockwell", 10.2F, FontStyle.Bold);
            dtTo.Location = new Point(550, 153);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 86;
            // 
            // dtFrom
            // 
            dtFrom.CalendarFont = new Font("Rockwell", 10.2F, FontStyle.Bold);
            dtFrom.Location = new Point(162, 153);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(51, 158);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 84;
            label1.Text = "From Date";
            // 
            // AdminManageReportGenarateOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 684);
            Controls.Add(btnLoadBetweenDate);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(LabelTotalRecords);
            Controls.Add(label3);
            Controls.Add(dataGridView);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageReportGenarateOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageReportGenarateOrders";
            Load += AdminManageReportGenarateOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadBetweenDate;
        private Label label4;
        private Button btnClose;
        private Button btnPrint;
        private Label LabelTotalRecords;
        private Label label3;
        private DataGridView dataGridView;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Label label1;
    }
}