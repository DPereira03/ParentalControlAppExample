namespace ParentalControlAppExample
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            LocButton = new Button();
            AIbutton = new Button();
            SOSButton = new Button();
            WebButton = new Button();
            AppButton = new Button();
            ScrButton = new Button();
            LckButton = new Button();
            VPNButton = new Button();
            DisplayBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LocButton
            // 
            LocButton.BackColor = Color.Crimson;
            LocButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LocButton.Location = new Point(42, 50);
            LocButton.Name = "LocButton";
            LocButton.Size = new Size(128, 65);
            LocButton.TabIndex = 0;
            LocButton.Text = "Location";
            LocButton.UseVisualStyleBackColor = false;
            LocButton.Click += LocButton_Click;
            // 
            // AIbutton
            // 
            AIbutton.BackColor = Color.Crimson;
            AIbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AIbutton.Location = new Point(42, 124);
            AIbutton.Name = "AIbutton";
            AIbutton.Size = new Size(128, 65);
            AIbutton.TabIndex = 1;
            AIbutton.Text = "AI Monitor";
            AIbutton.UseVisualStyleBackColor = false;
            AIbutton.Click += AIbutton_Click;
            // 
            // SOSButton
            // 
            SOSButton.BackColor = Color.Crimson;
            SOSButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SOSButton.Location = new Point(42, 209);
            SOSButton.Name = "SOSButton";
            SOSButton.Size = new Size(128, 65);
            SOSButton.TabIndex = 2;
            SOSButton.Text = "SOS";
            SOSButton.UseVisualStyleBackColor = false;
            SOSButton.Click += SOSButton_Click;
            // 
            // WebButton
            // 
            WebButton.BackColor = Color.Crimson;
            WebButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WebButton.Location = new Point(42, 291);
            WebButton.Name = "WebButton";
            WebButton.Size = new Size(128, 65);
            WebButton.TabIndex = 3;
            WebButton.Text = "Website Filter";
            WebButton.UseVisualStyleBackColor = false;
            WebButton.Click += WebButton_Click;
            // 
            // AppButton
            // 
            AppButton.BackColor = Color.Crimson;
            AppButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AppButton.Location = new Point(565, 50);
            AppButton.Name = "AppButton";
            AppButton.Size = new Size(128, 65);
            AppButton.TabIndex = 4;
            AppButton.Text = "Application filter";
            AppButton.UseVisualStyleBackColor = false;
            AppButton.Click += AppButton_Click;
            // 
            // ScrButton
            // 
            ScrButton.BackColor = Color.Crimson;
            ScrButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ScrButton.Location = new Point(565, 124);
            ScrButton.Name = "ScrButton";
            ScrButton.Size = new Size(128, 65);
            ScrButton.TabIndex = 5;
            ScrButton.Text = "Screen limit";
            ScrButton.UseVisualStyleBackColor = false;
            ScrButton.Click += ScrButton_Click;
            // 
            // LckButton
            // 
            LckButton.BackColor = Color.Crimson;
            LckButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LckButton.Location = new Point(565, 209);
            LckButton.Name = "LckButton";
            LckButton.Size = new Size(128, 65);
            LckButton.TabIndex = 6;
            LckButton.Text = "Phone lock";
            LckButton.UseVisualStyleBackColor = false;
            LckButton.Click += LckButton_Click;
            // 
            // VPNButton
            // 
            VPNButton.BackColor = Color.Crimson;
            VPNButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VPNButton.Location = new Point(565, 291);
            VPNButton.Name = "VPNButton";
            VPNButton.Size = new Size(128, 65);
            VPNButton.TabIndex = 7;
            VPNButton.Text = "VPN";
            VPNButton.UseVisualStyleBackColor = false;
            VPNButton.Click += VPNButton_Click;
            // 
            // DisplayBox
            // 
            DisplayBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayBox.Location = new Point(266, 69);
            DisplayBox.Name = "DisplayBox";
            DisplayBox.Size = new Size(232, 27);
            DisplayBox.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayBox);
            Controls.Add(VPNButton);
            Controls.Add(LckButton);
            Controls.Add(ScrButton);
            Controls.Add(AppButton);
            Controls.Add(WebButton);
            Controls.Add(SOSButton);
            Controls.Add(AIbutton);
            Controls.Add(LocButton);
            Name = "Form1";
            Text = "Adult's Device";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button LocButton;
        public Button AIbutton;
        public Button SOSButton;
        public Button WebButton;
        public Button AppButton;
        public Button ScrButton;
        public Button LckButton;
        public Button VPNButton;
        public TextBox DisplayBox;
        private System.Windows.Forms.Timer timer1;
    }
}