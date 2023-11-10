namespace VRChatify
{
    partial class FrmMessages
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
            BtnAddMsg = new Button();
            button1 = new Button();
            button2 = new Button();
            MessageCounter = new NumericUpDown();
            panel1 = new Panel();
            PnlMessages = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)MessageCounter).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAddMsg
            // 
            BtnAddMsg.Location = new Point(3, 3);
            BtnAddMsg.Name = "BtnAddMsg";
            BtnAddMsg.Size = new Size(31, 23);
            BtnAddMsg.TabIndex = 0;
            BtnAddMsg.Text = "+";
            BtnAddMsg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(40, 3);
            button1.Name = "button1";
            button1.Size = new Size(31, 23);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(36, 17);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MessageCounter
            // 
            MessageCounter.Dock = DockStyle.Top;
            MessageCounter.Location = new Point(0, 0);
            MessageCounter.Name = "MessageCounter";
            MessageCounter.Size = new Size(200, 23);
            MessageCounter.TabIndex = 0;
            MessageCounter.ValueChanged += MessageCounter_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(PnlMessages);
            panel1.Controls.Add(MessageCounter);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 414);
            panel1.TabIndex = 1;
            // 
            // PnlMessages
            // 
            PnlMessages.AutoScroll = true;
            PnlMessages.Dock = DockStyle.Fill;
            PnlMessages.Location = new Point(0, 23);
            PnlMessages.Name = "PnlMessages";
            PnlMessages.Size = new Size(200, 391);
            PnlMessages.TabIndex = 1;
            // 
            // FrmMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 72);
            ClientSize = new Size(717, 438);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMessages";
            Text = "FrmMessages";
            ((System.ComponentModel.ISupportInitialize)MessageCounter).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAddMsg;
        private Button button2;
        private Button button1;
        private NumericUpDown MessageCounter;
        private Panel panel1;
        private FlowLayoutPanel PnlMessages;
    }
}