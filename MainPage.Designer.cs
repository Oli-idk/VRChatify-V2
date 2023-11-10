namespace VRChatify
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel1 = new Panel();
            BtnSettings = new Button();
            BtnMessages = new Button();
            PnlNav = new Panel();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label1 = new Label();
            LblUser = new Label();
            LblTitle = new Label();
            PnlFormLoader = new Panel();
            Status = new Label();
            panel3 = new Panel();
            ToggleButton = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(BtnSettings);
            panel1.Controls.Add(BtnMessages);
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // BtnSettings
            // 
            BtnSettings.Dock = DockStyle.Bottom;
            BtnSettings.FlatAppearance.BorderSize = 0;
            BtnSettings.FlatStyle = FlatStyle.Flat;
            BtnSettings.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            BtnSettings.Location = new Point(0, 534);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(186, 43);
            BtnSettings.TabIndex = 4;
            BtnSettings.Text = "Settings";
            BtnSettings.UseVisualStyleBackColor = true;
            // 
            // BtnMessages
            // 
            BtnMessages.Dock = DockStyle.Top;
            BtnMessages.FlatAppearance.BorderSize = 0;
            BtnMessages.FlatStyle = FlatStyle.Flat;
            BtnMessages.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMessages.ForeColor = Color.FromArgb(0, 126, 249);
            BtnMessages.Location = new Point(0, 107);
            BtnMessages.Name = "BtnMessages";
            BtnMessages.Size = new Size(186, 43);
            BtnMessages.TabIndex = 3;
            BtnMessages.Text = "Messages";
            BtnMessages.UseVisualStyleBackColor = true;
            BtnMessages.Click += BtnMessages_Click;
            BtnMessages.Leave += BtnMessages_Leave;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(0, 126, 249);
            PnlNav.Location = new Point(3, 428);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 100);
            PnlNav.TabIndex = 2;
            // 
            // BtnDashboard
            // 
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            BtnDashboard.Location = new Point(0, 64);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(186, 43);
            BtnDashboard.TabIndex = 0;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            BtnDashboard.Leave += BtnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(LblUser);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 64);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(61, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 16);
            label1.TabIndex = 2;
            label1.Text = "Version:";
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblUser.ForeColor = Color.FromArgb(0, 126, 249);
            LblUser.Location = new Point(74, 35);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(39, 16);
            LblUser.TabIndex = 1;
            LblUser.Text = "2.0.0";
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitle.ForeColor = Color.Gray;
            LblTitle.Location = new Point(6, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(147, 37);
            LblTitle.TabIndex = 1;
            LblTitle.Text = "Dashboard";
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.Dock = DockStyle.Bottom;
            PnlFormLoader.Location = new Point(186, 100);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(765, 477);
            PnlFormLoader.TabIndex = 2;
            PnlFormLoader.Paint += PnlFormLoader_Paint;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            Status.ForeColor = Color.Red;
            Status.Location = new Point(267, 0);
            Status.Name = "Status";
            Status.Size = new Size(231, 72);
            Status.TabIndex = 5;
            Status.Text = "Stopped";
            // 
            // panel3
            // 
            panel3.Controls.Add(ToggleButton);
            panel3.Controls.Add(LblTitle);
            panel3.Controls.Add(Status);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(186, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 100);
            panel3.TabIndex = 3;
            // 
            // ToggleButton
            // 
            ToggleButton.Appearance = Appearance.Button;
            ToggleButton.AutoSize = true;
            ToggleButton.Location = new Point(345, 76);
            ToggleButton.Name = "ToggleButton";
            ToggleButton.Size = new Size(70, 25);
            ToggleButton.TabIndex = 6;
            ToggleButton.Text = "Start/Stop";
            ToggleButton.UseVisualStyleBackColor = true;
            ToggleButton.CheckedChanged += ToggleButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panel3);
            Controls.Add(PnlFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainPage";
            Text = "VRChatify";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnDashboard;
        private Label LblUser;
        private PictureBox pictureBox1;
        private Panel PnlNav;
        private Label LblTitle;
        private Panel PnlFormLoader;
        private Label label1;
        private Button BtnSettings;
        private Button BtnMessages;
        private Label Status;
        private Panel panel3;
        private CheckBox ToggleButton;
    }
}