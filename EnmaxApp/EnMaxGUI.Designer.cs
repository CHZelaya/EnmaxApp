
namespace EnmaxApp
{
    partial class EnMaxGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnMaxGUI));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ListBox_DisplayInfo = new ListBox();
            TextBox_FName = new TextBox();
            TextBox_LName = new TextBox();
            TextBox_Kwh = new TextBox();
            TextBox_AccountNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Button_AddCustomer = new Button();
            Button_DisplayData = new Button();
            TextBox_TotalDue = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 55);
            label1.Name = "label1";
            label1.Size = new Size(278, 39);
            label1.TabIndex = 1;
            label1.Text = "Enmax Dashboard";
            // 
            // ListBox_DisplayInfo
            // 
            ListBox_DisplayInfo.FormattingEnabled = true;
            ListBox_DisplayInfo.Location = new Point(283, 116);
            ListBox_DisplayInfo.Name = "ListBox_DisplayInfo";
            ListBox_DisplayInfo.Size = new Size(388, 104);
            ListBox_DisplayInfo.TabIndex = 2;
            ListBox_DisplayInfo.SelectedIndexChanged += ListBox_DisplayInfo_SelectedIndexChanged;
            // 
            // TextBox_FName
            // 
            TextBox_FName.Location = new Point(283, 265);
            TextBox_FName.Name = "TextBox_FName";
            TextBox_FName.Size = new Size(176, 27);
            TextBox_FName.TabIndex = 3;
            // 
            // TextBox_LName
            // 
            TextBox_LName.Location = new Point(283, 322);
            TextBox_LName.Name = "TextBox_LName";
            TextBox_LName.Size = new Size(176, 27);
            TextBox_LName.TabIndex = 4;
            // 
            // TextBox_Kwh
            // 
            TextBox_Kwh.Location = new Point(503, 265);
            TextBox_Kwh.Name = "TextBox_Kwh";
            TextBox_Kwh.Size = new Size(168, 27);
            TextBox_Kwh.TabIndex = 5;
            // 
            // TextBox_AccountNo
            // 
            TextBox_AccountNo.Location = new Point(503, 322);
            TextBox_AccountNo.Name = "TextBox_AccountNo";
            TextBox_AccountNo.Size = new Size(168, 27);
            TextBox_AccountNo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 242);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 299);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 242);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "kWh Used";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 299);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 10;
            label5.Text = "Account Number";
            // 
            // Button_AddCustomer
            // 
            Button_AddCustomer.Location = new Point(283, 444);
            Button_AddCustomer.Name = "Button_AddCustomer";
            Button_AddCustomer.Size = new Size(176, 29);
            Button_AddCustomer.TabIndex = 11;
            Button_AddCustomer.Text = "&Add Customer";
            Button_AddCustomer.UseVisualStyleBackColor = true;
            Button_AddCustomer.Click += Button_AddCustomer_Click;
            // 
            // Button_DisplayData
            // 
            Button_DisplayData.Location = new Point(503, 444);
            Button_DisplayData.Name = "Button_DisplayData";
            Button_DisplayData.Size = new Size(168, 29);
            Button_DisplayData.TabIndex = 12;
            Button_DisplayData.Text = "&Display Data";
            Button_DisplayData.UseVisualStyleBackColor = true;
            Button_DisplayData.Click += Button_DisplayData_Click;
            // 
            // TextBox_TotalDue
            // 
            TextBox_TotalDue.Location = new Point(399, 375);
            TextBox_TotalDue.Name = "TextBox_TotalDue";
            TextBox_TotalDue.Size = new Size(168, 27);
            TextBox_TotalDue.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 352);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 14;
            label6.Text = "Total Due";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(371, 405);
            label7.Name = "label7";
            label7.Size = new Size(235, 17);
            label7.TabIndex = 15;
            label7.Text = "$0.07 per kWh + $12 Administration Fee";
            // 
            // EnMaxGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(754, 520);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TextBox_TotalDue);
            Controls.Add(Button_DisplayData);
            Controls.Add(Button_AddCustomer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBox_AccountNo);
            Controls.Add(TextBox_Kwh);
            Controls.Add(TextBox_LName);
            Controls.Add(TextBox_FName);
            Controls.Add(ListBox_DisplayInfo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EnMaxGUI";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ListBox ListBox_DisplayInfo;
        private TextBox TextBox_FName;
        private TextBox TextBox_LName;
        private TextBox TextBox_Kwh;
        private TextBox TextBox_AccountNo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Button_AddCustomer;
        private Button Button_DisplayData;
        private TextBox TextBox_TotalDue;
        private Label label6;
        private Label label7;
    }
}
