﻿namespace ParentalControlAppExample
{
    partial class Form2
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
            label1 = new Label();
            SOSHelp = new Button();
            GameApp = new Button();
            BetApp = new Button();
            SearchBar = new TextBox();
            SearchBut = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 33);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Internet Search: Wi-Fi";
            // 
            // SOSHelp
            // 
            SOSHelp.BackColor = Color.AliceBlue;
            SOSHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SOSHelp.Location = new Point(627, 363);
            SOSHelp.Name = "SOSHelp";
            SOSHelp.RightToLeft = RightToLeft.Yes;
            SOSHelp.Size = new Size(129, 63);
            SOSHelp.TabIndex = 1;
            SOSHelp.Text = "SOS";
            SOSHelp.UseVisualStyleBackColor = false;
            SOSHelp.Visible = false;
            SOSHelp.Click += SOSHelp_Click;
            // 
            // GameApp
            // 
            GameApp.BackColor = Color.AliceBlue;
            GameApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GameApp.Location = new Point(51, 209);
            GameApp.Name = "GameApp";
            GameApp.Size = new Size(129, 63);
            GameApp.TabIndex = 2;
            GameApp.Text = "Game";
            GameApp.UseVisualStyleBackColor = false;
            GameApp.Click += GameApp_Click;
            // 
            // BetApp
            // 
            BetApp.BackColor = Color.AliceBlue;
            BetApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BetApp.Location = new Point(51, 320);
            BetApp.Name = "BetApp";
            BetApp.Size = new Size(129, 63);
            BetApp.TabIndex = 3;
            BetApp.Text = "Betting App";
            BetApp.UseVisualStyleBackColor = false;
            BetApp.Click += BetApp_Click;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(55, 69);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(410, 27);
            SearchBar.TabIndex = 4;
            SearchBar.Text = "Search";
            // 
            // SearchBut
            // 
            SearchBut.BackColor = Color.AliceBlue;
            SearchBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBut.Location = new Point(377, 102);
            SearchBut.Name = "SearchBut";
            SearchBut.Size = new Size(88, 34);
            SearchBut.TabIndex = 5;
            SearchBut.Text = "Search";
            SearchBut.UseVisualStyleBackColor = false;
            SearchBut.Click += SearchBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(573, 76);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 6;
            label2.Text = "Time left 20 seconds";
            label2.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(SearchBut);
            Controls.Add(SearchBar);
            Controls.Add(BetApp);
            Controls.Add(GameApp);
            Controls.Add(SOSHelp);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Child's Device";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Button SOSHelp;
        public Button GameApp;
        public Button BetApp;
        public TextBox SearchBar;
        public Button SearchBut;
        public Label label2;
    }
}