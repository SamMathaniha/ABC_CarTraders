namespace CarTraders
{
    partial class ClientViewPartsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientViewPartsDetails));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button5 = new Button();
            button4 = new Button();
            dataGridView = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            CbbxBrand = new ComboBox();
            CbbxProduct = new ComboBox();
            CbbxCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button5.ForeColor = Color.Transparent;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(1058, 13);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(180, 55);
            button5.TabIndex = 21;
            button5.Text = "Back";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(964, 220);
            button4.Name = "button4";
            button4.Size = new Size(238, 55);
            button4.TabIndex = 65;
            button4.Text = "View All Parts";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(35, 307);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1167, 417);
            dataGridView.TabIndex = 64;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(577, 206);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 60;
            label4.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(309, 206);
            label3.Name = "label3";
            label3.Size = new Size(139, 31);
            label3.TabIndex = 59;
            label3.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(34, 206);
            label2.Name = "label2";
            label2.Size = new Size(164, 31);
            label2.TabIndex = 58;
            label2.Text = "Category";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(62, 90);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(353, 71);
            button1.TabIndex = 54;
            button1.Text = "Cars";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(421, 90);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(353, 71);
            button2.TabIndex = 55;
            button2.Text = "Spare Parts";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(780, 90);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(353, 71);
            button3.TabIndex = 56;
            button3.Text = "My Orders";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(button5);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 125);
            panel1.TabIndex = 57;
            // 
            // CbbxBrand
            // 
            CbbxBrand.BackColor = SystemColors.InactiveCaption;
            CbbxBrand.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CbbxBrand.FormattingEnabled = true;
            CbbxBrand.Location = new Point(577, 254);
            CbbxBrand.Name = "CbbxBrand";
            CbbxBrand.Size = new Size(229, 36);
            CbbxBrand.TabIndex = 68;
            // 
            // CbbxProduct
            // 
            CbbxProduct.BackColor = SystemColors.InactiveCaption;
            CbbxProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CbbxProduct.FormattingEnabled = true;
            CbbxProduct.Location = new Point(309, 254);
            CbbxProduct.Name = "CbbxProduct";
            CbbxProduct.Size = new Size(229, 36);
            CbbxProduct.TabIndex = 67;
            // 
            // CbbxCategory
            // 
            CbbxCategory.BackColor = SystemColors.InactiveCaption;
            CbbxCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CbbxCategory.FormattingEnabled = true;
            CbbxCategory.Location = new Point(37, 254);
            CbbxCategory.Name = "CbbxCategory";
            CbbxCategory.Size = new Size(229, 36);
            CbbxCategory.TabIndex = 66;
            // 
            // ClientViewPartsDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1253, 759);
            Controls.Add(CbbxBrand);
            Controls.Add(CbbxProduct);
            Controls.Add(CbbxCategory);
            Controls.Add(button4);
            Controls.Add(dataGridView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientViewPartsDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientViewPartsDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private DataGridView dataGridView;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private ComboBox CbbxBrand;
        private ComboBox CbbxProduct;
        private ComboBox CbbxCategory;
    }
}