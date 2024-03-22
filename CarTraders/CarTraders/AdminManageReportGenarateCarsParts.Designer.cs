namespace CarTraders
{
    partial class AdminManageReportGenarateCarsParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageReportGenarateCarsParts));
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            LabelTotalRecords = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            CbbxBrand = new ComboBox();
            CbbxProduct = new ComboBox();
            CbbxCategory = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(832, 217);
            button1.Name = "button1";
            button1.Size = new Size(175, 44);
            button1.TabIndex = 110;
            button1.Text = "View All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(888, 36);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(140, 47);
            button3.TabIndex = 103;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(789, 666);
            button5.Name = "button5";
            button5.Size = new Size(218, 50);
            button5.TabIndex = 102;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // LabelTotalRecords
            // 
            LabelTotalRecords.AutoSize = true;
            LabelTotalRecords.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            LabelTotalRecords.Location = new Point(64, 678);
            LabelTotalRecords.Name = "LabelTotalRecords";
            LabelTotalRecords.Size = new Size(165, 25);
            LabelTotalRecords.TabIndex = 101;
            LabelTotalRecords.Text = "Total Records :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(391, 60);
            label3.Name = "label3";
            label3.Size = new Size(212, 46);
            label3.TabIndex = 100;
            label3.Text = "Cars Parts";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.LavenderBlush;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(64, 267);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(943, 393);
            dataGridView.TabIndex = 99;
            // 
            // CbbxBrand
            // 
            CbbxBrand.BackColor = SystemColors.InactiveCaption;
            CbbxBrand.FormattingEnabled = true;
            CbbxBrand.Location = new Point(572, 189);
            CbbxBrand.Name = "CbbxBrand";
            CbbxBrand.Size = new Size(203, 28);
            CbbxBrand.TabIndex = 116;
            // 
            // CbbxProduct
            // 
            CbbxProduct.BackColor = SystemColors.InactiveCaption;
            CbbxProduct.FormattingEnabled = true;
            CbbxProduct.Location = new Point(329, 189);
            CbbxProduct.Name = "CbbxProduct";
            CbbxProduct.Size = new Size(203, 28);
            CbbxProduct.TabIndex = 115;
            CbbxProduct.SelectedIndexChanged += CbbxProduct_SelectedIndexChanged;
            // 
            // CbbxCategory
            // 
            CbbxCategory.BackColor = SystemColors.InactiveCaption;
            CbbxCategory.FormattingEnabled = true;
            CbbxCategory.Location = new Point(64, 189);
            CbbxCategory.Name = "CbbxCategory";
            CbbxCategory.Size = new Size(203, 28);
            CbbxCategory.TabIndex = 114;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.Location = new Point(572, 148);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 113;
            label4.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.Location = new Point(329, 148);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 112;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.Location = new Point(64, 148);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 111;
            label2.Text = "Category";
            // 
            // AdminManageReportGenarateCarsParts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1076, 767);
            Controls.Add(CbbxBrand);
            Controls.Add(CbbxProduct);
            Controls.Add(CbbxCategory);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(LabelTotalRecords);
            Controls.Add(label3);
            Controls.Add(dataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageReportGenarateCarsParts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageReportGenarateCarsParts";
            Load += AdminManageReportGenarateCarsParts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button5;
        private Label LabelTotalRecords;
        private Label label3;
        private DataGridView dataGridView;
        private ComboBox CbbxBrand;
        private ComboBox CbbxProduct;
        private ComboBox CbbxCategory;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}