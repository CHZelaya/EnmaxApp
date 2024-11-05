
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
            label8 = new Label();
            TextBox_TotalCustomers = new TextBox();
            TextBox_Totalkwh = new TextBox();
            TextBox_AverageBill = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 642);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 28);
            label1.Name = "label1";
            label1.Size = new Size(435, 60);
            label1.TabIndex = 1;
            label1.Text = "Enmax Dashboard";
            // 
            // ListBox_DisplayInfo
            // 
            ListBox_DisplayInfo.FormattingEnabled = true;
            ListBox_DisplayInfo.Location = new Point(476, 410);
            ListBox_DisplayInfo.Name = "ListBox_DisplayInfo";
            ListBox_DisplayInfo.Size = new Size(414, 104);
            ListBox_DisplayInfo.TabIndex = 2;
            ListBox_DisplayInfo.SelectedIndexChanged += ListBox_DisplayInfo_SelectedIndexChanged;
            // 
            // TextBox_FName
            // 
            TextBox_FName.Location = new Point(479, 130);
            TextBox_FName.Name = "TextBox_FName";
            TextBox_FName.Size = new Size(168, 27);
            TextBox_FName.TabIndex = 3;
            TextBox_FName.Tag = "First Name";
            // 
            // TextBox_LName
            // 
            TextBox_LName.Location = new Point(706, 130);
            TextBox_LName.Name = "TextBox_LName";
            TextBox_LName.Size = new Size(176, 27);
            TextBox_LName.TabIndex = 4;
            TextBox_LName.Tag = "Last Name";
            // 
            // TextBox_Kwh
            // 
            TextBox_Kwh.Location = new Point(479, 183);
            TextBox_Kwh.Name = "TextBox_Kwh";
            TextBox_Kwh.Size = new Size(168, 27);
            TextBox_Kwh.TabIndex = 5;
            TextBox_Kwh.Tag = "kWh Used";
            // 
            // TextBox_AccountNo
            // 
            TextBox_AccountNo.Location = new Point(560, 339);
            TextBox_AccountNo.Name = "TextBox_AccountNo";
            TextBox_AccountNo.ReadOnly = true;
            TextBox_AccountNo.Size = new Size(46, 27);
            TextBox_AccountNo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 107);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(706, 107);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 160);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "kWh Used";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 316);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 10;
            label5.Text = "Account Number";
            // 
            // Button_AddCustomer
            // 
            Button_AddCustomer.Location = new Point(477, 234);
            Button_AddCustomer.Name = "Button_AddCustomer";
            Button_AddCustomer.Size = new Size(405, 29);
            Button_AddCustomer.TabIndex = 11;
            Button_AddCustomer.Text = "&Add Customer";
            Button_AddCustomer.UseVisualStyleBackColor = true;
            Button_AddCustomer.Click += Button_AddCustomer_Click;
            // 
            // Button_DisplayData
            // 
            Button_DisplayData.Location = new Point(477, 279);
            Button_DisplayData.Name = "Button_DisplayData";
            Button_DisplayData.Size = new Size(405, 29);
            Button_DisplayData.TabIndex = 12;
            Button_DisplayData.Text = "&Display Data";
            Button_DisplayData.UseVisualStyleBackColor = true;
            Button_DisplayData.Click += Button_DisplayData_Click;
            // 
            // TextBox_TotalDue
            // 
            TextBox_TotalDue.Location = new Point(735, 339);
            TextBox_TotalDue.Name = "TextBox_TotalDue";
            TextBox_TotalDue.ReadOnly = true;
            TextBox_TotalDue.Size = new Size(60, 27);
            TextBox_TotalDue.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(722, 316);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 14;
            label6.Text = "Total Due";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(560, 369);
            label7.Name = "label7";
            label7.Size = new Size(235, 17);
            label7.TabIndex = 15;
            label7.Text = "$0.07 per kWh + $12 Administration Fee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(482, 390);
            label8.Name = "label8";
            label8.Size = new Size(367, 17);
            label8.TabIndex = 16;
            label8.Text = "Select a Customer to display the Account Number and Total Due";
            // 
            // TextBox_TotalCustomers
            // 
            TextBox_TotalCustomers.Location = new Point(479, 542);
            TextBox_TotalCustomers.Name = "TextBox_TotalCustomers";
            TextBox_TotalCustomers.ReadOnly = true;
            TextBox_TotalCustomers.Size = new Size(80, 27);
            TextBox_TotalCustomers.TabIndex = 17;
            // 
            // TextBox_Totalkwh
            // 
            TextBox_Totalkwh.Location = new Point(664, 542);
            TextBox_Totalkwh.Name = "TextBox_Totalkwh";
            TextBox_Totalkwh.ReadOnly = true;
            TextBox_Totalkwh.Size = new Size(79, 27);
            TextBox_Totalkwh.TabIndex = 18;
            // 
            // TextBox_AverageBill
            // 
            TextBox_AverageBill.Location = new Point(846, 542);
            TextBox_AverageBill.Name = "TextBox_AverageBill";
            TextBox_AverageBill.ReadOnly = true;
            TextBox_AverageBill.Size = new Size(80, 27);
            TextBox_AverageBill.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(477, 518);
            label9.Name = "label9";
            label9.Size = new Size(164, 20);
            label9.TabIndex = 20;
            label9.Text = "Total Customers Served";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(826, 519);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 21;
            label10.Text = "Average Bill Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(652, 519);
            label11.Name = "label11";
            label11.Size = new Size(158, 20);
            label11.TabIndex = 22;
            label11.Text = "Total kWh's Consumed";
            // 
            // EnMaxGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(974, 578);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(TextBox_AverageBill);
            Controls.Add(TextBox_Totalkwh);
            Controls.Add(TextBox_TotalCustomers);
            Controls.Add(label8);
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
        private Label label8;
        private TextBox TextBox_TotalCustomers;
        private TextBox TextBox_Totalkwh;
        private TextBox TextBox_AverageBill;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
