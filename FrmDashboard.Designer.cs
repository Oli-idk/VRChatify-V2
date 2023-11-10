namespace VRChatify
{
    partial class FrmDashboard
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
            panel1 = new Panel();
            ManualSend = new Button();
            ChatBoxMessage = new RichTextBox();
            label1 = new Label();
            BtnPrev = new Button();
            BtnNext = new Button();
            SessionCount = new Label();
            panel2 = new Panel();
            SessionName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ManualSend);
            panel1.Controls.Add(ChatBoxMessage);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 222);
            panel1.TabIndex = 2;
            // 
            // ManualSend
            // 
            ManualSend.BackColor = Color.FromArgb(98, 104, 134);
            ManualSend.FlatAppearance.BorderSize = 0;
            ManualSend.FlatStyle = FlatStyle.Flat;
            ManualSend.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ManualSend.Location = new Point(0, 17);
            ManualSend.Name = "ManualSend";
            ManualSend.Size = new Size(132, 58);
            ManualSend.TabIndex = 2;
            ManualSend.Text = "Send Message";
            ManualSend.UseVisualStyleBackColor = false;
            ManualSend.Click += ManualSend_Click;
            // 
            // ChatBoxMessage
            // 
            ChatBoxMessage.BackColor = Color.FromArgb(98, 104, 134);
            ChatBoxMessage.BorderStyle = BorderStyle.None;
            ChatBoxMessage.Dock = DockStyle.Bottom;
            ChatBoxMessage.Location = new Point(0, 74);
            ChatBoxMessage.Name = "ChatBoxMessage";
            ChatBoxMessage.Size = new Size(709, 148);
            ChatBoxMessage.TabIndex = 1;
            ChatBoxMessage.Text = "";
            ChatBoxMessage.TextChanged += ChatBoxMessage_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(255, 17);
            label1.Name = "label1";
            label1.Size = new Size(199, 54);
            label1.TabIndex = 0;
            label1.Text = "Text Input";
            // 
            // BtnPrev
            // 
            BtnPrev.BackColor = Color.FromArgb(98, 104, 134);
            BtnPrev.FlatAppearance.BorderSize = 0;
            BtnPrev.FlatStyle = FlatStyle.Flat;
            BtnPrev.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPrev.Location = new Point(165, 6);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(132, 58);
            BtnPrev.TabIndex = 3;
            BtnPrev.Text = "Previous";
            BtnPrev.UseVisualStyleBackColor = false;
            BtnPrev.Click += BtnPrev_Click;
            // 
            // BtnNext
            // 
            BtnNext.BackColor = Color.FromArgb(98, 104, 134);
            BtnNext.FlatAppearance.BorderSize = 0;
            BtnNext.FlatStyle = FlatStyle.Flat;
            BtnNext.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNext.Location = new Point(436, 6);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(132, 58);
            BtnNext.TabIndex = 4;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // SessionCount
            // 
            SessionCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SessionCount.AutoSize = true;
            SessionCount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SessionCount.ForeColor = SystemColors.Control;
            SessionCount.Location = new Point(337, 17);
            SessionCount.Name = "SessionCount";
            SessionCount.Size = new Size(58, 37);
            SessionCount.TabIndex = 5;
            SessionCount.Text = "0/0";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnPrev);
            panel2.Controls.Add(SessionCount);
            panel2.Controls.Add(BtnNext);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 406);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 71);
            panel2.TabIndex = 6;
            // 
            // SessionName
            // 
            SessionName.AutoSize = true;
            SessionName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SessionName.ForeColor = SystemColors.Control;
            SessionName.Location = new Point(301, 366);
            SessionName.Name = "SessionName";
            SessionName.Size = new Size(130, 37);
            SessionName.TabIndex = 6;
            SessionName.Text = "Unknown";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 72);
            ClientSize = new Size(733, 477);
            Controls.Add(SessionName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RichTextBox ChatBoxMessage;
        private Label label1;
        private Button ManualSend;
        private Button BtnPrev;
        private Button BtnNext;
        private Label SessionCount;
        private Panel panel2;
        private Label SessionName;
    }
}