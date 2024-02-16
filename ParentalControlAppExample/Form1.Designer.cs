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
            LocButton.Location = new Point(42, 50);
            LocButton.Name = "LocButton";
            LocButton.Size = new Size(128, 65);
            LocButton.TabIndex = 0;
            LocButton.Text = "Location";
            LocButton.UseVisualStyleBackColor = true;
            LocButton.Click += LocButton_Click;
            // 
            // AIbutton
            // 
            AIbutton.Location = new Point(42, 124);
            AIbutton.Name = "AIbutton";
            AIbutton.Size = new Size(128, 65);
            AIbutton.TabIndex = 1;
            AIbutton.Text = "AI Monitor";
            AIbutton.UseVisualStyleBackColor = true;
            // 
            // SOSButton
            // 
            SOSButton.Location = new Point(42, 209);
            SOSButton.Name = "SOSButton";
            SOSButton.Size = new Size(128, 65);
            SOSButton.TabIndex = 2;
            SOSButton.Text = "SOS";
            SOSButton.UseVisualStyleBackColor = true;
            SOSButton.Click += SOSButton_Click;
            // 
            // WebButton
            // 
            WebButton.Location = new Point(42, 291);
            WebButton.Name = "WebButton";
            WebButton.Size = new Size(128, 65);
            WebButton.TabIndex = 3;
            WebButton.Text = "Website Filter";
            WebButton.UseVisualStyleBackColor = true;
            WebButton.Click += WebButton_Click;
            // 
            // AppButton
            // 
            AppButton.Location = new Point(565, 50);
            AppButton.Name = "AppButton";
            AppButton.Size = new Size(128, 65);
            AppButton.TabIndex = 4;
            AppButton.Text = "Application filter";
            AppButton.UseVisualStyleBackColor = true;
            AppButton.Click += AppButton_Click;
            // 
            // ScrButton
            // 
            ScrButton.Location = new Point(565, 124);
            ScrButton.Name = "ScrButton";
            ScrButton.Size = new Size(128, 65);
            ScrButton.TabIndex = 5;
            ScrButton.Text = "Screen limit";
            ScrButton.UseVisualStyleBackColor = true;
            ScrButton.Click += ScrButton_Click;
            // 
            // LckButton
            // 
            LckButton.Location = new Point(565, 209);
            LckButton.Name = "LckButton";
            LckButton.Size = new Size(128, 65);
            LckButton.TabIndex = 6;
            LckButton.Text = "Phone lock";
            LckButton.UseVisualStyleBackColor = true;
            LckButton.Click += LckButton_Click;
            // 
            // VPNButton
            // 
            VPNButton.Location = new Point(565, 291);
            VPNButton.Name = "VPNButton";
            VPNButton.Size = new Size(128, 65);
            VPNButton.TabIndex = 7;
            VPNButton.Text = "VPN";
            VPNButton.UseVisualStyleBackColor = true;
            VPNButton.Click += VPNButton_Click;
            // 
            // DisplayBox
            // 
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