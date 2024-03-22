namespace CarTraders
{
    partial class AdminManageOrderDetailsCheckform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageOrderDetailsCheckform));
            label1 = new Label();
            button3 = new Button();
            txtbxOrderID = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label13 = new Label();
            btnDoPayment = new Button();
            btnDeleteOrder = new Button();
            txtbxOrderDate = new TextBox();
            txtbxRegID = new TextBox();
            txtbxItem = new TextBox();
            txtbxType = new TextBox();
            txtbxPaymentStatus = new TextBox();
            txtbxAmount = new TextBox();
            txtbxNIC = new TextBox();
            txtbxDeleveryStatus = new TextBox();
            label9 = new Label();
            btnUpdateDeliveryStatus = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Rockwell Extra Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(244, 34);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 125;
            label1.Text = "Order Details";
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(634, 12);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(140, 47);
            button3.TabIndex = 123;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtbxOrderID
            // 
            txtbxOrderID.BackColor = Color.MintCream;
            txtbxOrderID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxOrderID.Location = new Point(120, 109);
            txtbxOrderID.Multiline = true;
            txtbxOrderID.Name = "txtbxOrderID";
            txtbxOrderID.ReadOnly = true;
            txtbxOrderID.Size = new Size(240, 34);
            txtbxOrderID.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label2.Location = new Point(20, 113);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 121;
            label2.Text = "Order ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label10.Location = new Point(396, 241);
            label10.Name = "label10";
            label10.Size = new Size(45, 22);
            label10.TabIndex = 112;
            label10.Text = "NIC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label8.Location = new Point(187, 427);
            label8.Name = "label8";
            label8.Size = new Size(147, 22);
            label8.TabIndex = 111;
            label8.Text = "Payment Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label7.Location = new Point(97, 332);
            label7.Name = "label7";
            label7.Size = new Size(143, 22);
            label7.TabIndex = 110;
            label7.Text = "Delivery Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label6.Location = new Point(20, 241);
            label6.Name = "label6";
            label6.Size = new Size(54, 22);
            label6.TabIndex = 109;
            label6.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label5.Location = new Point(187, 496);
            label5.Name = "label5";
            label5.Size = new Size(90, 22);
            label5.TabIndex = 108;
            label5.Text = "Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label4.Location = new Point(20, 179);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 107;
            label4.Text = "Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label3.Location = new Point(396, 179);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 106;
            label3.Text = "Reg_ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 10.8F, FontStyle.Bold);
            label13.Location = new Point(396, 113);
            label13.Name = "label13";
            label13.Size = new Size(108, 22);
            label13.TabIndex = 105;
            label13.Text = "Order Date";
            // 
            // btnDoPayment
            // 
            btnDoPayment.BackColor = Color.LimeGreen;
            btnDoPayment.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            btnDoPayment.ForeColor = SystemColors.ButtonHighlight;
            btnDoPayment.Location = new Point(108, 582);
            btnDoPayment.Name = "btnDoPayment";
            btnDoPayment.Size = new Size(299, 50);
            btnDoPayment.TabIndex = 124;
            btnDoPayment.Text = "Do Payment";
            btnDoPayment.UseVisualStyleBackColor = false;
            btnDoPayment.Click += btnDoPayment_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.Red;
            btnDeleteOrder.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            btnDeleteOrder.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteOrder.Location = new Point(430, 582);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(299, 50);
            btnDeleteOrder.TabIndex = 126;
            btnDeleteOrder.Text = "Delect Order";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += button1_Click;
            // 
            // txtbxOrderDate
            // 
            txtbxOrderDate.BackColor = Color.MintCream;
            txtbxOrderDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxOrderDate.Location = new Point(534, 113);
            txtbxOrderDate.Multiline = true;
            txtbxOrderDate.Name = "txtbxOrderDate";
            txtbxOrderDate.ReadOnly = true;
            txtbxOrderDate.Size = new Size(240, 34);
            txtbxOrderDate.TabIndex = 127;
            // 
            // txtbxRegID
            // 
            txtbxRegID.BackColor = Color.MintCream;
            txtbxRegID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxRegID.Location = new Point(534, 175);
            txtbxRegID.Multiline = true;
            txtbxRegID.Name = "txtbxRegID";
            txtbxRegID.ReadOnly = true;
            txtbxRegID.Size = new Size(240, 34);
            txtbxRegID.TabIndex = 128;
            // 
            // txtbxItem
            // 
            txtbxItem.BackColor = Color.MintCream;
            txtbxItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxItem.Location = new Point(120, 175);
            txtbxItem.Multiline = true;
            txtbxItem.Name = "txtbxItem";
            txtbxItem.ReadOnly = true;
            txtbxItem.Size = new Size(240, 34);
            txtbxItem.TabIndex = 129;
            // 
            // txtbxType
            // 
            txtbxType.BackColor = Color.MintCream;
            txtbxType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxType.Location = new Point(120, 237);
            txtbxType.Multiline = true;
            txtbxType.Name = "txtbxType";
            txtbxType.ReadOnly = true;
            txtbxType.Size = new Size(240, 34);
            txtbxType.TabIndex = 130;
            // 
            // txtbxPaymentStatus
            // 
            txtbxPaymentStatus.BackColor = Color.MintCream;
            txtbxPaymentStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxPaymentStatus.Location = new Point(372, 427);
            txtbxPaymentStatus.Multiline = true;
            txtbxPaymentStatus.Name = "txtbxPaymentStatus";
            txtbxPaymentStatus.ReadOnly = true;
            txtbxPaymentStatus.Size = new Size(220, 34);
            txtbxPaymentStatus.TabIndex = 131;
            // 
            // txtbxAmount
            // 
            txtbxAmount.BackColor = Color.MintCream;
            txtbxAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxAmount.Location = new Point(372, 490);
            txtbxAmount.Multiline = true;
            txtbxAmount.Name = "txtbxAmount";
            txtbxAmount.ReadOnly = true;
            txtbxAmount.Size = new Size(220, 34);
            txtbxAmount.TabIndex = 132;
            // 
            // txtbxNIC
            // 
            txtbxNIC.BackColor = Color.MintCream;
            txtbxNIC.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxNIC.Location = new Point(534, 237);
            txtbxNIC.Multiline = true;
            txtbxNIC.Name = "txtbxNIC";
            txtbxNIC.ReadOnly = true;
            txtbxNIC.Size = new Size(240, 34);
            txtbxNIC.TabIndex = 133;
            // 
            // txtbxDeleveryStatus
            // 
            txtbxDeleveryStatus.BackColor = Color.MintCream;
            txtbxDeleveryStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtbxDeleveryStatus.Location = new Point(251, 328);
            txtbxDeleveryStatus.Multiline = true;
            txtbxDeleveryStatus.Name = "txtbxDeleveryStatus";
            txtbxDeleveryStatus.ReadOnly = true;
            txtbxDeleveryStatus.Size = new Size(220, 34);
            txtbxDeleveryStatus.TabIndex = 134;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(309, 490);
            label9.Name = "label9";
            label9.Size = new Size(49, 28);
            label9.TabIndex = 135;
            label9.Text = "Rs.";
            // 
            // btnUpdateDeliveryStatus
            // 
            btnUpdateDeliveryStatus.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdateDeliveryStatus.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateDeliveryStatus.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateDeliveryStatus.Location = new Point(506, 328);
            btnUpdateDeliveryStatus.Name = "btnUpdateDeliveryStatus";
            btnUpdateDeliveryStatus.Size = new Size(241, 38);
            btnUpdateDeliveryStatus.TabIndex = 136;
            btnUpdateDeliveryStatus.Text = "Order Delivered";
            btnUpdateDeliveryStatus.UseVisualStyleBackColor = false;
            btnUpdateDeliveryStatus.Click += btnUpdateDeliveryStatus_Click;
            // 
            // AdminManageOrderDetailsCheckform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(823, 669);
            Controls.Add(btnUpdateDeliveryStatus);
            Controls.Add(label9);
            Controls.Add(txtbxDeleveryStatus);
            Controls.Add(txtbxNIC);
            Controls.Add(txtbxAmount);
            Controls.Add(txtbxPaymentStatus);
            Controls.Add(txtbxType);
            Controls.Add(txtbxItem);
            Controls.Add(txtbxRegID);
            Controls.Add(txtbxOrderDate);
            Controls.Add(btnDeleteOrder);
            Controls.Add(label1);
            Controls.Add(btnDoPayment);
            Controls.Add(button3);
            Controls.Add(txtbxOrderID);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageOrderDetailsCheckform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageOrderDetailsCheckform";
            Load += AdminManageOrderDetailsCheckform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private TextBox txtbxOrderID;
        private Label label2;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private Button btnDoPayment;
        private Button btnDeleteOrder;
        private TextBox txtbxOrderDate;
        private TextBox txtbxRegID;
        private TextBox txtbxItem;
        private TextBox txtbxType;
        private TextBox txtbxPaymentStatus;
        private TextBox txtbxAmount;
        private TextBox txtbxNIC;
        private TextBox txtbxDeleveryStatus;
        private Label label9;
        private Button btnUpdateDeliveryStatus;
    }
}