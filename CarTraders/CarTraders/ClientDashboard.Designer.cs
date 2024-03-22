namespace CarTraders
{
    partial class ClientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            labelCarCount = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            labelPartsCount = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            labelUserCount = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(106, 340);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(353, 71);
            button1.TabIndex = 17;
            button1.Text = "Cars";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(474, 340);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(353, 71);
            button2.TabIndex = 18;
            button2.Text = "Spare Parts";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(833, 340);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(353, 71);
            button3.TabIndex = 19;
            button3.Text = "My Orders";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button5.ForeColor = Color.Transparent;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(1125, 26);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(180, 55);
            button5.TabIndex = 21;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Transparent;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(12, 26);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(180, 55);
            button4.TabIndex = 22;
            button4.Text = "My Profile";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(0, -7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1321, 385);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 36F, FontStyle.Bold);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(325, 444);
            label2.Name = "label2";
            label2.Size = new Size(661, 71);
            label2.TabIndex = 25;
            label2.Text = "Name with Welcome";
            label2.Click += label2_Click;
            // 
            // labelCarCount
            // 
            labelCarCount.AutoSize = true;
            labelCarCount.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarCount.ForeColor = Color.White;
            labelCarCount.Location = new Point(266, 714);
            labelCarCount.Name = "labelCarCount";
            labelCarCount.Size = new Size(45, 33);
            labelCarCount.TabIndex = 47;
            labelCarCount.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(266, 669);
            label1.Name = "label1";
            label1.Size = new Size(57, 24);
            label1.TabIndex = 46;
            label1.Text = "Cars";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(184, 518);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(237, 186);
            pictureBox5.TabIndex = 45;
            pictureBox5.TabStop = false;
            // 
            // labelPartsCount
            // 
            labelPartsCount.AutoSize = true;
            labelPartsCount.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPartsCount.ForeColor = Color.White;
            labelPartsCount.Location = new Point(663, 715);
            labelPartsCount.Name = "labelPartsCount";
            labelPartsCount.Size = new Size(45, 33);
            labelPartsCount.TabIndex = 50;
            labelPartsCount.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(629, 669);
            label3.Name = "label3";
            label3.Size = new Size(122, 24);
            label3.TabIndex = 49;
            label3.Text = "Spare Parts";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(572, 518);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(237, 186);
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // labelUserCount
            // 
            labelUserCount.AutoSize = true;
            labelUserCount.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserCount.ForeColor = Color.White;
            labelUserCount.Location = new Point(1010, 716);
            labelUserCount.Name = "labelUserCount";
            labelUserCount.Size = new Size(45, 33);
            labelUserCount.TabIndex = 53;
            labelUserCount.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(968, 669);
            label6.Name = "label6";
            label6.Size = new Size(139, 24);
            label6.TabIndex = 52;
            label6.Text = "System Users";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(913, 518);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 186);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // ClientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1317, 769);
            Controls.Add(labelUserCount);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(labelPartsCount);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(labelCarCount);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientDashboard";
            Load += ClientDashboard_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private GroupBox groupBox1;
        private Label label2;
        private Label labelCarCount;
        private Label label1;
        private PictureBox pictureBox5;
        private Label labelPartsCount;
        private Label label3;
        private PictureBox pictureBox3;
        private Label labelUserCount;
        private Label label6;
        private PictureBox pictureBox2;
    }
}