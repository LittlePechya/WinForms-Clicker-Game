namespace WinForms_Clicker_Game
{
    partial class MainForm
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
            this.clicker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentMoneyTextBox = new System.Windows.Forms.TextBox();
            this.TotalMoneyTextBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.QuadroClickPrice = new System.Windows.Forms.Label();
            this.QuadroClickDescription = new System.Windows.Forms.Label();
            this.QuadroClickName = new System.Windows.Forms.Label();
            this.QuadroClickActiveStatus = new System.Windows.Forms.Label();
            this.QuadroClickBuyButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoubleClickPrice = new System.Windows.Forms.Label();
            this.DoubleClickDescription = new System.Windows.Forms.Label();
            this.DoubleClickName = new System.Windows.Forms.Label();
            this.DoubleClickActiveStatus = new System.Windows.Forms.Label();
            this.DoubleClickBuyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextEditorCurrentPrice = new System.Windows.Forms.Label();
            this.TextEditorDescription = new System.Windows.Forms.Label();
            this.TextEditorName = new System.Windows.Forms.Label();
            this.TextEditorLevel = new System.Windows.Forms.Label();
            this.TextEditorBuyButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AutoClickerCurrentPrice = new System.Windows.Forms.Label();
            this.AutoClickerDescription = new System.Windows.Forms.Label();
            this.AutoClickerName = new System.Windows.Forms.Label();
            this.AutoClickerLevel = new System.Windows.Forms.Label();
            this.AutoClickerBuyButton = new System.Windows.Forms.Button();
            this.DoubleFarmerBoosterPanel = new System.Windows.Forms.Panel();
            this.DoubleFarmerBoosterPrice = new System.Windows.Forms.Label();
            this.DoubleFarmerBoosterDescription = new System.Windows.Forms.Label();
            this.DoubleFarmerBoosterName = new System.Windows.Forms.Label();
            this.DoubleFarmerBoosterActiveStatus = new System.Windows.Forms.Label();
            this.DoubleFarmerBoosterBuyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DoubleFarmerBoosterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clicker
            // 
            this.clicker.Font = new System.Drawing.Font("Pixelify Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clicker.ForeColor = System.Drawing.Color.LightGreen;
            this.clicker.Location = new System.Drawing.Point(334, 205);
            this.clicker.Name = "clicker";
            this.clicker.Size = new System.Drawing.Size(150, 50);
            this.clicker.TabIndex = 0;
            this.clicker.Text = "Click";
            this.clicker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pixelify Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(389, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentMoneyTextBox
            // 
            this.CurrentMoneyTextBox.Font = new System.Drawing.Font("Pixelify Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentMoneyTextBox.Location = new System.Drawing.Point(360, 85);
            this.CurrentMoneyTextBox.Name = "CurrentMoneyTextBox";
            this.CurrentMoneyTextBox.ReadOnly = true;
            this.CurrentMoneyTextBox.Size = new System.Drawing.Size(100, 35);
            this.CurrentMoneyTextBox.TabIndex = 2;
            this.CurrentMoneyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalMoneyTextBox
            // 
            this.TotalMoneyTextBox.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalMoneyTextBox.Location = new System.Drawing.Point(342, 368);
            this.TotalMoneyTextBox.Name = "TotalMoneyTextBox";
            this.TotalMoneyTextBox.Size = new System.Drawing.Size(128, 73);
            this.TotalMoneyTextBox.TabIndex = 3;
            this.TotalMoneyTextBox.Text = "Total $ earned:";
            this.TotalMoneyTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoubleFarmerBoosterPanel);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Pixelify Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 439);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boosters";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.QuadroClickPrice);
            this.panel4.Controls.Add(this.QuadroClickDescription);
            this.panel4.Controls.Add(this.QuadroClickName);
            this.panel4.Controls.Add(this.QuadroClickActiveStatus);
            this.panel4.Controls.Add(this.QuadroClickBuyButton);
            this.panel4.Location = new System.Drawing.Point(6, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 131);
            this.panel4.TabIndex = 6;
            // 
            // QuadroClickPrice
            // 
            this.QuadroClickPrice.AutoSize = true;
            this.QuadroClickPrice.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadroClickPrice.Location = new System.Drawing.Point(6, 97);
            this.QuadroClickPrice.Name = "QuadroClickPrice";
            this.QuadroClickPrice.Size = new System.Drawing.Size(69, 21);
            this.QuadroClickPrice.TabIndex = 5;
            this.QuadroClickPrice.Text = "Price: $";
            // 
            // QuadroClickDescription
            // 
            this.QuadroClickDescription.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadroClickDescription.Location = new System.Drawing.Point(4, 49);
            this.QuadroClickDescription.Name = "QuadroClickDescription";
            this.QuadroClickDescription.Size = new System.Drawing.Size(173, 48);
            this.QuadroClickDescription.TabIndex = 3;
            this.QuadroClickDescription.Text = "It\'s like double click, but better";
            // 
            // QuadroClickName
            // 
            this.QuadroClickName.AutoSize = true;
            this.QuadroClickName.Location = new System.Drawing.Point(3, 12);
            this.QuadroClickName.Name = "QuadroClickName";
            this.QuadroClickName.Size = new System.Drawing.Size(145, 28);
            this.QuadroClickName.TabIndex = 2;
            this.QuadroClickName.Text = "Quadro Click";
            // 
            // QuadroClickActiveStatus
            // 
            this.QuadroClickActiveStatus.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadroClickActiveStatus.Location = new System.Drawing.Point(180, 3);
            this.QuadroClickActiveStatus.Name = "QuadroClickActiveStatus";
            this.QuadroClickActiveStatus.Size = new System.Drawing.Size(117, 51);
            this.QuadroClickActiveStatus.TabIndex = 1;
            this.QuadroClickActiveStatus.Text = "Inactive";
            this.QuadroClickActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuadroClickBuyButton
            // 
            this.QuadroClickBuyButton.Location = new System.Drawing.Point(184, 70);
            this.QuadroClickBuyButton.Name = "QuadroClickBuyButton";
            this.QuadroClickBuyButton.Size = new System.Drawing.Size(100, 48);
            this.QuadroClickBuyButton.TabIndex = 0;
            this.QuadroClickBuyButton.Text = "Buy";
            this.QuadroClickBuyButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DoubleClickPrice);
            this.panel2.Controls.Add(this.DoubleClickDescription);
            this.panel2.Controls.Add(this.DoubleClickName);
            this.panel2.Controls.Add(this.DoubleClickActiveStatus);
            this.panel2.Controls.Add(this.DoubleClickBuyButton);
            this.panel2.Location = new System.Drawing.Point(6, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 136);
            this.panel2.TabIndex = 4;
            // 
            // DoubleClickPrice
            // 
            this.DoubleClickPrice.AutoSize = true;
            this.DoubleClickPrice.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleClickPrice.Location = new System.Drawing.Point(6, 97);
            this.DoubleClickPrice.Name = "DoubleClickPrice";
            this.DoubleClickPrice.Size = new System.Drawing.Size(69, 21);
            this.DoubleClickPrice.TabIndex = 5;
            this.DoubleClickPrice.Text = "Price: $";
            // 
            // DoubleClickDescription
            // 
            this.DoubleClickDescription.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleClickDescription.Location = new System.Drawing.Point(4, 49);
            this.DoubleClickDescription.Name = "DoubleClickDescription";
            this.DoubleClickDescription.Size = new System.Drawing.Size(173, 48);
            this.DoubleClickDescription.TabIndex = 3;
            this.DoubleClickDescription.Text = "Make every click like 2";
            // 
            // DoubleClickName
            // 
            this.DoubleClickName.AutoSize = true;
            this.DoubleClickName.Location = new System.Drawing.Point(3, 12);
            this.DoubleClickName.Name = "DoubleClickName";
            this.DoubleClickName.Size = new System.Drawing.Size(136, 28);
            this.DoubleClickName.TabIndex = 2;
            this.DoubleClickName.Text = "Double Click";
            // 
            // DoubleClickActiveStatus
            // 
            this.DoubleClickActiveStatus.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleClickActiveStatus.Location = new System.Drawing.Point(180, 3);
            this.DoubleClickActiveStatus.Name = "DoubleClickActiveStatus";
            this.DoubleClickActiveStatus.Size = new System.Drawing.Size(117, 51);
            this.DoubleClickActiveStatus.TabIndex = 1;
            this.DoubleClickActiveStatus.Text = "Inactive";
            this.DoubleClickActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoubleClickBuyButton
            // 
            this.DoubleClickBuyButton.Location = new System.Drawing.Point(184, 70);
            this.DoubleClickBuyButton.Name = "DoubleClickBuyButton";
            this.DoubleClickBuyButton.Size = new System.Drawing.Size(100, 48);
            this.DoubleClickBuyButton.TabIndex = 0;
            this.DoubleClickBuyButton.Text = "Buy";
            this.DoubleClickBuyButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Pixelify Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(502, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 439);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Farmers";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TextEditorCurrentPrice);
            this.panel3.Controls.Add(this.TextEditorDescription);
            this.panel3.Controls.Add(this.TextEditorName);
            this.panel3.Controls.Add(this.TextEditorLevel);
            this.panel3.Controls.Add(this.TextEditorBuyButton);
            this.panel3.Location = new System.Drawing.Point(6, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 152);
            this.panel3.TabIndex = 5;
            // 
            // TextEditorCurrentPrice
            // 
            this.TextEditorCurrentPrice.AutoSize = true;
            this.TextEditorCurrentPrice.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextEditorCurrentPrice.Location = new System.Drawing.Point(4, 112);
            this.TextEditorCurrentPrice.Name = "TextEditorCurrentPrice";
            this.TextEditorCurrentPrice.Size = new System.Drawing.Size(69, 21);
            this.TextEditorCurrentPrice.TabIndex = 4;
            this.TextEditorCurrentPrice.Text = "Price: $";
            // 
            // TextEditorDescription
            // 
            this.TextEditorDescription.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextEditorDescription.Location = new System.Drawing.Point(4, 49);
            this.TextEditorDescription.Name = "TextEditorDescription";
            this.TextEditorDescription.Size = new System.Drawing.Size(278, 45);
            this.TextEditorDescription.TabIndex = 3;
            this.TextEditorDescription.Text = "Power of docs will help you earn more money";
            // 
            // TextEditorName
            // 
            this.TextEditorName.AutoSize = true;
            this.TextEditorName.Location = new System.Drawing.Point(3, 9);
            this.TextEditorName.Name = "TextEditorName";
            this.TextEditorName.Size = new System.Drawing.Size(140, 28);
            this.TextEditorName.TabIndex = 2;
            this.TextEditorName.Text = "Text Editor";
            // 
            // TextEditorLevel
            // 
            this.TextEditorLevel.AutoSize = true;
            this.TextEditorLevel.Location = new System.Drawing.Point(213, 9);
            this.TextEditorLevel.Name = "TextEditorLevel";
            this.TextEditorLevel.Size = new System.Drawing.Size(69, 28);
            this.TextEditorLevel.TabIndex = 1;
            this.TextEditorLevel.Text = "LVL 0";
            // 
            // TextEditorBuyButton
            // 
            this.TextEditorBuyButton.Location = new System.Drawing.Point(184, 97);
            this.TextEditorBuyButton.Name = "TextEditorBuyButton";
            this.TextEditorBuyButton.Size = new System.Drawing.Size(100, 48);
            this.TextEditorBuyButton.TabIndex = 0;
            this.TextEditorBuyButton.Text = "Buy";
            this.TextEditorBuyButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AutoClickerCurrentPrice);
            this.panel1.Controls.Add(this.AutoClickerDescription);
            this.panel1.Controls.Add(this.AutoClickerName);
            this.panel1.Controls.Add(this.AutoClickerLevel);
            this.panel1.Controls.Add(this.AutoClickerBuyButton);
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 152);
            this.panel1.TabIndex = 0;
            // 
            // AutoClickerCurrentPrice
            // 
            this.AutoClickerCurrentPrice.AutoSize = true;
            this.AutoClickerCurrentPrice.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoClickerCurrentPrice.Location = new System.Drawing.Point(4, 112);
            this.AutoClickerCurrentPrice.Name = "AutoClickerCurrentPrice";
            this.AutoClickerCurrentPrice.Size = new System.Drawing.Size(69, 21);
            this.AutoClickerCurrentPrice.TabIndex = 4;
            this.AutoClickerCurrentPrice.Text = "Price: $";
            // 
            // AutoClickerDescription
            // 
            this.AutoClickerDescription.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoClickerDescription.Location = new System.Drawing.Point(4, 49);
            this.AutoClickerDescription.Name = "AutoClickerDescription";
            this.AutoClickerDescription.Size = new System.Drawing.Size(278, 45);
            this.AutoClickerDescription.TabIndex = 3;
            this.AutoClickerDescription.Text = "Why you need to do it by yourself?";
            // 
            // AutoClickerName
            // 
            this.AutoClickerName.AutoSize = true;
            this.AutoClickerName.Location = new System.Drawing.Point(3, 9);
            this.AutoClickerName.Name = "AutoClickerName";
            this.AutoClickerName.Size = new System.Drawing.Size(126, 28);
            this.AutoClickerName.TabIndex = 2;
            this.AutoClickerName.Text = "Autocliker";
            // 
            // AutoClickerLevel
            // 
            this.AutoClickerLevel.AutoSize = true;
            this.AutoClickerLevel.Location = new System.Drawing.Point(213, 9);
            this.AutoClickerLevel.Name = "AutoClickerLevel";
            this.AutoClickerLevel.Size = new System.Drawing.Size(69, 28);
            this.AutoClickerLevel.TabIndex = 1;
            this.AutoClickerLevel.Text = "LVL 0";
            // 
            // AutoClickerBuyButton
            // 
            this.AutoClickerBuyButton.Location = new System.Drawing.Point(184, 97);
            this.AutoClickerBuyButton.Name = "AutoClickerBuyButton";
            this.AutoClickerBuyButton.Size = new System.Drawing.Size(100, 48);
            this.AutoClickerBuyButton.TabIndex = 0;
            this.AutoClickerBuyButton.Text = "Buy";
            this.AutoClickerBuyButton.UseVisualStyleBackColor = true;
            // 
            // DoubleFarmerBoosterPanel
            // 
            this.DoubleFarmerBoosterPanel.Controls.Add(this.DoubleFarmerBoosterPrice);
            this.DoubleFarmerBoosterPanel.Controls.Add(this.DoubleFarmerBoosterDescription);
            this.DoubleFarmerBoosterPanel.Controls.Add(this.DoubleFarmerBoosterName);
            this.DoubleFarmerBoosterPanel.Controls.Add(this.DoubleFarmerBoosterActiveStatus);
            this.DoubleFarmerBoosterPanel.Controls.Add(this.DoubleFarmerBoosterBuyButton);
            this.DoubleFarmerBoosterPanel.Location = new System.Drawing.Point(6, 308);
            this.DoubleFarmerBoosterPanel.Name = "DoubleFarmerBoosterPanel";
            this.DoubleFarmerBoosterPanel.Size = new System.Drawing.Size(300, 131);
            this.DoubleFarmerBoosterPanel.TabIndex = 7;
            // 
            // DoubleFarmerBoosterPrice
            // 
            this.DoubleFarmerBoosterPrice.AutoSize = true;
            this.DoubleFarmerBoosterPrice.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleFarmerBoosterPrice.Location = new System.Drawing.Point(6, 97);
            this.DoubleFarmerBoosterPrice.Name = "DoubleFarmerBoosterPrice";
            this.DoubleFarmerBoosterPrice.Size = new System.Drawing.Size(69, 21);
            this.DoubleFarmerBoosterPrice.TabIndex = 5;
            this.DoubleFarmerBoosterPrice.Text = "Price: $";
            // 
            // DoubleFarmerBoosterDescription
            // 
            this.DoubleFarmerBoosterDescription.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleFarmerBoosterDescription.Location = new System.Drawing.Point(4, 49);
            this.DoubleFarmerBoosterDescription.Name = "DoubleFarmerBoosterDescription";
            this.DoubleFarmerBoosterDescription.Size = new System.Drawing.Size(173, 48);
            this.DoubleFarmerBoosterDescription.TabIndex = 3;
            this.DoubleFarmerBoosterDescription.Text = "Double income from farmers!";
            // 
            // DoubleFarmerBoosterName
            // 
            this.DoubleFarmerBoosterName.AutoSize = true;
            this.DoubleFarmerBoosterName.Location = new System.Drawing.Point(3, 12);
            this.DoubleFarmerBoosterName.Name = "DoubleFarmerBoosterName";
            this.DoubleFarmerBoosterName.Size = new System.Drawing.Size(170, 28);
            this.DoubleFarmerBoosterName.TabIndex = 2;
            this.DoubleFarmerBoosterName.Text = "Double Farmer";
            // 
            // DoubleFarmerBoosterActiveStatus
            // 
            this.DoubleFarmerBoosterActiveStatus.Font = new System.Drawing.Font("Pixelify Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleFarmerBoosterActiveStatus.Location = new System.Drawing.Point(180, 3);
            this.DoubleFarmerBoosterActiveStatus.Name = "DoubleFarmerBoosterActiveStatus";
            this.DoubleFarmerBoosterActiveStatus.Size = new System.Drawing.Size(117, 51);
            this.DoubleFarmerBoosterActiveStatus.TabIndex = 1;
            this.DoubleFarmerBoosterActiveStatus.Text = "Inactive";
            this.DoubleFarmerBoosterActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoubleFarmerBoosterBuyButton
            // 
            this.DoubleFarmerBoosterBuyButton.Location = new System.Drawing.Point(184, 70);
            this.DoubleFarmerBoosterBuyButton.Name = "DoubleFarmerBoosterBuyButton";
            this.DoubleFarmerBoosterBuyButton.Size = new System.Drawing.Size(100, 48);
            this.DoubleFarmerBoosterBuyButton.TabIndex = 0;
            this.DoubleFarmerBoosterBuyButton.Text = "Buy";
            this.DoubleFarmerBoosterBuyButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TotalMoneyTextBox);
            this.Controls.Add(this.CurrentMoneyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clicker);
            this.Name = "MainForm";
            this.Text = "ClickerGame by LittlePechya";
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DoubleFarmerBoosterPanel.ResumeLayout(false);
            this.DoubleFarmerBoosterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentMoneyTextBox;
        private System.Windows.Forms.Label TotalMoneyTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AutoClickerBuyButton;
        private System.Windows.Forms.Label AutoClickerLevel;
        private System.Windows.Forms.Label AutoClickerDescription;
        private System.Windows.Forms.Label AutoClickerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DoubleClickDescription;
        private System.Windows.Forms.Label DoubleClickName;
        private System.Windows.Forms.Label DoubleClickActiveStatus;
        private System.Windows.Forms.Button DoubleClickBuyButton;
        private System.Windows.Forms.Label AutoClickerCurrentPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TextEditorCurrentPrice;
        private System.Windows.Forms.Label TextEditorDescription;
        private System.Windows.Forms.Label TextEditorName;
        private System.Windows.Forms.Label TextEditorLevel;
        private System.Windows.Forms.Button TextEditorBuyButton;
        private System.Windows.Forms.Label DoubleClickPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label QuadroClickPrice;
        private System.Windows.Forms.Label QuadroClickDescription;
        private System.Windows.Forms.Label QuadroClickName;
        private System.Windows.Forms.Label QuadroClickActiveStatus;
        private System.Windows.Forms.Button QuadroClickBuyButton;
        private System.Windows.Forms.Panel DoubleFarmerBoosterPanel;
        private System.Windows.Forms.Label DoubleFarmerBoosterPrice;
        private System.Windows.Forms.Label DoubleFarmerBoosterDescription;
        private System.Windows.Forms.Label DoubleFarmerBoosterName;
        private System.Windows.Forms.Label DoubleFarmerBoosterActiveStatus;
        private System.Windows.Forms.Button DoubleFarmerBoosterBuyButton;
    }
}